using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KartRiderDemoEditor
{
    class RiderProfile
    {
        public string NickName { get; set; }
        public string CharType { get; set; }
        public string KartType { get; set; }
        public int CharColor { get; set; }
        public short UnknownValue1 { get; set; }
        public int ModeClear { get; set; }
        public int UnknownValue2 { get; set; }
        public short UnknownValue3 { get; set; }

        private void init()
        {
            NickName = "";
            CharType = "";
            KartType = "";
            CharColor = 0;
            UnknownValue1 = 0;
            ModeClear = 0;
            UnknownValue2 = 0;
            UnknownValue3 = 0;
        }

        public RiderProfile()
        {
            init();
        }
        

        public RiderProfile(bool isRandom)
        {
            if (isRandom)
            {
                Random r = new Random();

                NickName = "에디터" + r.Next(1000, 9999).ToString();
                CharType = Enum.CHAR_TYPE[r.Next(0, Enum.CHAR_TYPE.GetLength(0) - 1), 0];
                KartType = Enum.KART_TYPE[r.Next(0, Enum.KART_TYPE.GetLength(0) - 1), 0];
                CharColor = Int32.Parse(Enum.COLOR_TYPE[r.Next(0, Enum.COLOR_TYPE.GetLength(0) - 1), 0]);
                UnknownValue1 = 0;
                ModeClear = 0;
                UnknownValue2 = 0;
                UnknownValue3 = 0;
            }
            else
            {
                init();
            }
        }

        public RiderProfile(RiderProfile copy)
        {
            NickName = copy.NickName;
            CharType = copy.CharType;
            KartType = copy.KartType;
            CharColor = copy.CharColor;
            UnknownValue1 = copy.UnknownValue1;
            ModeClear = copy.ModeClear;
            UnknownValue2 = copy.UnknownValue2;
            UnknownValue3 = copy.UnknownValue3;
        }
    }
}
