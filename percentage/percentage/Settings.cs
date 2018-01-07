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

    class SettingsBattery : Settings
    {
        private static SettingsBattery instance;
        public static SettingsBattery Instance
        {
            get
            {
                if (instance == null)
                    instance = new SettingsBattery();
                return instance;
            }
        }
        private static string section = "battery";

        public Color foregroundColor {
            get { var defaultValue = "#FFFFFFFF";
                  return Utils.ColorFromString(storage.Read(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue)); }
            set { storage.Write(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), Utils.ColorToString(value)); }
        }

        public Color backgroundColor {
            get { var defaultValue = "#00000000";
                  return Utils.ColorFromString(storage.Read(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue)); }
            set { storage.Write(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), Utils.ColorToString(value)); }
        }

        public Color borderColor {
            get { var defaultValue = "#99FFFFFF";
                  return Utils.ColorFromString(storage.Read(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue)); }
            set { storage.Write(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), Utils.ColorToString(value)); }
        }

        public string fontName {
            get { var defaultValue = "Segoe UI";
                  return storage.Read(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.Write(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int fontSize {
            get { var defaultValue = 11;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int updateInterval {
            get { var defaultValue = 5000;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int enabled {
            get { var defaultValue = 1;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int startDelay {
            get { var defaultValue = 0;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }
    }

    class SettingsCpu: Settings
    {
        private static SettingsCpu instance;
        public static SettingsCpu Instance
        {
            get
            {
                if (instance == null)
                    instance = new SettingsCpu();
                return instance;
            }
        }
        private static string section = "cpu";

        public Color foregroundColor {
            get { var defaultValue = "#FFFFFFFF";
                  return Utils.ColorFromString(storage.Read(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue)); }
            set { storage.Write(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), Utils.ColorToString(value)); }
        }

        public Color backgroundColor {
            get { var defaultValue = "#00000000";
                  return Utils.ColorFromString(storage.Read(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue)); }
            set { storage.Write(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), Utils.ColorToString(value)); }
        }

        public Color borderColor {
            get { var defaultValue = "#99FFFFFF";
                  return Utils.ColorFromString(storage.Read(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue)); }
            set { storage.Write(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), Utils.ColorToString(value)); }
        }

        public int updateInterval {
            get { var defaultValue = 5000;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int pointWidth {
            get { var defaultValue = 2;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int enabled {
            get { var defaultValue = 1;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int startDelay {
            get { var defaultValue = 3000;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }
    }

    class SettingsRam: Settings
    {
        private static SettingsRam instance;
        public static SettingsRam Instance
        {
            get
            {
                if (instance == null)
                    instance = new SettingsRam();
                return instance;
            }
        }
        private static string section = "ram";

        public Color foregroundColor {
            get { var defaultValue = "#FF7777FF";
                  return Utils.ColorFromString(storage.Read(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue)); }
            set { storage.Write(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), Utils.ColorToString(value)); }
        }

        public Color backgroundColor {
            get { var defaultValue = "#00000000";
                  return Utils.ColorFromString(storage.Read(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue)); }
            set { storage.Write(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), Utils.ColorToString(value)); }
        }

        public Color borderColor {
            get { var defaultValue = "#99AAAAFF";
                  return Utils.ColorFromString(storage.Read(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue)); }
            set { storage.Write(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), Utils.ColorToString(value)); }
        }

        public int updateInterval {
            get { var defaultValue = 5000;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int pointWidth {
            get { var defaultValue = 2;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int enabled {
            get { var defaultValue = 1;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int startDelay {
            get { var defaultValue = 10000;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }
    }

    class SettingsNetwork : Settings
    {
        private static SettingsNetwork instance;
        public static SettingsNetwork Instance
        {
            get
            {
                if (instance == null)
                    instance = new SettingsNetwork();
                return instance;
            }
        }
        private static string section = "network";

        public Color foregroundColor {
            get { var defaultValue = "#FF00FF00";
                  return Utils.ColorFromString(storage.Read(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue)); }
            set { storage.Write(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), Utils.ColorToString(value)); }
        }

        public Color backgroundColor {
            get { var defaultValue = "#00000000";
                  return Utils.ColorFromString(storage.Read(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue)); }
            set { storage.Write(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), Utils.ColorToString(value)); }
        }

        public Color borderColor {
            get { var defaultValue = "#9900FF00";
                  return Utils.ColorFromString(storage.Read(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue)); }
            set { storage.Write(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), Utils.ColorToString(value)); }
        }

        public int updateInterval {
            get { var defaultValue = 5000;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int pointWidth {
            get { var defaultValue = 2;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int maxBandwith {
            get { var defaultValue = 10 * 1024 * 1024 / 8;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int enabled {
            get { var defaultValue = 1;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }

        public int startDelay {
            get { var defaultValue = 1000;
                  return storage.ReadInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), defaultValue); }
            set { storage.WriteInt(section, MethodBase.GetCurrentMethod().Name.Remove(0, 4), value); }
        }
    }

    class Settings
    {
        protected CachedStorage storage;
        //protected static Settings instance;

        //public static Settings Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new Settings();
        //        }
        //        return instance;
        //    }
        //}

        protected Settings()
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
