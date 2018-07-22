﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Drawing;
using IconLibrary;

namespace RamIcon
{
    class CustomSettings : Settings<CustomSettings>
    {
        public CustomSettings()
        {
            this.section = "ram";
        }

        public Color foregroundColor
        {
            get { return GetValueByMethod_Color(MethodBase.GetCurrentMethod(), "#FF7777FF"); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value);  }
        }

        public Color backgroundColor
        {
            get { return GetValueByMethod_Color(MethodBase.GetCurrentMethod(), "#00000000"); }
            set { SetValueByMethod(MethodBase.GetCurrentMethod(), value); }
        }

        public Color borderColor
        {
            get { return GetValueByMethod_Color(MethodBase.GetCurrentMethod(), "#99AAAAFF"); }
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
