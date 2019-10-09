﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KartRiderDemoEditor
{
    class RiderProfile
    {
        private string nickName;
        private string charType;
        private string kartType;
        private int charColor;
        private short unknownValue1;
        private int modeClear;
        private int unknownValue2;
        private short unknownValue3;

        public string NickName { get; set; }
        public string CharType { get; set; }
        public string KartType { get; set; }
        public int CharColor { get; set; }
        public short UnknownValue1 { get; set; }
        public int ModeClear { get; set; }
        public int UnknownValue2 { get; set; }
        public short UnknownValue3 { get; set; }
    }
}