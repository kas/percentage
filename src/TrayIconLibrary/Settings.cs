using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Drawing;

namespace IconLibrary
{
    class Settings<T> where T : Settings<T>, new()
    {
        protected CachedStorage storage;
        protected string section;

        private static T _instance = new T();
        public static T Instance
        {
            get
            {
                return _instance;
            }
        }

        protected Settings()
        {
            storage = new CachedStorage();
        }

        public void Reload()
        {
            storage.Reload();
        }

        public string GetValueByMethod(MethodBase method, string defaultValue)
        {
            return storage.Read(section, method.Name.Remove(0, 4), defaultValue);
        }

        public Color GetValueByMethod_Color(MethodBase method, string defaultValue)
        {
            return Utils.ColorFromString(storage.Read(section, method.Name.Remove(0, 4), defaultValue));
        }

        public int GetValueByMethod(MethodBase method, int defaultValue)
        {
            return storage.ReadInt(section, method.Name.Remove(0, 4), defaultValue);
        }

        public void SetValueByMethod(MethodBase method, string value)
        {
            storage.Write(section, method.Name.Remove(0, 4), value);
        }

        public void SetValueByMethod(MethodBase method, Color value)
        {
            storage.Write(section, method.Name.Remove(0, 4), Utils.ColorToString(value));
        }

        public void SetValueByMethod(MethodBase method, int value)
        {
            storage.WriteInt(section, method.Name.Remove(0, 4), value);
        }

    }
}
