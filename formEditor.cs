using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using System.IO;

namespace KartRiderDemoEditor
{
    public partial class formEditor : Form
    {
        private ArrayList riderProfiles;
        private bool isLoading = false;

        public formEditor()
        {
            InitializeComponent();

            riderProfiles = new ArrayList(); // 라이더 프로필 배열

            // 카트바디 종류
            for (int i = 0; i < Enum.KART_TYPE.GetLength(0); i++)
            {
                comboKartType.Items.Add(Enum.KART_TYPE[i, 1]);
            }

            // 캐릭터 종류
            for (int i = 0; i < Enum.CHAR_TYPE.GetLength(0); i++)
            {
                comboChar.Items.Add(Enum.CHAR_TYPE[i, 1]);
            }

            // 색깔 종류
            for (int i = 0; i < Enum.COLOR_TYPE.GetLength(0); i++)
            {
                comboCharColor.Items.Add(Enum.COLOR_TYPE[i, 1]);
            }

            // 이벤트 부착
            textNick.TextChanged += profileData_Changed;
            comboChar.SelectedIndexChanged += profileData_Changed;
            comboCharColor.SelectedIndexChanged += profileData_Changed;
            comboKartType.SelectedIndexChanged += profileData_Changed;
            checkMission1.CheckedChanged += profileData_Changed;
            checkMission2.CheckedChanged += profileData_Changed;
        }

        // 프로필 저장하기
        private void saveProfileToFile()
        {
            string documentRoot = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = documentRoot + @"\카트라이더\라이더데이터\riderData.1s";

            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            // 프로필 개수
            int profileCount = riderProfiles.Count;
            writeIntToFs(fs, profileCount);

            for (int i = 0; i < profileCount; i++)
            {
                RiderProfile profile = (RiderProfile)riderProfiles[i];

                writeStringToFs(fs, profile.NickName);
                writeStringToFs(fs, profile.CharType);
                writeStringToFs(fs, profile.KartType);
                writeIntToFs(fs, profile.CharColor);
                writeIntToFs(fs, profile.UnknownValue1, 2);
                writeIntToFs(fs, profile.ModeClear);
                writeIntToFs(fs, profile.UnknownValue2);
                writeIntToFs(fs, profile.UnknownValue3, 2);
            }

            fs.Close();

            MessageBox.Show("저장되었습니다.");
        }

        // FS에 int 쓰기
        private void writeIntToFs(FileStream fs, int value, int size = 4)
        {
            byte[] buffer = null;

            switch(size) 
            {
                case 1:
                    byte b = (byte)value;
                    buffer = BitConverter.GetBytes(b);
                    break;
                case 2:
                    short s = (short)value;
                    buffer = BitConverter.GetBytes(s);
                    break;
                case 4:
                    int i = value;
                    buffer = BitConverter.GetBytes(i);
                    break;
            }

            if(buffer != null) 
            {
                fs.Write(buffer, 0, size);
            }
        }

        // FS에 string 쓰기
        private void writeStringToFs(FileStream fs, string value)
        {
            writeIntToFs(fs, value.Length, 4);

            byte[] buffer = Encoding.Unicode.GetBytes(value);
            fs.Write(buffer, 0, buffer.Length);
        }

