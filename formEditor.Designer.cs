namespace KartRiderDemoEditor
{
    partial class formEditor
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.menuProfileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProfileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.panelProfileMain = new System.Windows.Forms.Panel();
            this.buttonDeleteProfile = new System.Windows.Forms.Button();
            this.buttonAddProfile = new System.Windows.Forms.Button();
            this.panelProfileSub = new System.Windows.Forms.Panel();
            this.checkMission2 = new System.Windows.Forms.CheckBox();
            this.checkMission1 = new System.Windows.Forms.CheckBox();
            this.comboCharColor = new System.Windows.Forms.ComboBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboKartType = new System.Windows.Forms.ComboBox();
            this.labelKart = new System.Windows.Forms.Label();
            this.comboChar = new System.Windows.Forms.ComboBox();
            this.labelChar = new System.Windows.Forms.Label();
            this.textNick = new System.Windows.Forms.TextBox();
            this.labelNick = new System.Windows.Forms.Label();
            this.comboProfle = new System.Windows.Forms.ComboBox();
            this.labelProfile = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuTop.SuspendLayout();
            this.panelProfileMain.SuspendLayout();
            this.panelProfileSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTop
            // 
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProfileLoad,
            this.menuProfileSave});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(444, 24);
            this.menuTop.TabIndex = 0;
            this.menuTop.Text = "menuStrip1";
            // 
            // menuProfileLoad
            // 
            this.menuProfileLoad.Name = "menuProfileLoad";
            this.menuProfileLoad.Size = new System.Drawing.Size(107, 20);
            this.menuProfileLoad.Text = "프로필 불러오기";
            this.menuProfileLoad.Click += new System.EventHandler(this.menuProfileLoad_Click);
            // 
            // menuProfileSave
            // 
            this.menuProfileSave.Name = "menuProfileSave";
            this.menuProfileSave.Size = new System.Drawing.Size(107, 20);
            this.menuProfileSave.Text = "프로필 저장하기";
            this.menuProfileSave.Click += new System.EventHandler(this.menuProfileSave_Click);
            // 
            // panelProfileMain
            // 
            this.panelProfileMain.Controls.Add(this.buttonDeleteProfile);
            this.panelProfileMain.Controls.Add(this.buttonAddProfile);
            this.panelProfileMain.Controls.Add(this.panelProfileSub);
            this.panelProfileMain.Controls.Add(this.comboProfle);
            this.panelProfileMain.Controls.Add(this.labelProfile);
            this.panelProfileMain.Enabled = false;
            this.panelProfileMain.Location = new System.Drawing.Point(12, 27);
            this.panelProfileMain.Name = "panelProfileMain";
            this.panelProfileMain.Size = new System.Drawing.Size(420, 219);
            this.panelProfileMain.TabIndex = 1;
            // 
            // buttonDeleteProfile
            // 
            this.buttonDeleteProfile.Location = new System.Drawing.Point(362, 13);
            this.buttonDeleteProfile.Name = "buttonDeleteProfile";
            this.buttonDeleteProfile.Size = new System.Drawing.Size(42, 23);
            this.buttonDeleteProfile.TabIndex = 5;
            this.buttonDeleteProfile.Text = "삭제";
            this.buttonDeleteProfile.UseVisualStyleBackColor = true;
            this.buttonDeleteProfile.Click += new System.EventHandler(this.buttonDeleteProfile_Click);
            // 
            // buttonAddProfile
            // 
            this.buttonAddProfile.Location = new System.Drawing.Point(314, 13);
            this.buttonAddProfile.Name = "buttonAddProfile";
            this.buttonAddProfile.Size = new System.Drawing.Size(42, 23);
            this.buttonAddProfile.TabIndex = 4;
            this.buttonAddProfile.Text = "추가";
            this.buttonAddProfile.UseVisualStyleBackColor = true;
            this.buttonAddProfile.Click += new System.EventHandler(this.buttonAddProfile_Click);
            // 
            // panelProfileSub
            // 
            this.panelProfileSub.Controls.Add(this.checkMission2);
            this.panelProfileSub.Controls.Add(this.checkMission1);
            this.panelProfileSub.Controls.Add(this.comboCharColor);
            this.panelProfileSub.Controls.Add(this.labelColor);
            this.panelProfileSub.Controls.Add(this.comboKartType);
            this.panelProfileSub.Controls.Add(this.labelKart);
            this.panelProfileSub.Controls.Add(this.comboChar);
            this.panelProfileSub.Controls.Add(this.labelChar);
            this.panelProfileSub.Controls.Add(this.textNick);
            this.panelProfileSub.Controls.Add(this.labelNick);
            this.panelProfileSub.Location = new System.Drawing.Point(3, 40);
            this.panelProfileSub.Name = "panelProfileSub";
            this.panelProfileSub.Size = new System.Drawing.Size(414, 179);
            this.panelProfileSub.TabIndex = 3;
            // 
            // checkMission2
            // 
            this.checkMission2.AutoSize = true;
            this.checkMission2.Location = new System.Drawing.Point(211, 151);
            this.checkMission2.Name = "checkMission2";
            this.checkMission2.Size = new System.Drawing.Size(142, 16);
            this.checkMission2.TabIndex = 9;
            this.checkMission2.Text = "연속코너돌기1 클리어";
            this.checkMission2.UseVisualStyleBackColor = true;
            // 
            // checkMission1
            // 
            this.checkMission1.AutoSize = true;
            this.checkMission1.Location = new System.Drawing.Point(87, 151);
            this.checkMission1.Name = "checkMission1";
            this.checkMission1.Size = new System.Drawing.Size(118, 16);
            this.checkMission1.TabIndex = 8;
            this.checkMission1.Text = "뱅크트랙1 클리어";
            this.checkMission1.UseVisualStyleBackColor = true;
            // 
            // comboCharColor
            // 
            this.comboCharColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCharColor.FormattingEnabled = true;
            this.comboCharColor.Location = new System.Drawing.Point(87, 116);
            this.comboCharColor.Name = "comboCharColor";
            this.comboCharColor.Size = new System.Drawing.Size(314, 20);
            this.comboCharColor.TabIndex = 7;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(12, 120);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(69, 12);
            this.labelColor.TabIndex = 6;
            this.labelColor.Text = "캐릭터 색상";
            // 
            // comboKartType
            // 
            this.comboKartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKartType.FormattingEnabled = true;
            this.comboKartType.Location = new System.Drawing.Point(87, 82);
            this.comboKartType.Name = "comboKartType";
            this.comboKartType.Size = new System.Drawing.Size(314, 20);
            this.comboKartType.TabIndex = 5;
            // 
            // labelKart
            // 
            this.labelKart.AutoSize = true;
            this.labelKart.Location = new System.Drawing.Point(28, 86);
            this.labelKart.Name = "labelKart";
            this.labelKart.Size = new System.Drawing.Size(53, 12);
            this.labelKart.TabIndex = 4;
            this.labelKart.Text = "카트바디";
            // 
            // comboChar
            // 
            this.comboChar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChar.FormattingEnabled = true;
            this.comboChar.Location = new System.Drawing.Point(87, 48);
            this.comboChar.Name = "comboChar";
            this.comboChar.Size = new System.Drawing.Size(314, 20);
            this.comboChar.TabIndex = 3;
            // 
            // labelChar
            // 
            this.labelChar.AutoSize = true;
            this.labelChar.Location = new System.Drawing.Point(40, 53);
            this.labelChar.Name = "labelChar";
            this.labelChar.Size = new System.Drawing.Size(41, 12);
            this.labelChar.TabIndex = 2;
            this.labelChar.Text = "캐릭터";
            // 
            // textNick
            // 
            this.textNick.Location = new System.Drawing.Point(87, 13);
            this.textNick.Name = "textNick";
            this.textNick.Size = new System.Drawing.Size(314, 21);
            this.textNick.TabIndex = 1;
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Location = new System.Drawing.Point(40, 18);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(41, 12);
            this.labelNick.TabIndex = 0;
            this.labelNick.Text = "닉네임";
            // 
            // comboProfle
            // 
            this.comboProfle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProfle.FormattingEnabled = true;
            this.comboProfle.Location = new System.Drawing.Point(90, 14);
            this.comboProfle.Name = "comboProfle";
            this.comboProfle.Size = new System.Drawing.Size(218, 20);
            this.comboProfle.TabIndex = 2;
            this.comboProfle.SelectedIndexChanged += new System.EventHandler(this.comboProfle_SelectedIndexChanged);
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Location = new System.Drawing.Point(15, 19);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(69, 12);
            this.labelProfile.TabIndex = 1;
            this.labelProfile.Text = "프로필 선택";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkLabel1.Location = new System.Drawing.Point(10, 246);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(338, 11);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "만든이: 스마트석 (smartse0k@naver.com) at www.gckom.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(10, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 11);
            this.label2.TabIndex = 3;
            this.label2.Text = "이 프로그램은 github(@smartse0k)에서 소스코드와 함께 배포되고 있습니다.";
            // 
            // formEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 280);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panelProfileMain);
            this.Controls.Add(this.menuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuTop;
            this.MaximizeBox = false;
            this.Name = "formEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "카트라이더 데모 에디터";
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.panelProfileMain.ResumeLayout(false);
            this.panelProfileMain.PerformLayout();
            this.panelProfileSub.ResumeLayout(false);
            this.panelProfileSub.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.ToolStripMenuItem menuProfileLoad;
        private System.Windows.Forms.ToolStripMenuItem menuProfileSave;
        private System.Windows.Forms.Panel panelProfileMain;
        private System.Windows.Forms.ComboBox comboProfle;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Panel panelProfileSub;
        private System.Windows.Forms.ComboBox comboChar;
        private System.Windows.Forms.Label labelChar;
        private System.Windows.Forms.TextBox textNick;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.ComboBox comboKartType;
        private System.Windows.Forms.Label labelKart;
        private System.Windows.Forms.ComboBox comboCharColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.CheckBox checkMission2;
        private System.Windows.Forms.CheckBox checkMission1;
        private System.Windows.Forms.Button buttonDeleteProfile;
        private System.Windows.Forms.Button buttonAddProfile;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
    }
}

