using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KartRiderDemoEditor
{
	static class Enum
	{
        public static const string[,] KART_TYPE = new string[,] 
        { 
            {"practice1", "연습카트"},

            {"burst1", "버스트 C1"},
            {"burst2", "버스트 E2"},
            {"burst3", "버스트 G3"},
            {"burst4", "버스트 R4"},
            {"burst5", "버스트 Pro"},
            
            {"cotten1", "코튼 C1"},
            {"cotten2", "코튼 E2"},
            {"cotten3", "코튼 G3"},
            {"cotten4", "코튼 R4"},
            {"cotten5", "코튼 Pro"},
            
            {"marathon1", "마라톤 C1"},
            {"marathon2", "마라톤 E2"},
            {"marathon3", "마라톤 G3"},
            {"marathon4", "마라톤 R4"},
            {"marathon5", "마라톤 Pro"},
            
            {"saber1", "세이버 C1"},
            {"saber2", "세이버 E2"},
            {"saber3", "세이버 G3"},
            {"saber4", "세이버 R4"},
            {"saber5", "세이버 Pro"},
            
            {"solid1", "솔리드 C1"},
            {"solid2", "솔리드 E2"},
            {"solid3", "솔리드 G3"},
            {"solid4", "솔리드 R4"},
            {"solid5", "솔리드 Pro"},
        };

        public static int getKartTypeIndex(string from)
        {
            for (int i = 0; i < KART_TYPE.Length; i++)
            {
                if (KART_TYPE[i, 0] == from || KART_TYPE[i, 1] == from) 
                {
                    return i;
                }
            }
            return -1;
        }

        public static const string[,] CHAR_TYPE = new string[,] 
        { 
            {"dao", "다오"},
            {"dizni", "디지니"},
            {"bazzi", "배찌"},
            {"marid", "마리드"},
            {"mos", "모스"},
            {"ethi", "에띠"},
            {"kephi", "케피"},
            {"uni", "우니"},
            {"santa", "산타"},
            {"lodumani", "로두마니"},
        };

        public static int getCharTypeIndex(string from)
        {
            for (int i = 0; i < CHAR_TYPE.Length; i++)
            {
                if (CHAR_TYPE[i, 0] == from || CHAR_TYPE[i, 1] == from)
                {
                    return i;
                }
            }
            return -1;
        }

        public static const string[,] COLOR_TYPE = new string[,] 
        { 
            {"0", "빨강", "FF0000"},
            {"1", "노랑", "FFFF00"},
            {"2", "주황", ""},
            {"3", "초록", ""},
            {"4", "청록", ""},
            {"5", "파랑", ""},
            {"6", "보라", ""},
            {"7", "블랙", ""},
            {"8", "핑크", ""},
            {"9", "화이트", ""},
        };

        public static int getColorTypeIndex(string from)
        {
            for (int i = 0; i < COLOR_TYPE.Length; i++)
            {
                if (COLOR_TYPE[i, 0] == from || COLOR_TYPE[i, 1] == from)
                {
                    return i;
                }
            }
            return -1;
        }
	}
}
