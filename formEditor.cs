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

        public formEditor()
        {
            InitializeComponent();

            riderProfiles = new ArrayList();
        }

        // 프로필 불러오기
        private void loadProfileFromFile()
        {
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

        private void loadProfile(int index)
        {
            RiderProfile profile = (RiderProfile)riderProfiles[index];
            textNick.Text = profile.NickName;
        }

        private void comboProfle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboProfle.SelectedIndex;
            loadProfile(index);
        }
    }
}