        // 프로필 불러오기
        private void loadProfileFromFile()
        {
            isLoading = true;

            string documentRoot = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = documentRoot + @"\카트라이더\라이더데이터\riderData.1s";

            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            fs.Seek(0, SeekOrigin.Begin);

            int profileCount = readIntFromFs(fs);

            comboProfle.Items.Clear();

            for (int i = 0; i < profileCount; i++)
            {
                RiderProfile profile = new RiderProfile();

                string nickName = readStringFromFs(fs);
                string charType = readStringFromFs(fs);
                string kartType = readStringFromFs(fs);
                int charColor = readIntFromFs(fs);
                short unkValue1 = (short)readIntFromFs(fs, 2);
                int modeClear = readIntFromFs(fs);
                int unkValue2 = readIntFromFs(fs);
                short unkValue3 = (short)readIntFromFs(fs, 2);

                profile.NickName = nickName;
                profile.CharType = charType;
                profile.KartType = kartType;
                profile.CharColor = charColor;
                profile.UnknownValue1 = unkValue1;
                profile.ModeClear = modeClear;
                profile.UnknownValue2 = unkValue2;
                profile.UnknownValue3 = unkValue3;

                riderProfiles.Add(profile);
                comboProfle.Items.Add(nickName);
            }

            fs.Close();

            MessageBox.Show("프로필을 불러왔습니다.");

            if (comboProfle.Items.Count > 0)
            {
                comboProfle.SelectedIndex = 0;
                loadProfile(0);
                panelProfileSub.Enabled = true;
            }
            else
            {
                panelProfileSub.Enabled = false;
            }

            isLoading = false;
        }

        // FS로부터 x바이트 정수 읽기
        private int readIntFromFs(FileStream fs, int bytes = 4)
        {
            byte[] buffer = new byte[8];
            fs.Read(buffer, 0, bytes);
            return BitConverter.ToInt32(buffer, 0);
        }

        // FS로부터 텍스트 읽기
        private string readStringFromFs(FileStream fs)
        {
            int length = readIntFromFs(fs) * 2;
            byte[] buffer = new byte[length];
            fs.Read(buffer, 0, length);
            return Encoding.Unicode.GetString(buffer);
        }

        private void menuProfileLoad_Click(object sender, EventArgs e)
        {
            loadProfileFromFile();
        }

        private void saveProfile(int index = -1)
        {
            if(index == -1) 
            {
                index = comboProfle.SelectedIndex;
            }

            if (isLoading)
            {
                return;
            }

            string nickName = textNick.Text;

            int kartIndex = comboKartType.SelectedIndex;
            int charIndex = comboChar.SelectedIndex;
            int charColorIndex = comboCharColor.SelectedIndex;

            string kartCode = Enum.KART_TYPE[kartIndex, 0];
            string charCode = Enum.CHAR_TYPE[charIndex, 0];
            int charColorCode = Int32.Parse( Enum.COLOR_TYPE[charColorIndex, 0] );

            int modeClear = 0;
            modeClear += checkMission1.Checked ? 1 : 0;
            modeClear += checkMission2.Checked ? 2 : 0;

            RiderProfile profile = (RiderProfile)riderProfiles[index];
            profile.NickName = nickName;
            profile.KartType = kartCode;
            profile.CharType = charCode;
            profile.CharColor = charColorCode;
            profile.ModeClear = modeClear;

            comboProfle.Items[index] = nickName;
        }

        // 프로필을 UI에 뿌리기
        private void loadProfile(int index)
        {
            isLoading = true;

            RiderProfile profile = (RiderProfile)riderProfiles[index];
            
            textNick.Text = profile.NickName;
            
            int kartIndex = Enum.getKartTypeIndex(profile.KartType);
            comboKartType.SelectedIndex = kartIndex;

            int charIndex = Enum.getCharTypeIndex(profile.CharType);
            comboChar.SelectedIndex = charIndex;

            int charColorIndex = Enum.getColorTypeIndex(profile.CharColor.ToString());
            comboCharColor.SelectedIndex = charColorIndex;

            checkMission1.Checked = (profile.ModeClear & 1) != 0;
            checkMission2.Checked = (profile.ModeClear & 2) != 0;

            isLoading = false;
        }

        private void comboProfle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboProfle.SelectedIndex;
            loadProfile(index);
        }

        private void profileData_Changed(object sender, EventArgs e)
        {
            saveProfile();
        }

        private void menuProfileSave_Click(object sender, EventArgs e)
        {
            saveProfileToFile();
        }
    }
}
