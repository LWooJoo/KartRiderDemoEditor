using System;
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

        private void init()
        {
            nickName = "";
            charType = "";
            kartType = "";
            charColor = 0;
            unknownValue1 = 0;
            modeClear = 0;
            unknownValue2 = 0;
            unknownValue3 = 0;
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

                nickName = "에디터" + r.Next(1000, 9999).ToString();
                charType = Enum.CHAR_TYPE[r.Next(0, Enum.CHAR_TYPE.GetLength(0) - 1), 0];
                kartType = Enum.KART_TYPE[r.Next(0, Enum.KART_TYPE.GetLength(0) - 1), 0];
                charColor = Int32.Parse(Enum.COLOR_TYPE[r.Next(0, Enum.COLOR_TYPE.GetLength(0) - 1), 0]);
                unknownValue1 = 0;
                modeClear = 0;
                unknownValue2 = 0;
                unknownValue3 = 0;
            }
            else
            {
                init();
            }
        }

        public RiderProfile(RiderProfile copy)
        {
            nickName = copy.nickName;
            charType = copy.charType;
            kartType = copy.kartType;
            charColor = copy.charColor;
            unknownValue1 = copy.unknownValue1;
            modeClear = copy.modeClear;
            unknownValue2 = copy.unknownValue2;
            unknownValue3 = copy.unknownValue3;
        }
    }
}
