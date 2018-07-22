using System;
using System.Collections.Generic;
using System.Text;

namespace IconLibrary
{
    class CachedStorage
    {
        private IniFile storage;

        // cache for readed values
        private Dictionary<string, string> cache;

        public CachedStorage()
        {
            storage = new IniFile("settings.ini");
            cache = new Dictionary<string, string>();
        }

        public string Read(string section, string name, string default_value = "")
        {
            if (cache.ContainsKey(name))
            {
                // get from cache
                return cache[name];
            }
            else
            {
                // read with default value
                string value = storage.ReadString(section, name);
                if (value.Length == 0)
                    value = default_value;
                // and save to cache
                cache[name] = value;
                return value;
            }
        }

        public void Write(string section, string name, string value)
        {
            storage.WriteString(section, name, value);
            // also change cached value
            cache[name] = value;
        }

        public void Reload()
        {
            // clear cache (for getting external changes)
            cache.Clear();
        }

        public void WriteInt(string section, string name, int value)
        {
            Write(section, name, value.ToString());
        }

        public int ReadInt(string section, string name, int default_value = 0)
        {
            string value = Read(section, name, default_value.ToString());
            return Convert.ToInt32(value);
        }
    }
}
