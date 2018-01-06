using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace percentage
{
    class Settings
    {
        private CachedStorage storage;

        // public settings

        public Color foregroundColor {
            get { var defaultValue = "#FFFFFFFF";
                  return Utils.ColorFromString(storage.Read(MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue)); }
            set { storage.Write(MethodBase.GetCurrentMethod().Name.Remove(0, 4), Utils.ColorToString(value)); }
        }

        public Color backgroundColor {
            get { var defaultValue = "#00000000";
                  return Utils.ColorFromString(storage.Read(MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue)); }
            set { storage.Write(MethodBase.GetCurrentMethod().Name.Remove(0, 4), Utils.ColorToString(value)); }
        }

        public string fontName {
            get { var defaultValue = "Segoe UI";
                  return storage.Read(MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.Write(MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int fontSize {
            get { var defaultValue = 14;
                  return storage.ReadInt(MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int updateInterval {
            get { var defaultValue = 5000;
                  return storage.ReadInt(MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public Settings()
        {
            storage = new CachedStorage();
        }

        public void Reload()
        {
            storage.Reload();
        }
    }

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

        public string Read(string name, string default_value = "")
        {
            if (cache.ContainsKey(name))
            {
                // get from cache
                return cache[name];
            }
            else
            {
                // read with default value
                string value = storage.ReadString("settings", name);
                if (value.Length == 0)
                    value = default_value;
                // and save to cache
                cache[name] = value;
                return value;
            }
        }

        public void Write(string name, string value)
        {
            storage.WriteString("settings", name, value);
            // also change cached value
            cache[name] = value;
        }

        public void Reload()
        {
            // clear cache (for getting external changes)
            cache.Clear();
        }

        public void WriteInt(string name, int value)
        {
            Write(name, value.ToString());
        }

        public int ReadInt(string name, int default_value = 0)
        {
            string value = Read(name, default_value.ToString());
            return Convert.ToInt32(value);
        }
    }

    class IniFile
    {
        string Path;
        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile(string IniPath)
        {
            Path = new FileInfo(IniPath).FullName.ToString();
        }

        public string ReadString(string Section, string Key)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void WriteString(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            WriteString(Section, Key, null);
        }

        public void DeleteSection(string Section = null)
        {
            WriteString(Section, null, null);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return ReadString(Section, Key).Length > 0;
        }
    }
}
