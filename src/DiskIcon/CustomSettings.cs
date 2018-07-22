using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Drawing;
using IconLibrary;

namespace DiskIcon
{
    class CustomSettings : Settings<CustomSettings>
    {
        public CustomSettings()
        {
            this.section = "disk";
        }

        public Color foregroundColor_disk1
        {
            get { return GetValueByMethod_Color(MethodBase.GetCurrentMethod(), "#77ACACAC"); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value); }
        }

        public Color foregroundColor_disk2
        {
            get { return GetValueByMethod_Color(MethodBase.GetCurrentMethod(), "#A1AAAA00"); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value); }
        }

        public Color foregroundColor_disk3
        {
            get { return GetValueByMethod_Color(MethodBase.GetCurrentMethod(), "#A1FFFF00"); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value); }
        }

        public Color backgroundColor
        {
            get { return GetValueByMethod_Color(MethodBase.GetCurrentMethod(), "#00000000"); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value); }
        }

        public Color borderColor
        {
            get { return GetValueByMethod_Color(MethodBase.GetCurrentMethod(), "#99FF0000"); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value); }
        }

        public string name_disk1
        {
            get { return GetValueByMethod(MethodBase.GetCurrentMethod(), "_Total"); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value); }
        }

        public string name_disk2
        {
            get { return GetValueByMethod(MethodBase.GetCurrentMethod(), ""); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value); }
        }

        public string name_disk3
        {
            get { return GetValueByMethod(MethodBase.GetCurrentMethod(), ""); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value); }
        }

        public int updateInterval
        {
            get { return GetValueByMethod(MethodBase.GetCurrentMethod(), 1000); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value); }
        }

        public int pointWidth
        {
            get { return GetValueByMethod(MethodBase.GetCurrentMethod(), 2); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value); }
        }

    }
}
