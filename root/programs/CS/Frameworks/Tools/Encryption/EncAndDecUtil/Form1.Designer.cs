﻿namespace EncAndDecUtil
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSPWDAuth2 = new System.Windows.Forms.TabControl();
            this.tabHash = new System.Windows.Forms.TabPage();
            this.nudHSStretching = new System.Windows.Forms.NumericUpDown();
            this.lblHS3 = new System.Windows.Forms.Label();
            this.lblHS4 = new System.Windows.Forms.Label();
            this.txtHSCode = new System.Windows.Forms.TextBox();
            this.lblHS2 = new System.Windows.Forms.Label();
            this.txtHSString = new System.Windows.Forms.TextBox();
            this.gbxHS = new System.Windows.Forms.GroupBox();
            this.rbnHSBytes = new System.Windows.Forms.RadioButton();
            this.rbnHSString = new System.Windows.Forms.RadioButton();
            this.cbxHSPV = new System.Windows.Forms.ComboBox();
            this.lblHS1 = new System.Windows.Forms.Label();
            this.btnGetHash = new System.Windows.Forms.Button();
            this.tabKeyedHash = new System.Windows.Forms.TabPage();
            this.gbxKHS = new System.Windows.Forms.GroupBox();
            this.rbnKHSBytes = new System.Windows.Forms.RadioButton();
            this.rbnKHSString = new System.Windows.Forms.RadioButton();
            this.lblKHS6 = new System.Windows.Forms.Label();
            this.cbxKHSPV = new System.Windows.Forms.ComboBox();
            this.btnGetKeyedHash = new System.Windows.Forms.Button();
            this.txtKHSCode = new System.Windows.Forms.TextBox();
            this.lblKHS3 = new System.Windows.Forms.Label();
            this.lblKHS2 = new System.Windows.Forms.Label();
            this.lblKHS1 = new System.Windows.Forms.Label();
            this.txtKHSPassword = new System.Windows.Forms.TextBox();
            this.txtKHSString = new System.Windows.Forms.TextBox();
            this.tabPwdDB1 = new System.Windows.Forms.TabPage();
            this.nudSPWDStretchCount1 = new System.Windows.Forms.NumericUpDown();
            this.lblSPWD14 = new System.Windows.Forms.Label();
            this.nudSPWDSaltLength1 = new System.Windows.Forms.NumericUpDown();
            this.lblSPWD13 = new System.Windows.Forms.Label();
            this.btnSPWDAuth1 = new System.Windows.Forms.Button();
            this.lblSPWD15 = new System.Windows.Forms.Label();
            this.txtSPWDSaltedPassword1 = new System.Windows.Forms.TextBox();
            this.lblSPWD12 = new System.Windows.Forms.Label();
            this.txtSPWDRawPassword1 = new System.Windows.Forms.TextBox();
            this.cbxSPWDPV1 = new System.Windows.Forms.ComboBox();
            this.lblSPWD11 = new System.Windows.Forms.Label();
            this.btnSPWDGen1 = new System.Windows.Forms.Button();
            this.tabPwdDB2 = new System.Windows.Forms.TabPage();
            this.nudSPWDStretchCount2 = new System.Windows.Forms.NumericUpDown();
            this.lblSPWD25 = new System.Windows.Forms.Label();
            this.lblSPWD23 = new System.Windows.Forms.Label();
            this.txtSPWDKey2 = new System.Windows.Forms.TextBox();
            this.nudSPWDSaltLength2 = new System.Windows.Forms.NumericUpDown();
            this.lblSPWD24 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSPWD26 = new System.Windows.Forms.Label();
            this.txtSPWDSaltedPassword2 = new System.Windows.Forms.TextBox();
            this.lblSPWD22 = new System.Windows.Forms.Label();
            this.txtSPWDRawPassword2 = new System.Windows.Forms.TextBox();
            this.cbxSPWDPV2 = new System.Windows.Forms.ComboBox();
            this.lblSPWD21 = new System.Windows.Forms.Label();
            this.btnSPWDGen2 = new System.Windows.Forms.Button();
            this.tabSC = new System.Windows.Forms.TabPage();
            this.gbxSC = new System.Windows.Forms.GroupBox();
            this.rbnSCBytes = new System.Windows.Forms.RadioButton();
            this.rbnSCString = new System.Windows.Forms.RadioButton();
            this.nudSCStretching = new System.Windows.Forms.NumericUpDown();
            this.lblSC6 = new System.Windows.Forms.Label();
            this.lblSC5 = new System.Windows.Forms.Label();
            this.cbxSCPV1 = new System.Windows.Forms.ComboBox();
            this.btnSCDecrypt = new System.Windows.Forms.Button();
            this.btnSCEncrypt = new System.Windows.Forms.Button();
            this.txtSCCode = new System.Windows.Forms.TextBox();
            this.lblSC4 = new System.Windows.Forms.Label();
            this.txtSCSalt = new System.Windows.Forms.TextBox();
            this.lblSC3 = new System.Windows.Forms.Label();
            this.lblSC2 = new System.Windows.Forms.Label();
            this.lblSC1 = new System.Windows.Forms.Label();
            this.txtSCPassword = new System.Windows.Forms.TextBox();
            this.txtSCString = new System.Windows.Forms.TextBox();
            this.tabASC = new System.Windows.Forms.TabPage();
            this.cbxASCPV = new System.Windows.Forms.ComboBox();
            this.btnASCGetKey = new System.Windows.Forms.Button();
            this.lblASC4 = new System.Windows.Forms.Label();
            this.txtASCCode = new System.Windows.Forms.TextBox();
            this.txtASCPublic = new System.Windows.Forms.TextBox();
            this.txtASCPrivate = new System.Windows.Forms.TextBox();
            this.lblASC3 = new System.Windows.Forms.Label();
            this.gbxASC = new System.Windows.Forms.GroupBox();
            this.rbnASCBytes = new System.Windows.Forms.RadioButton();
            this.rbnASCString = new System.Windows.Forms.RadioButton();
            this.lblASC5 = new System.Windows.Forms.Label();
            this.btnASCDecrypt = new System.Windows.Forms.Button();
            this.btnASCEncrypt = new System.Windows.Forms.Button();
            this.lblASC2 = new System.Windows.Forms.Label();
            this.lblASC1 = new System.Windows.Forms.Label();
            this.txtASCString = new System.Windows.Forms.TextBox();
            this.tabDS = new System.Windows.Forms.TabPage();
            this.btnDSVerify = new System.Windows.Forms.Button();
            this.lblDS6 = new System.Windows.Forms.Label();
            this.txtDSSign = new System.Windows.Forms.TextBox();
            this.lblDS5 = new System.Windows.Forms.Label();
            this.txtDSPublicKey = new System.Windows.Forms.TextBox();
            this.lblDS4 = new System.Windows.Forms.Label();
            this.txtDSPrivateKey = new System.Windows.Forms.TextBox();
            this.lblDS3 = new System.Windows.Forms.Label();
            this.lblDS2 = new System.Windows.Forms.Label();
            this.txtDSData = new System.Windows.Forms.TextBox();
            this.txtDSHash = new System.Windows.Forms.TextBox();
            this.cbxDSPV = new System.Windows.Forms.ComboBox();
            this.lblDS1 = new System.Windows.Forms.Label();
            this.gbxDS = new System.Windows.Forms.GroupBox();
            this.rbnDSParam = new System.Windows.Forms.RadioButton();
            this.rbnDSX509 = new System.Windows.Forms.RadioButton();
            this.rbnDSXML = new System.Windows.Forms.RadioButton();
            this.btnDSSign = new System.Windows.Forms.Button();
            this.tabMAC = new System.Windows.Forms.TabPage();
            this.btnVerifyMAC = new System.Windows.Forms.Button();
            this.lblMAC4 = new System.Windows.Forms.Label();
            this.cbxMACPV = new System.Windows.Forms.ComboBox();
            this.btnGetMAC = new System.Windows.Forms.Button();
            this.txtMACValue = new System.Windows.Forms.TextBox();
            this.lblMAC3 = new System.Windows.Forms.Label();
            this.lblMAC2 = new System.Windows.Forms.Label();
            this.lblMAC1 = new System.Windows.Forms.Label();
            this.txtMACPassword = new System.Windows.Forms.TextBox();
            this.txtMACString = new System.Windows.Forms.TextBox();
            this.tabAEAD = new System.Windows.Forms.TabPage();
            this.tabJWS = new System.Windows.Forms.TabPage();
            this.lblJWSJWK = new System.Windows.Forms.Label();
            this.lblJWSKey = new System.Windows.Forms.Label();
            this.lblJWSPayload = new System.Windows.Forms.Label();
            this.txtJWSJWK = new System.Windows.Forms.TextBox();
            this.txtJWSHeader = new System.Windows.Forms.TextBox();
            this.txtJWSKey = new System.Windows.Forms.TextBox();
            this.lblJWS3 = new System.Windows.Forms.Label();
            this.txtJWSSign = new System.Windows.Forms.TextBox();
            this.lblJWSHeader = new System.Windows.Forms.Label();
            this.txtJWSPayload = new System.Windows.Forms.TextBox();
            this.gbxJWS = new System.Windows.Forms.GroupBox();
            this.rbnJWSRS256_XML = new System.Windows.Forms.RadioButton();
            this.rbnJWSRS256_Param = new System.Windows.Forms.RadioButton();
            this.rbnJWSRS256_X509 = new System.Windows.Forms.RadioButton();
            this.rbnJWSHS256 = new System.Windows.Forms.RadioButton();
            this.btnJWSVerify = new System.Windows.Forms.Button();
            this.btnJWSSign = new System.Windows.Forms.Button();
            this.tabJWE = new System.Windows.Forms.TabPage();
            this.tabRKEX = new System.Windows.Forms.TabPage();
            this.tabEKEX = new System.Windows.Forms.TabPage();
            this.btnRKEXEC = new System.Windows.Forms.Button();
            this.btnRKEXSR = new System.Windows.Forms.Button();
            this.cbxRKEXPV = new System.Windows.Forms.ComboBox();
            this.txtRKEXAliceString = new System.Windows.Forms.TextBox();
            this.txtRKEXBobString = new System.Windows.Forms.TextBox();
            this.lblRKEX1 = new System.Windows.Forms.Label();
            this.lblRKEX2 = new System.Windows.Forms.Label();
            this.txtRKEXKeyInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSCPV2 = new System.Windows.Forms.ComboBox();
            this.cbxSCPV3 = new System.Windows.Forms.ComboBox();
            this.btnSPWDAuth2.SuspendLayout();
            this.tabHash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHSStretching)).BeginInit();
            this.gbxHS.SuspendLayout();
            this.tabKeyedHash.SuspendLayout();
            this.gbxKHS.SuspendLayout();
            this.tabPwdDB1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSPWDStretchCount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSPWDSaltLength1)).BeginInit();
            this.tabPwdDB2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSPWDStretchCount2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSPWDSaltLength2)).BeginInit();
            this.tabSC.SuspendLayout();
            this.gbxSC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSCStretching)).BeginInit();
            this.tabASC.SuspendLayout();
            this.gbxASC.SuspendLayout();
            this.tabDS.SuspendLayout();
            this.gbxDS.SuspendLayout();
            this.tabMAC.SuspendLayout();
            this.tabJWS.SuspendLayout();
            this.gbxJWS.SuspendLayout();
            this.tabRKEX.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSPWDAuth2
            // 
            this.btnSPWDAuth2.Controls.Add(this.tabHash);
            this.btnSPWDAuth2.Controls.Add(this.tabKeyedHash);
            this.btnSPWDAuth2.Controls.Add(this.tabPwdDB1);
            this.btnSPWDAuth2.Controls.Add(this.tabPwdDB2);
            this.btnSPWDAuth2.Controls.Add(this.tabSC);
            this.btnSPWDAuth2.Controls.Add(this.tabASC);
            this.btnSPWDAuth2.Controls.Add(this.tabDS);
            this.btnSPWDAuth2.Controls.Add(this.tabRKEX);
            this.btnSPWDAuth2.Controls.Add(this.tabEKEX);
            this.btnSPWDAuth2.Controls.Add(this.tabMAC);
            this.btnSPWDAuth2.Controls.Add(this.tabAEAD);
            this.btnSPWDAuth2.Controls.Add(this.tabJWS);
            this.btnSPWDAuth2.Controls.Add(this.tabJWE);
            this.btnSPWDAuth2.Location = new System.Drawing.Point(4, 4);
            this.btnSPWDAuth2.Multiline = true;
            this.btnSPWDAuth2.Name = "btnSPWDAuth2";
            this.btnSPWDAuth2.SelectedIndex = 0;
            this.btnSPWDAuth2.Size = new System.Drawing.Size(568, 348);
            this.btnSPWDAuth2.TabIndex = 10;
            // 
            // tabHash
            // 
            this.tabHash.Controls.Add(this.nudHSStretching);
            this.tabHash.Controls.Add(this.lblHS3);
            this.tabHash.Controls.Add(this.lblHS4);
            this.tabHash.Controls.Add(this.txtHSCode);
            this.tabHash.Controls.Add(this.lblHS2);
            this.tabHash.Controls.Add(this.txtHSString);
            this.tabHash.Controls.Add(this.gbxHS);
            this.tabHash.Controls.Add(this.cbxHSPV);
            this.tabHash.Controls.Add(this.lblHS1);
            this.tabHash.Controls.Add(this.btnGetHash);
            this.tabHash.Location = new System.Drawing.Point(4, 40);
            this.tabHash.Name = "tabHash";
            this.tabHash.Size = new System.Drawing.Size(560, 304);
            this.tabHash.TabIndex = 2;
            this.tabHash.Text = "ハッシュ";
            this.tabHash.UseVisualStyleBackColor = true;
            // 
            // nudHSStretching
            // 
            this.nudHSStretching.Location = new System.Drawing.Point(103, 110);
            this.nudHSStretching.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudHSStretching.Name = "nudHSStretching";
            this.nudHSStretching.Size = new System.Drawing.Size(212, 19);
            this.nudHSStretching.TabIndex = 42;
            // 
            // lblHS3
            // 
            this.lblHS3.AutoSize = true;
            this.lblHS3.Location = new System.Drawing.Point(9, 112);
            this.lblHS3.Name = "lblHS3";
            this.lblHS3.Size = new System.Drawing.Size(65, 12);
            this.lblHS3.TabIndex = 41;
            this.lblHS3.Text = "ストレッチング";
            // 
            // lblHS4
            // 
            this.lblHS4.AutoSize = true;
            this.lblHS4.Location = new System.Drawing.Point(7, 138);
            this.lblHS4.Name = "lblHS4";
            this.lblHS4.Size = new System.Drawing.Size(76, 12);
            this.lblHS4.TabIndex = 33;
            this.lblHS4.Text = "ハッシュ文字列";
            // 
            // txtHSCode
            // 
            this.txtHSCode.Location = new System.Drawing.Point(103, 135);
            this.txtHSCode.Name = "txtHSCode";
            this.txtHSCode.ReadOnly = true;
            this.txtHSCode.Size = new System.Drawing.Size(212, 19);
            this.txtHSCode.TabIndex = 32;
            // 
            // lblHS2
            // 
            this.lblHS2.AutoSize = true;
            this.lblHS2.Location = new System.Drawing.Point(9, 88);
            this.lblHS2.Name = "lblHS2";
            this.lblHS2.Size = new System.Drawing.Size(41, 12);
            this.lblHS2.TabIndex = 31;
            this.lblHS2.Text = "文字列";
            // 
            // txtHSString
            // 
            this.txtHSString.Location = new System.Drawing.Point(103, 85);
            this.txtHSString.Name = "txtHSString";
            this.txtHSString.Size = new System.Drawing.Size(212, 19);
            this.txtHSString.TabIndex = 30;
            // 
            // gbxHS
            // 
            this.gbxHS.Controls.Add(this.rbnHSBytes);
            this.gbxHS.Controls.Add(this.rbnHSString);
            this.gbxHS.Location = new System.Drawing.Point(9, 7);
            this.gbxHS.Name = "gbxHS";
            this.gbxHS.Size = new System.Drawing.Size(306, 46);
            this.gbxHS.TabIndex = 29;
            this.gbxHS.TabStop = false;
            this.gbxHS.Text = "API選択";
            // 
            // rbnHSBytes
            // 
            this.rbnHSBytes.AutoSize = true;
            this.rbnHSBytes.Location = new System.Drawing.Point(94, 18);
            this.rbnHSBytes.Name = "rbnHSBytes";
            this.rbnHSBytes.Size = new System.Drawing.Size(74, 16);
            this.rbnHSBytes.TabIndex = 1;
            this.rbnHSBytes.TabStop = true;
            this.rbnHSBytes.Text = "バイト配列";
            this.rbnHSBytes.UseVisualStyleBackColor = true;
            // 
            // rbnHSString
            // 
            this.rbnHSString.AutoSize = true;
            this.rbnHSString.Checked = true;
            this.rbnHSString.Location = new System.Drawing.Point(20, 18);
            this.rbnHSString.Name = "rbnHSString";
            this.rbnHSString.Size = new System.Drawing.Size(59, 16);
            this.rbnHSString.TabIndex = 0;
            this.rbnHSString.TabStop = true;
            this.rbnHSString.Text = "文字列";
            this.rbnHSString.UseVisualStyleBackColor = true;
            // 
            // cbxHSPV
            // 
            this.cbxHSPV.FormattingEnabled = true;
            this.cbxHSPV.Location = new System.Drawing.Point(103, 59);
            this.cbxHSPV.Name = "cbxHSPV";
            this.cbxHSPV.Size = new System.Drawing.Size(212, 20);
            this.cbxHSPV.TabIndex = 28;
            // 
            // lblHS1
            // 
            this.lblHS1.AutoSize = true;
            this.lblHS1.Location = new System.Drawing.Point(9, 63);
            this.lblHS1.Name = "lblHS1";
            this.lblHS1.Size = new System.Drawing.Size(75, 12);
            this.lblHS1.TabIndex = 27;
            this.lblHS1.Text = "暗号プロバイダ";
            // 
            // btnGetHash
            // 
            this.btnGetHash.Location = new System.Drawing.Point(103, 160);
            this.btnGetHash.Name = "btnGetHash";
            this.btnGetHash.Size = new System.Drawing.Size(213, 23);
            this.btnGetHash.TabIndex = 0;
            this.btnGetHash.Text = "ハッシュ";
            this.btnGetHash.UseVisualStyleBackColor = true;
            this.btnGetHash.Click += new System.EventHandler(this.btnGetHash_Click);
            // 
            // tabKeyedHash
            // 
            this.tabKeyedHash.Controls.Add(this.gbxKHS);
            this.tabKeyedHash.Controls.Add(this.lblKHS6);
            this.tabKeyedHash.Controls.Add(this.cbxKHSPV);
            this.tabKeyedHash.Controls.Add(this.btnGetKeyedHash);
            this.tabKeyedHash.Controls.Add(this.txtKHSCode);
            this.tabKeyedHash.Controls.Add(this.lblKHS3);
            this.tabKeyedHash.Controls.Add(this.lblKHS2);
            this.tabKeyedHash.Controls.Add(this.lblKHS1);
            this.tabKeyedHash.Controls.Add(this.txtKHSPassword);
            this.tabKeyedHash.Controls.Add(this.txtKHSString);
            this.tabKeyedHash.Location = new System.Drawing.Point(4, 40);
            this.tabKeyedHash.Name = "tabKeyedHash";
            this.tabKeyedHash.Size = new System.Drawing.Size(560, 304);
            this.tabKeyedHash.TabIndex = 3;
            this.tabKeyedHash.Text = "キー付きハッシュ";
            this.tabKeyedHash.UseVisualStyleBackColor = true;
            // 
            // gbxKHS
            // 
            this.gbxKHS.Controls.Add(this.rbnKHSBytes);
            this.gbxKHS.Controls.Add(this.rbnKHSString);
            this.gbxKHS.Location = new System.Drawing.Point(9, 7);
            this.gbxKHS.Name = "gbxKHS";
            this.gbxKHS.Size = new System.Drawing.Size(306, 46);
            this.gbxKHS.TabIndex = 41;
            this.gbxKHS.TabStop = false;
            this.gbxKHS.Text = "API選択";
            // 
            // rbnKHSBytes
            // 
            this.rbnKHSBytes.AutoSize = true;
            this.rbnKHSBytes.Location = new System.Drawing.Point(94, 18);
            this.rbnKHSBytes.Name = "rbnKHSBytes";
            this.rbnKHSBytes.Size = new System.Drawing.Size(74, 16);
            this.rbnKHSBytes.TabIndex = 1;
            this.rbnKHSBytes.TabStop = true;
            this.rbnKHSBytes.Text = "バイト配列";
            this.rbnKHSBytes.UseVisualStyleBackColor = true;
            // 
            // rbnKHSString
            // 
            this.rbnKHSString.AutoSize = true;
            this.rbnKHSString.Checked = true;
            this.rbnKHSString.Location = new System.Drawing.Point(20, 18);
            this.rbnKHSString.Name = "rbnKHSString";
            this.rbnKHSString.Size = new System.Drawing.Size(59, 16);
            this.rbnKHSString.TabIndex = 0;
            this.rbnKHSString.TabStop = true;
            this.rbnKHSString.Text = "文字列";
            this.rbnKHSString.UseVisualStyleBackColor = true;
            // 
            // lblKHS6
            // 
            this.lblKHS6.AutoSize = true;
            this.lblKHS6.Location = new System.Drawing.Point(9, 138);
            this.lblKHS6.Name = "lblKHS6";
            this.lblKHS6.Size = new System.Drawing.Size(76, 12);
            this.lblKHS6.TabIndex = 39;
            this.lblKHS6.Text = "ハッシュ文字列";
            // 
            // cbxKHSPV
            // 
            this.cbxKHSPV.FormattingEnabled = true;
            this.cbxKHSPV.Location = new System.Drawing.Point(103, 59);
            this.cbxKHSPV.Name = "cbxKHSPV";
            this.cbxKHSPV.Size = new System.Drawing.Size(212, 20);
            this.cbxKHSPV.TabIndex = 37;
            // 
            // btnGetKeyedHash
            // 
            this.btnGetKeyedHash.Location = new System.Drawing.Point(103, 160);
            this.btnGetKeyedHash.Name = "btnGetKeyedHash";
            this.btnGetKeyedHash.Size = new System.Drawing.Size(212, 23);
            this.btnGetKeyedHash.TabIndex = 35;
            this.btnGetKeyedHash.Text = "キー付きハッシュ";
            this.btnGetKeyedHash.UseVisualStyleBackColor = true;
            this.btnGetKeyedHash.Click += new System.EventHandler(this.btnGetKeyedHash_Click);
            // 
            // txtKHSCode
            // 
            this.txtKHSCode.Location = new System.Drawing.Point(103, 135);
            this.txtKHSCode.Name = "txtKHSCode";
            this.txtKHSCode.ReadOnly = true;
            this.txtKHSCode.Size = new System.Drawing.Size(212, 19);
            this.txtKHSCode.TabIndex = 34;
            // 
            // lblKHS3
            // 
            this.lblKHS3.AutoSize = true;
            this.lblKHS3.Location = new System.Drawing.Point(9, 113);
            this.lblKHS3.Name = "lblKHS3";
            this.lblKHS3.Size = new System.Drawing.Size(52, 12);
            this.lblKHS3.TabIndex = 31;
            this.lblKHS3.Text = "パスワード";
            // 
            // lblKHS2
            // 
            this.lblKHS2.AutoSize = true;
            this.lblKHS2.Location = new System.Drawing.Point(9, 88);
            this.lblKHS2.Name = "lblKHS2";
            this.lblKHS2.Size = new System.Drawing.Size(41, 12);
            this.lblKHS2.TabIndex = 30;
            this.lblKHS2.Text = "文字列";
            // 
            // lblKHS1
            // 
            this.lblKHS1.AutoSize = true;
            this.lblKHS1.Location = new System.Drawing.Point(9, 63);
            this.lblKHS1.Name = "lblKHS1";
            this.lblKHS1.Size = new System.Drawing.Size(75, 12);
            this.lblKHS1.TabIndex = 29;
            this.lblKHS1.Text = "暗号プロバイダ";
            // 
            // txtKHSPassword
            // 
            this.txtKHSPassword.Location = new System.Drawing.Point(103, 110);
            this.txtKHSPassword.Name = "txtKHSPassword";
            this.txtKHSPassword.Size = new System.Drawing.Size(212, 19);
            this.txtKHSPassword.TabIndex = 28;
            // 
            // txtKHSString
            // 
            this.txtKHSString.Location = new System.Drawing.Point(103, 85);
            this.txtKHSString.Name = "txtKHSString";
            this.txtKHSString.Size = new System.Drawing.Size(212, 19);
            this.txtKHSString.TabIndex = 27;
            // 
            // tabPwdDB1
            // 
            this.tabPwdDB1.Controls.Add(this.nudSPWDStretchCount1);
            this.tabPwdDB1.Controls.Add(this.lblSPWD14);
            this.tabPwdDB1.Controls.Add(this.nudSPWDSaltLength1);
            this.tabPwdDB1.Controls.Add(this.lblSPWD13);
            this.tabPwdDB1.Controls.Add(this.btnSPWDAuth1);
            this.tabPwdDB1.Controls.Add(this.lblSPWD15);
            this.tabPwdDB1.Controls.Add(this.txtSPWDSaltedPassword1);
            this.tabPwdDB1.Controls.Add(this.lblSPWD12);
            this.tabPwdDB1.Controls.Add(this.txtSPWDRawPassword1);
            this.tabPwdDB1.Controls.Add(this.cbxSPWDPV1);
            this.tabPwdDB1.Controls.Add(this.lblSPWD11);
            this.tabPwdDB1.Controls.Add(this.btnSPWDGen1);
            this.tabPwdDB1.Location = new System.Drawing.Point(4, 40);
            this.tabPwdDB1.Name = "tabPwdDB1";
            this.tabPwdDB1.Size = new System.Drawing.Size(560, 304);
            this.tabPwdDB1.TabIndex = 4;
            this.tabPwdDB1.Text = "パスワードDB保存 1";
            this.tabPwdDB1.UseVisualStyleBackColor = true;
            // 
            // nudSPWDStretchCount1
            // 
            this.nudSPWDStretchCount1.Location = new System.Drawing.Point(114, 85);
            this.nudSPWDStretchCount1.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudSPWDStretchCount1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSPWDStretchCount1.Name = "nudSPWDStretchCount1";
            this.nudSPWDStretchCount1.Size = new System.Drawing.Size(212, 19);
            this.nudSPWDStretchCount1.TabIndex = 45;
            this.nudSPWDStretchCount1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSPWD14
            // 
            this.lblSPWD14.AutoSize = true;
            this.lblSPWD14.Location = new System.Drawing.Point(9, 88);
            this.lblSPWD14.Name = "lblSPWD14";
            this.lblSPWD14.Size = new System.Drawing.Size(71, 12);
            this.lblSPWD14.TabIndex = 44;
            this.lblSPWD14.Text = "ストレッチ回数";
            // 
            // nudSPWDSaltLength1
            // 
            this.nudSPWDSaltLength1.Location = new System.Drawing.Point(114, 60);
            this.nudSPWDSaltLength1.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudSPWDSaltLength1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSPWDSaltLength1.Name = "nudSPWDSaltLength1";
            this.nudSPWDSaltLength1.Size = new System.Drawing.Size(212, 19);
            this.nudSPWDSaltLength1.TabIndex = 43;
            this.nudSPWDSaltLength1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSPWD13
            // 
            this.lblSPWD13.AutoSize = true;
            this.lblSPWD13.Location = new System.Drawing.Point(9, 62);
            this.lblSPWD13.Name = "lblSPWD13";
            this.lblSPWD13.Size = new System.Drawing.Size(62, 12);
            this.lblSPWD13.TabIndex = 42;
            this.lblSPWD13.Text = "ソルトの長さ";
            // 
            // btnSPWDAuth1
            // 
            this.btnSPWDAuth1.Location = new System.Drawing.Point(113, 190);
            this.btnSPWDAuth1.Name = "btnSPWDAuth1";
            this.btnSPWDAuth1.Size = new System.Drawing.Size(213, 23);
            this.btnSPWDAuth1.TabIndex = 41;
            this.btnSPWDAuth1.Text = "認証";
            this.btnSPWDAuth1.UseVisualStyleBackColor = true;
            this.btnSPWDAuth1.Click += new System.EventHandler(this.btnSPWDAuth1_Click);
            // 
            // lblSPWD15
            // 
            this.lblSPWD15.AutoSize = true;
            this.lblSPWD15.Location = new System.Drawing.Point(9, 113);
            this.lblSPWD15.Name = "lblSPWD15";
            this.lblSPWD15.Size = new System.Drawing.Size(76, 12);
            this.lblSPWD15.TabIndex = 40;
            this.lblSPWD15.Text = "塩味パスワード";
            // 
            // txtSPWDSaltedPassword1
            // 
            this.txtSPWDSaltedPassword1.Location = new System.Drawing.Point(113, 110);
            this.txtSPWDSaltedPassword1.Name = "txtSPWDSaltedPassword1";
            this.txtSPWDSaltedPassword1.ReadOnly = true;
            this.txtSPWDSaltedPassword1.Size = new System.Drawing.Size(212, 19);
            this.txtSPWDSaltedPassword1.TabIndex = 39;
            // 
            // lblSPWD12
            // 
            this.lblSPWD12.AutoSize = true;
            this.lblSPWD12.Location = new System.Drawing.Point(9, 38);
            this.lblSPWD12.Name = "lblSPWD12";
            this.lblSPWD12.Size = new System.Drawing.Size(64, 12);
            this.lblSPWD12.TabIndex = 38;
            this.lblSPWD12.Text = "生パスワード";
            // 
            // txtSPWDRawPassword1
            // 
            this.txtSPWDRawPassword1.Location = new System.Drawing.Point(113, 35);
            this.txtSPWDRawPassword1.Name = "txtSPWDRawPassword1";
            this.txtSPWDRawPassword1.Size = new System.Drawing.Size(212, 19);
            this.txtSPWDRawPassword1.TabIndex = 37;
            // 
            // cbxSPWDPV1
            // 
            this.cbxSPWDPV1.FormattingEnabled = true;
            this.cbxSPWDPV1.Location = new System.Drawing.Point(113, 9);
            this.cbxSPWDPV1.Name = "cbxSPWDPV1";
            this.cbxSPWDPV1.Size = new System.Drawing.Size(212, 20);
            this.cbxSPWDPV1.TabIndex = 36;
            // 
            // lblSPWD11
            // 
            this.lblSPWD11.AutoSize = true;
            this.lblSPWD11.Location = new System.Drawing.Point(9, 13);
            this.lblSPWD11.Name = "lblSPWD11";
            this.lblSPWD11.Size = new System.Drawing.Size(75, 12);
            this.lblSPWD11.TabIndex = 35;
            this.lblSPWD11.Text = "暗号プロバイダ";
            // 
            // btnSPWDGen1
            // 
            this.btnSPWDGen1.Location = new System.Drawing.Point(113, 161);
            this.btnSPWDGen1.Name = "btnSPWDGen1";
            this.btnSPWDGen1.Size = new System.Drawing.Size(213, 23);
            this.btnSPWDGen1.TabIndex = 34;
            this.btnSPWDGen1.Text = "塩味パスワードの生成";
            this.btnSPWDGen1.UseVisualStyleBackColor = true;
            this.btnSPWDGen1.Click += new System.EventHandler(this.btnSPWDGen1_Click);
            // 
            // tabPwdDB2
            // 
            this.tabPwdDB2.Controls.Add(this.nudSPWDStretchCount2);
            this.tabPwdDB2.Controls.Add(this.lblSPWD25);
            this.tabPwdDB2.Controls.Add(this.lblSPWD23);
            this.tabPwdDB2.Controls.Add(this.txtSPWDKey2);
            this.tabPwdDB2.Controls.Add(this.nudSPWDSaltLength2);
            this.tabPwdDB2.Controls.Add(this.lblSPWD24);
            this.tabPwdDB2.Controls.Add(this.button1);
            this.tabPwdDB2.Controls.Add(this.lblSPWD26);
            this.tabPwdDB2.Controls.Add(this.txtSPWDSaltedPassword2);
            this.tabPwdDB2.Controls.Add(this.lblSPWD22);
            this.tabPwdDB2.Controls.Add(this.txtSPWDRawPassword2);
            this.tabPwdDB2.Controls.Add(this.cbxSPWDPV2);
            this.tabPwdDB2.Controls.Add(this.lblSPWD21);
            this.tabPwdDB2.Controls.Add(this.btnSPWDGen2);
            this.tabPwdDB2.Location = new System.Drawing.Point(4, 40);
            this.tabPwdDB2.Name = "tabPwdDB2";
            this.tabPwdDB2.Size = new System.Drawing.Size(560, 304);
            this.tabPwdDB2.TabIndex = 5;
            this.tabPwdDB2.Text = "パスワードDB保存 2";
            this.tabPwdDB2.UseVisualStyleBackColor = true;
            // 
            // nudSPWDStretchCount2
            // 
            this.nudSPWDStretchCount2.Location = new System.Drawing.Point(114, 110);
            this.nudSPWDStretchCount2.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudSPWDStretchCount2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSPWDStretchCount2.Name = "nudSPWDStretchCount2";
            this.nudSPWDStretchCount2.Size = new System.Drawing.Size(212, 19);
            this.nudSPWDStretchCount2.TabIndex = 57;
            this.nudSPWDStretchCount2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSPWD25
            // 
            this.lblSPWD25.AutoSize = true;
            this.lblSPWD25.Location = new System.Drawing.Point(9, 112);
            this.lblSPWD25.Name = "lblSPWD25";
            this.lblSPWD25.Size = new System.Drawing.Size(71, 12);
            this.lblSPWD25.TabIndex = 56;
            this.lblSPWD25.Text = "ストレッチ回数";
            // 
            // lblSPWD23
            // 
            this.lblSPWD23.AutoSize = true;
            this.lblSPWD23.Location = new System.Drawing.Point(10, 63);
            this.lblSPWD23.Name = "lblSPWD23";
            this.lblSPWD23.Size = new System.Drawing.Size(25, 12);
            this.lblSPWD23.TabIndex = 55;
            this.lblSPWD23.Text = "キー";
            // 
            // txtSPWDKey2
            // 
            this.txtSPWDKey2.Location = new System.Drawing.Point(114, 60);
            this.txtSPWDKey2.Name = "txtSPWDKey2";
            this.txtSPWDKey2.Size = new System.Drawing.Size(212, 19);
            this.txtSPWDKey2.TabIndex = 54;
            // 
            // nudSPWDSaltLength2
            // 
            this.nudSPWDSaltLength2.Location = new System.Drawing.Point(114, 85);
            this.nudSPWDSaltLength2.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudSPWDSaltLength2.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudSPWDSaltLength2.Name = "nudSPWDSaltLength2";
            this.nudSPWDSaltLength2.Size = new System.Drawing.Size(212, 19);
            this.nudSPWDSaltLength2.TabIndex = 53;
            this.nudSPWDSaltLength2.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblSPWD24
            // 
            this.lblSPWD24.AutoSize = true;
            this.lblSPWD24.Location = new System.Drawing.Point(9, 87);
            this.lblSPWD24.Name = "lblSPWD24";
            this.lblSPWD24.Size = new System.Drawing.Size(62, 12);
            this.lblSPWD24.TabIndex = 52;
            this.lblSPWD24.Text = "ソルトの長さ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "認証";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSPWDAuth2_Click);
            // 
            // lblSPWD26
            // 
            this.lblSPWD26.AutoSize = true;
            this.lblSPWD26.Location = new System.Drawing.Point(9, 139);
            this.lblSPWD26.Name = "lblSPWD26";
            this.lblSPWD26.Size = new System.Drawing.Size(76, 12);
            this.lblSPWD26.TabIndex = 50;
            this.lblSPWD26.Text = "塩味パスワード";
            // 
            // txtSPWDSaltedPassword2
            // 
            this.txtSPWDSaltedPassword2.Location = new System.Drawing.Point(113, 136);
            this.txtSPWDSaltedPassword2.Name = "txtSPWDSaltedPassword2";
            this.txtSPWDSaltedPassword2.ReadOnly = true;
            this.txtSPWDSaltedPassword2.Size = new System.Drawing.Size(212, 19);
            this.txtSPWDSaltedPassword2.TabIndex = 49;
            // 
            // lblSPWD22
            // 
            this.lblSPWD22.AutoSize = true;
            this.lblSPWD22.Location = new System.Drawing.Point(9, 38);
            this.lblSPWD22.Name = "lblSPWD22";
            this.lblSPWD22.Size = new System.Drawing.Size(64, 12);
            this.lblSPWD22.TabIndex = 48;
            this.lblSPWD22.Text = "生パスワード";
            // 
            // txtSPWDRawPassword2
            // 
            this.txtSPWDRawPassword2.Location = new System.Drawing.Point(113, 35);
            this.txtSPWDRawPassword2.Name = "txtSPWDRawPassword2";
            this.txtSPWDRawPassword2.Size = new System.Drawing.Size(212, 19);
            this.txtSPWDRawPassword2.TabIndex = 47;
            // 
            // cbxSPWDPV2
            // 
            this.cbxSPWDPV2.FormattingEnabled = true;
            this.cbxSPWDPV2.Location = new System.Drawing.Point(113, 9);
            this.cbxSPWDPV2.Name = "cbxSPWDPV2";
            this.cbxSPWDPV2.Size = new System.Drawing.Size(212, 20);
            this.cbxSPWDPV2.TabIndex = 46;
            // 
            // lblSPWD21
            // 
            this.lblSPWD21.AutoSize = true;
            this.lblSPWD21.Location = new System.Drawing.Point(9, 13);
            this.lblSPWD21.Name = "lblSPWD21";
            this.lblSPWD21.Size = new System.Drawing.Size(75, 12);
            this.lblSPWD21.TabIndex = 45;
            this.lblSPWD21.Text = "暗号プロバイダ";
            // 
            // btnSPWDGen2
            // 
            this.btnSPWDGen2.Location = new System.Drawing.Point(113, 161);
            this.btnSPWDGen2.Name = "btnSPWDGen2";
            this.btnSPWDGen2.Size = new System.Drawing.Size(213, 23);
            this.btnSPWDGen2.TabIndex = 44;
            this.btnSPWDGen2.Text = "塩味パスワードの生成";
            this.btnSPWDGen2.UseVisualStyleBackColor = true;
            this.btnSPWDGen2.Click += new System.EventHandler(this.btnSPWDGen2_Click);
            // 
            // tabSC
            // 
            this.tabSC.Controls.Add(this.cbxSCPV3);
            this.tabSC.Controls.Add(this.cbxSCPV2);
            this.tabSC.Controls.Add(this.gbxSC);
            this.tabSC.Controls.Add(this.nudSCStretching);
            this.tabSC.Controls.Add(this.lblSC6);
            this.tabSC.Controls.Add(this.lblSC5);
            this.tabSC.Controls.Add(this.cbxSCPV1);
            this.tabSC.Controls.Add(this.btnSCDecrypt);
            this.tabSC.Controls.Add(this.btnSCEncrypt);
            this.tabSC.Controls.Add(this.txtSCCode);
            this.tabSC.Controls.Add(this.lblSC4);
            this.tabSC.Controls.Add(this.txtSCSalt);
            this.tabSC.Controls.Add(this.lblSC3);
            this.tabSC.Controls.Add(this.lblSC2);
            this.tabSC.Controls.Add(this.lblSC1);
            this.tabSC.Controls.Add(this.txtSCPassword);
            this.tabSC.Controls.Add(this.txtSCString);
            this.tabSC.Location = new System.Drawing.Point(4, 40);
            this.tabSC.Name = "tabSC";
            this.tabSC.Padding = new System.Windows.Forms.Padding(3);
            this.tabSC.Size = new System.Drawing.Size(560, 304);
            this.tabSC.TabIndex = 0;
            this.tabSC.Text = "秘密鍵・暗号化";
            this.tabSC.UseVisualStyleBackColor = true;
            // 
            // gbxSC
            // 
            this.gbxSC.Controls.Add(this.rbnSCBytes);
            this.gbxSC.Controls.Add(this.rbnSCString);
            this.gbxSC.Location = new System.Drawing.Point(9, 7);
            this.gbxSC.Name = "gbxSC";
            this.gbxSC.Size = new System.Drawing.Size(452, 46);
            this.gbxSC.TabIndex = 26;
            this.gbxSC.TabStop = false;
            this.gbxSC.Text = "API選択";
            // 
            // rbnSCBytes
            // 
            this.rbnSCBytes.AutoSize = true;
            this.rbnSCBytes.Location = new System.Drawing.Point(94, 18);
            this.rbnSCBytes.Name = "rbnSCBytes";
            this.rbnSCBytes.Size = new System.Drawing.Size(74, 16);
            this.rbnSCBytes.TabIndex = 1;
            this.rbnSCBytes.TabStop = true;
            this.rbnSCBytes.Text = "バイト配列";
            this.rbnSCBytes.UseVisualStyleBackColor = true;
            // 
            // rbnSCString
            // 
            this.rbnSCString.AutoSize = true;
            this.rbnSCString.Checked = true;
            this.rbnSCString.Location = new System.Drawing.Point(20, 18);
            this.rbnSCString.Name = "rbnSCString";
            this.rbnSCString.Size = new System.Drawing.Size(59, 16);
            this.rbnSCString.TabIndex = 0;
            this.rbnSCString.TabStop = true;
            this.rbnSCString.Text = "文字列";
            this.rbnSCString.UseVisualStyleBackColor = true;
            // 
            // nudSCStretching
            // 
            this.nudSCStretching.Location = new System.Drawing.Point(103, 160);
            this.nudSCStretching.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudSCStretching.Name = "nudSCStretching";
            this.nudSCStretching.Size = new System.Drawing.Size(358, 19);
            this.nudSCStretching.TabIndex = 24;
            // 
            // lblSC6
            // 
            this.lblSC6.AutoSize = true;
            this.lblSC6.Location = new System.Drawing.Point(9, 188);
            this.lblSC6.Name = "lblSC6";
            this.lblSC6.Size = new System.Drawing.Size(65, 12);
            this.lblSC6.TabIndex = 23;
            this.lblSC6.Text = "暗号文字列";
            // 
            // lblSC5
            // 
            this.lblSC5.AutoSize = true;
            this.lblSC5.Location = new System.Drawing.Point(9, 162);
            this.lblSC5.Name = "lblSC5";
            this.lblSC5.Size = new System.Drawing.Size(65, 12);
            this.lblSC5.TabIndex = 21;
            this.lblSC5.Text = "ストレッチング";
            // 
            // cbxSCPV1
            // 
            this.cbxSCPV1.FormattingEnabled = true;
            this.cbxSCPV1.Location = new System.Drawing.Point(103, 59);
            this.cbxSCPV1.Name = "cbxSCPV1";
            this.cbxSCPV1.Size = new System.Drawing.Size(156, 20);
            this.cbxSCPV1.TabIndex = 20;
            // 
            // btnSCDecrypt
            // 
            this.btnSCDecrypt.Location = new System.Drawing.Point(294, 210);
            this.btnSCDecrypt.Name = "btnSCDecrypt";
            this.btnSCDecrypt.Size = new System.Drawing.Size(167, 23);
            this.btnSCDecrypt.TabIndex = 19;
            this.btnSCDecrypt.Text = "復号化";
            this.btnSCDecrypt.UseVisualStyleBackColor = true;
            this.btnSCDecrypt.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSCEncrypt
            // 
            this.btnSCEncrypt.Location = new System.Drawing.Point(103, 210);
            this.btnSCEncrypt.Name = "btnSCEncrypt";
            this.btnSCEncrypt.Size = new System.Drawing.Size(167, 23);
            this.btnSCEncrypt.TabIndex = 18;
            this.btnSCEncrypt.Text = "暗号化";
            this.btnSCEncrypt.UseVisualStyleBackColor = true;
            this.btnSCEncrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSCCode
            // 
            this.txtSCCode.Location = new System.Drawing.Point(103, 185);
            this.txtSCCode.Name = "txtSCCode";
            this.txtSCCode.ReadOnly = true;
            this.txtSCCode.Size = new System.Drawing.Size(358, 19);
            this.txtSCCode.TabIndex = 17;
            // 
            // lblSC4
            // 
            this.lblSC4.AutoSize = true;
            this.lblSC4.Location = new System.Drawing.Point(11, 138);
            this.lblSC4.Name = "lblSC4";
            this.lblSC4.Size = new System.Drawing.Size(32, 12);
            this.lblSC4.TabIndex = 16;
            this.lblSC4.Text = "ソルト";
            // 
            // txtSCSalt
            // 
            this.txtSCSalt.Location = new System.Drawing.Point(103, 135);
            this.txtSCSalt.Name = "txtSCSalt";
            this.txtSCSalt.Size = new System.Drawing.Size(358, 19);
            this.txtSCSalt.TabIndex = 15;
            // 
            // lblSC3
            // 
            this.lblSC3.AutoSize = true;
            this.lblSC3.Location = new System.Drawing.Point(9, 113);
            this.lblSC3.Name = "lblSC3";
            this.lblSC3.Size = new System.Drawing.Size(52, 12);
            this.lblSC3.TabIndex = 14;
            this.lblSC3.Text = "パスワード";
            // 
            // lblSC2
            // 
            this.lblSC2.AutoSize = true;
            this.lblSC2.Location = new System.Drawing.Point(9, 88);
            this.lblSC2.Name = "lblSC2";
            this.lblSC2.Size = new System.Drawing.Size(41, 12);
            this.lblSC2.TabIndex = 13;
            this.lblSC2.Text = "文字列";
            // 
            // lblSC1
            // 
            this.lblSC1.AutoSize = true;
            this.lblSC1.Location = new System.Drawing.Point(9, 63);
            this.lblSC1.Name = "lblSC1";
            this.lblSC1.Size = new System.Drawing.Size(75, 12);
            this.lblSC1.TabIndex = 12;
            this.lblSC1.Text = "暗号プロバイダ";
            // 
            // txtSCPassword
            // 
            this.txtSCPassword.Location = new System.Drawing.Point(103, 110);
            this.txtSCPassword.Name = "txtSCPassword";
            this.txtSCPassword.Size = new System.Drawing.Size(358, 19);
            this.txtSCPassword.TabIndex = 11;
            // 
            // txtSCString
            // 
            this.txtSCString.Location = new System.Drawing.Point(103, 85);
            this.txtSCString.Name = "txtSCString";
            this.txtSCString.Size = new System.Drawing.Size(358, 19);
            this.txtSCString.TabIndex = 10;
            // 
            // tabASC
            // 
            this.tabASC.Controls.Add(this.cbxASCPV);
            this.tabASC.Controls.Add(this.btnASCGetKey);
            this.tabASC.Controls.Add(this.lblASC4);
            this.tabASC.Controls.Add(this.txtASCCode);
            this.tabASC.Controls.Add(this.txtASCPublic);
            this.tabASC.Controls.Add(this.txtASCPrivate);
            this.tabASC.Controls.Add(this.lblASC3);
            this.tabASC.Controls.Add(this.gbxASC);
            this.tabASC.Controls.Add(this.lblASC5);
            this.tabASC.Controls.Add(this.btnASCDecrypt);
            this.tabASC.Controls.Add(this.btnASCEncrypt);
            this.tabASC.Controls.Add(this.lblASC2);
            this.tabASC.Controls.Add(this.lblASC1);
            this.tabASC.Controls.Add(this.txtASCString);
            this.tabASC.Location = new System.Drawing.Point(4, 40);
            this.tabASC.Name = "tabASC";
            this.tabASC.Padding = new System.Windows.Forms.Padding(3);
            this.tabASC.Size = new System.Drawing.Size(560, 304);
            this.tabASC.TabIndex = 1;
            this.tabASC.Text = "共通鍵・暗号化";
            this.tabASC.UseVisualStyleBackColor = true;
            // 
            // cbxASCPV
            // 
            this.cbxASCPV.FormattingEnabled = true;
            this.cbxASCPV.Location = new System.Drawing.Point(103, 60);
            this.cbxASCPV.Name = "cbxASCPV";
            this.cbxASCPV.Size = new System.Drawing.Size(212, 20);
            this.cbxASCPV.TabIndex = 40;
            // 
            // btnASCGetKey
            // 
            this.btnASCGetKey.Location = new System.Drawing.Point(103, 185);
            this.btnASCGetKey.Name = "btnASCGetKey";
            this.btnASCGetKey.Size = new System.Drawing.Size(212, 23);
            this.btnASCGetKey.TabIndex = 39;
            this.btnASCGetKey.Text = "鍵取得";
            this.btnASCGetKey.UseVisualStyleBackColor = true;
            this.btnASCGetKey.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblASC4
            // 
            this.lblASC4.AutoSize = true;
            this.lblASC4.Location = new System.Drawing.Point(9, 138);
            this.lblASC4.Name = "lblASC4";
            this.lblASC4.Size = new System.Drawing.Size(41, 12);
            this.lblASC4.TabIndex = 38;
            this.lblASC4.Text = "公開鍵";
            // 
            // txtASCCode
            // 
            this.txtASCCode.Location = new System.Drawing.Point(103, 160);
            this.txtASCCode.Name = "txtASCCode";
            this.txtASCCode.ReadOnly = true;
            this.txtASCCode.Size = new System.Drawing.Size(212, 19);
            this.txtASCCode.TabIndex = 37;
            // 
            // txtASCPublic
            // 
            this.txtASCPublic.Location = new System.Drawing.Point(103, 135);
            this.txtASCPublic.Name = "txtASCPublic";
            this.txtASCPublic.ReadOnly = true;
            this.txtASCPublic.Size = new System.Drawing.Size(212, 19);
            this.txtASCPublic.TabIndex = 36;
            // 
            // txtASCPrivate
            // 
            this.txtASCPrivate.Location = new System.Drawing.Point(103, 110);
            this.txtASCPrivate.Name = "txtASCPrivate";
            this.txtASCPrivate.ReadOnly = true;
            this.txtASCPrivate.Size = new System.Drawing.Size(212, 19);
            this.txtASCPrivate.TabIndex = 35;
            // 
            // lblASC3
            // 
            this.lblASC3.AutoSize = true;
            this.lblASC3.Location = new System.Drawing.Point(9, 113);
            this.lblASC3.Name = "lblASC3";
            this.lblASC3.Size = new System.Drawing.Size(41, 12);
            this.lblASC3.TabIndex = 34;
            this.lblASC3.Text = "秘密鍵";
            // 
            // gbxASC
            // 
            this.gbxASC.Controls.Add(this.rbnASCBytes);
            this.gbxASC.Controls.Add(this.rbnASCString);
            this.gbxASC.Location = new System.Drawing.Point(9, 7);
            this.gbxASC.Name = "gbxASC";
            this.gbxASC.Size = new System.Drawing.Size(306, 46);
            this.gbxASC.TabIndex = 33;
            this.gbxASC.TabStop = false;
            this.gbxASC.Text = "API選択";
            // 
            // rbnASCBytes
            // 
            this.rbnASCBytes.AutoSize = true;
            this.rbnASCBytes.Location = new System.Drawing.Point(94, 18);
            this.rbnASCBytes.Name = "rbnASCBytes";
            this.rbnASCBytes.Size = new System.Drawing.Size(74, 16);
            this.rbnASCBytes.TabIndex = 1;
            this.rbnASCBytes.TabStop = true;
            this.rbnASCBytes.Text = "バイト配列";
            this.rbnASCBytes.UseVisualStyleBackColor = true;
            // 
            // rbnASCString
            // 
            this.rbnASCString.AutoSize = true;
            this.rbnASCString.Checked = true;
            this.rbnASCString.Location = new System.Drawing.Point(20, 18);
            this.rbnASCString.Name = "rbnASCString";
            this.rbnASCString.Size = new System.Drawing.Size(59, 16);
            this.rbnASCString.TabIndex = 0;
            this.rbnASCString.TabStop = true;
            this.rbnASCString.Text = "文字列";
            this.rbnASCString.UseVisualStyleBackColor = true;
            // 
            // lblASC5
            // 
            this.lblASC5.AutoSize = true;
            this.lblASC5.Location = new System.Drawing.Point(9, 163);
            this.lblASC5.Name = "lblASC5";
            this.lblASC5.Size = new System.Drawing.Size(65, 12);
            this.lblASC5.TabIndex = 32;
            this.lblASC5.Text = "暗号文字列";
            // 
            // btnASCDecrypt
            // 
            this.btnASCDecrypt.Location = new System.Drawing.Point(217, 214);
            this.btnASCDecrypt.Name = "btnASCDecrypt";
            this.btnASCDecrypt.Size = new System.Drawing.Size(98, 23);
            this.btnASCDecrypt.TabIndex = 31;
            this.btnASCDecrypt.Text = "復号化";
            this.btnASCDecrypt.UseVisualStyleBackColor = true;
            this.btnASCDecrypt.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnASCEncrypt
            // 
            this.btnASCEncrypt.Location = new System.Drawing.Point(103, 214);
            this.btnASCEncrypt.Name = "btnASCEncrypt";
            this.btnASCEncrypt.Size = new System.Drawing.Size(98, 23);
            this.btnASCEncrypt.TabIndex = 30;
            this.btnASCEncrypt.Text = "暗号化";
            this.btnASCEncrypt.UseVisualStyleBackColor = true;
            this.btnASCEncrypt.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblASC2
            // 
            this.lblASC2.AutoSize = true;
            this.lblASC2.Location = new System.Drawing.Point(9, 88);
            this.lblASC2.Name = "lblASC2";
            this.lblASC2.Size = new System.Drawing.Size(41, 12);
            this.lblASC2.TabIndex = 29;
            this.lblASC2.Text = "文字列";
            // 
            // lblASC1
            // 
            this.lblASC1.AutoSize = true;
            this.lblASC1.Location = new System.Drawing.Point(9, 63);
            this.lblASC1.Name = "lblASC1";
            this.lblASC1.Size = new System.Drawing.Size(75, 12);
            this.lblASC1.TabIndex = 28;
            this.lblASC1.Text = "暗号プロバイダ";
            // 
            // txtASCString
            // 
            this.txtASCString.Location = new System.Drawing.Point(103, 85);
            this.txtASCString.Name = "txtASCString";
            this.txtASCString.Size = new System.Drawing.Size(212, 19);
            this.txtASCString.TabIndex = 27;
            // 
            // tabDS
            // 
            this.tabDS.Controls.Add(this.btnDSVerify);
            this.tabDS.Controls.Add(this.lblDS6);
            this.tabDS.Controls.Add(this.txtDSSign);
            this.tabDS.Controls.Add(this.lblDS5);
            this.tabDS.Controls.Add(this.txtDSPublicKey);
            this.tabDS.Controls.Add(this.lblDS4);
            this.tabDS.Controls.Add(this.txtDSPrivateKey);
            this.tabDS.Controls.Add(this.lblDS3);
            this.tabDS.Controls.Add(this.lblDS2);
            this.tabDS.Controls.Add(this.txtDSData);
            this.tabDS.Controls.Add(this.txtDSHash);
            this.tabDS.Controls.Add(this.cbxDSPV);
            this.tabDS.Controls.Add(this.lblDS1);
            this.tabDS.Controls.Add(this.gbxDS);
            this.tabDS.Controls.Add(this.btnDSSign);
            this.tabDS.Location = new System.Drawing.Point(4, 40);
            this.tabDS.Name = "tabDS";
            this.tabDS.Size = new System.Drawing.Size(560, 304);
            this.tabDS.TabIndex = 7;
            this.tabDS.Text = "署名";
            this.tabDS.UseVisualStyleBackColor = true;
            // 
            // btnDSVerify
            // 
            this.btnDSVerify.Location = new System.Drawing.Point(195, 210);
            this.btnDSVerify.Name = "btnDSVerify";
            this.btnDSVerify.Size = new System.Drawing.Size(174, 23);
            this.btnDSVerify.TabIndex = 43;
            this.btnDSVerify.Text = "検証";
            this.btnDSVerify.UseVisualStyleBackColor = true;
            this.btnDSVerify.Click += new System.EventHandler(this.btnDSVerify_Click);
            // 
            // lblDS6
            // 
            this.lblDS6.AutoSize = true;
            this.lblDS6.Location = new System.Drawing.Point(9, 188);
            this.lblDS6.Name = "lblDS6";
            this.lblDS6.Size = new System.Drawing.Size(29, 12);
            this.lblDS6.TabIndex = 42;
            this.lblDS6.Text = "署名";
            // 
            // txtDSSign
            // 
            this.txtDSSign.Location = new System.Drawing.Point(157, 185);
            this.txtDSSign.Name = "txtDSSign";
            this.txtDSSign.ReadOnly = true;
            this.txtDSSign.Size = new System.Drawing.Size(212, 19);
            this.txtDSSign.TabIndex = 41;
            // 
            // lblDS5
            // 
            this.lblDS5.AutoSize = true;
            this.lblDS5.Location = new System.Drawing.Point(9, 163);
            this.lblDS5.Name = "lblDS5";
            this.lblDS5.Size = new System.Drawing.Size(41, 12);
            this.lblDS5.TabIndex = 40;
            this.lblDS5.Text = "公開鍵";
            // 
            // txtDSPublicKey
            // 
            this.txtDSPublicKey.Location = new System.Drawing.Point(157, 160);
            this.txtDSPublicKey.Name = "txtDSPublicKey";
            this.txtDSPublicKey.Size = new System.Drawing.Size(212, 19);
            this.txtDSPublicKey.TabIndex = 39;
            // 
            // lblDS4
            // 
            this.lblDS4.AutoSize = true;
            this.lblDS4.Location = new System.Drawing.Point(9, 138);
            this.lblDS4.Name = "lblDS4";
            this.lblDS4.Size = new System.Drawing.Size(41, 12);
            this.lblDS4.TabIndex = 38;
            this.lblDS4.Text = "秘密鍵";
            // 
            // txtDSPrivateKey
            // 
            this.txtDSPrivateKey.Location = new System.Drawing.Point(157, 135);
            this.txtDSPrivateKey.Name = "txtDSPrivateKey";
            this.txtDSPrivateKey.ReadOnly = true;
            this.txtDSPrivateKey.Size = new System.Drawing.Size(212, 19);
            this.txtDSPrivateKey.TabIndex = 37;
            // 
            // lblDS3
            // 
            this.lblDS3.AutoSize = true;
            this.lblDS3.Location = new System.Drawing.Point(9, 113);
            this.lblDS3.Name = "lblDS3";
            this.lblDS3.Size = new System.Drawing.Size(33, 12);
            this.lblDS3.TabIndex = 36;
            this.lblDS3.Text = "データ";
            // 
            // lblDS2
            // 
            this.lblDS2.AutoSize = true;
            this.lblDS2.Location = new System.Drawing.Point(9, 88);
            this.lblDS2.Name = "lblDS2";
            this.lblDS2.Size = new System.Drawing.Size(77, 12);
            this.lblDS2.TabIndex = 35;
            this.lblDS2.Text = "ハッシュ (X509)";
            // 
            // txtDSData
            // 
            this.txtDSData.Location = new System.Drawing.Point(157, 110);
            this.txtDSData.Name = "txtDSData";
            this.txtDSData.Size = new System.Drawing.Size(212, 19);
            this.txtDSData.TabIndex = 34;
            // 
            // txtDSHash
            // 
            this.txtDSHash.Location = new System.Drawing.Point(157, 85);
            this.txtDSHash.Name = "txtDSHash";
            this.txtDSHash.ReadOnly = true;
            this.txtDSHash.Size = new System.Drawing.Size(212, 19);
            this.txtDSHash.TabIndex = 33;
            this.txtDSHash.Text = "SHA1";
            // 
            // cbxDSPV
            // 
            this.cbxDSPV.FormattingEnabled = true;
            this.cbxDSPV.Location = new System.Drawing.Point(157, 59);
            this.cbxDSPV.Name = "cbxDSPV";
            this.cbxDSPV.Size = new System.Drawing.Size(212, 20);
            this.cbxDSPV.TabIndex = 32;
            // 
            // lblDS1
            // 
            this.lblDS1.AutoSize = true;
            this.lblDS1.Location = new System.Drawing.Point(9, 63);
            this.lblDS1.Name = "lblDS1";
            this.lblDS1.Size = new System.Drawing.Size(135, 12);
            this.lblDS1.TabIndex = 31;
            this.lblDS1.Text = "プロバイダ (XML or Param)";
            // 
            // gbxDS
            // 
            this.gbxDS.Controls.Add(this.rbnDSParam);
            this.gbxDS.Controls.Add(this.rbnDSX509);
            this.gbxDS.Controls.Add(this.rbnDSXML);
            this.gbxDS.Location = new System.Drawing.Point(9, 7);
            this.gbxDS.Name = "gbxDS";
            this.gbxDS.Size = new System.Drawing.Size(360, 46);
            this.gbxDS.TabIndex = 30;
            this.gbxDS.TabStop = false;
            this.gbxDS.Text = "API選択";
            // 
            // rbnDSParam
            // 
            this.rbnDSParam.AutoSize = true;
            this.rbnDSParam.Location = new System.Drawing.Point(90, 18);
            this.rbnDSParam.Name = "rbnDSParam";
            this.rbnDSParam.Size = new System.Drawing.Size(55, 16);
            this.rbnDSParam.TabIndex = 2;
            this.rbnDSParam.TabStop = true;
            this.rbnDSParam.Text = "Param";
            this.rbnDSParam.UseVisualStyleBackColor = true;
            this.rbnDSParam.CheckedChanged += new System.EventHandler(this.rbnDS_CheckedChanged);
            // 
            // rbnDSX509
            // 
            this.rbnDSX509.AutoSize = true;
            this.rbnDSX509.Location = new System.Drawing.Point(165, 18);
            this.rbnDSX509.Name = "rbnDSX509";
            this.rbnDSX509.Size = new System.Drawing.Size(50, 16);
            this.rbnDSX509.TabIndex = 1;
            this.rbnDSX509.TabStop = true;
            this.rbnDSX509.Text = "X.509";
            this.rbnDSX509.UseVisualStyleBackColor = true;
            this.rbnDSX509.CheckedChanged += new System.EventHandler(this.rbnDS_CheckedChanged);
            // 
            // rbnDSXML
            // 
            this.rbnDSXML.AutoSize = true;
            this.rbnDSXML.Checked = true;
            this.rbnDSXML.Location = new System.Drawing.Point(20, 18);
            this.rbnDSXML.Name = "rbnDSXML";
            this.rbnDSXML.Size = new System.Drawing.Size(45, 16);
            this.rbnDSXML.TabIndex = 0;
            this.rbnDSXML.TabStop = true;
            this.rbnDSXML.Text = "XML";
            this.rbnDSXML.UseVisualStyleBackColor = true;
            this.rbnDSXML.CheckedChanged += new System.EventHandler(this.rbnDS_CheckedChanged);
            // 
            // btnDSSign
            // 
            this.btnDSSign.Location = new System.Drawing.Point(11, 210);
            this.btnDSSign.Name = "btnDSSign";
            this.btnDSSign.Size = new System.Drawing.Size(174, 23);
            this.btnDSSign.TabIndex = 0;
            this.btnDSSign.Text = "署名";
            this.btnDSSign.UseVisualStyleBackColor = true;
            this.btnDSSign.Click += new System.EventHandler(this.btnDSSign_Click);
            // 
            // tabMAC
            // 
            this.tabMAC.Controls.Add(this.btnVerifyMAC);
            this.tabMAC.Controls.Add(this.lblMAC4);
            this.tabMAC.Controls.Add(this.cbxMACPV);
            this.tabMAC.Controls.Add(this.btnGetMAC);
            this.tabMAC.Controls.Add(this.txtMACValue);
            this.tabMAC.Controls.Add(this.lblMAC3);
            this.tabMAC.Controls.Add(this.lblMAC2);
            this.tabMAC.Controls.Add(this.lblMAC1);
            this.tabMAC.Controls.Add(this.txtMACPassword);
            this.tabMAC.Controls.Add(this.txtMACString);
            this.tabMAC.Location = new System.Drawing.Point(4, 40);
            this.tabMAC.Name = "tabMAC";
            this.tabMAC.Size = new System.Drawing.Size(560, 304);
            this.tabMAC.TabIndex = 8;
            this.tabMAC.Text = "MAC";
            this.tabMAC.UseVisualStyleBackColor = true;
            // 
            // btnVerifyMAC
            // 
            this.btnVerifyMAC.Location = new System.Drawing.Point(108, 142);
            this.btnVerifyMAC.Name = "btnVerifyMAC";
            this.btnVerifyMAC.Size = new System.Drawing.Size(212, 23);
            this.btnVerifyMAC.TabIndex = 49;
            this.btnVerifyMAC.Text = "VerifyMAC";
            this.btnVerifyMAC.UseVisualStyleBackColor = true;
            this.btnVerifyMAC.Click += new System.EventHandler(this.btnVerifyMAC_Click);
            // 
            // lblMAC4
            // 
            this.lblMAC4.AutoSize = true;
            this.lblMAC4.Location = new System.Drawing.Point(14, 91);
            this.lblMAC4.Name = "lblMAC4";
            this.lblMAC4.Size = new System.Drawing.Size(42, 12);
            this.lblMAC4.TabIndex = 48;
            this.lblMAC4.Text = "MAC値";
            // 
            // cbxMACPV
            // 
            this.cbxMACPV.FormattingEnabled = true;
            this.cbxMACPV.Location = new System.Drawing.Point(108, 12);
            this.cbxMACPV.Name = "cbxMACPV";
            this.cbxMACPV.Size = new System.Drawing.Size(212, 20);
            this.cbxMACPV.TabIndex = 47;
            // 
            // btnGetMAC
            // 
            this.btnGetMAC.Location = new System.Drawing.Point(108, 113);
            this.btnGetMAC.Name = "btnGetMAC";
            this.btnGetMAC.Size = new System.Drawing.Size(212, 23);
            this.btnGetMAC.TabIndex = 46;
            this.btnGetMAC.Text = "GetMAC";
            this.btnGetMAC.UseVisualStyleBackColor = true;
            this.btnGetMAC.Click += new System.EventHandler(this.btnGetMAC_Click);
            // 
            // txtMACValue
            // 
            this.txtMACValue.Location = new System.Drawing.Point(108, 88);
            this.txtMACValue.Name = "txtMACValue";
            this.txtMACValue.ReadOnly = true;
            this.txtMACValue.Size = new System.Drawing.Size(212, 19);
            this.txtMACValue.TabIndex = 45;
            // 
            // lblMAC3
            // 
            this.lblMAC3.AutoSize = true;
            this.lblMAC3.Location = new System.Drawing.Point(14, 66);
            this.lblMAC3.Name = "lblMAC3";
            this.lblMAC3.Size = new System.Drawing.Size(52, 12);
            this.lblMAC3.TabIndex = 44;
            this.lblMAC3.Text = "パスワード";
            // 
            // lblMAC2
            // 
            this.lblMAC2.AutoSize = true;
            this.lblMAC2.Location = new System.Drawing.Point(14, 41);
            this.lblMAC2.Name = "lblMAC2";
            this.lblMAC2.Size = new System.Drawing.Size(41, 12);
            this.lblMAC2.TabIndex = 43;
            this.lblMAC2.Text = "文字列";
            // 
            // lblMAC1
            // 
            this.lblMAC1.AutoSize = true;
            this.lblMAC1.Location = new System.Drawing.Point(14, 16);
            this.lblMAC1.Name = "lblMAC1";
            this.lblMAC1.Size = new System.Drawing.Size(75, 12);
            this.lblMAC1.TabIndex = 42;
            this.lblMAC1.Text = "暗号プロバイダ";
            // 
            // txtMACPassword
            // 
            this.txtMACPassword.Location = new System.Drawing.Point(108, 63);
            this.txtMACPassword.Name = "txtMACPassword";
            this.txtMACPassword.Size = new System.Drawing.Size(212, 19);
            this.txtMACPassword.TabIndex = 41;
            // 
            // txtMACString
            // 
            this.txtMACString.Location = new System.Drawing.Point(108, 38);
            this.txtMACString.Name = "txtMACString";
            this.txtMACString.Size = new System.Drawing.Size(212, 19);
            this.txtMACString.TabIndex = 40;
            // 
            // tabAEAD
            // 
            this.tabAEAD.Location = new System.Drawing.Point(4, 40);
            this.tabAEAD.Name = "tabAEAD";
            this.tabAEAD.Size = new System.Drawing.Size(560, 304);
            this.tabAEAD.TabIndex = 9;
            this.tabAEAD.Text = "AEAD";
            this.tabAEAD.UseVisualStyleBackColor = true;
            // 
            // tabJWS
            // 
            this.tabJWS.Controls.Add(this.lblJWSJWK);
            this.tabJWS.Controls.Add(this.lblJWSKey);
            this.tabJWS.Controls.Add(this.lblJWSPayload);
            this.tabJWS.Controls.Add(this.txtJWSJWK);
            this.tabJWS.Controls.Add(this.txtJWSHeader);
            this.tabJWS.Controls.Add(this.txtJWSKey);
            this.tabJWS.Controls.Add(this.lblJWS3);
            this.tabJWS.Controls.Add(this.txtJWSSign);
            this.tabJWS.Controls.Add(this.lblJWSHeader);
            this.tabJWS.Controls.Add(this.txtJWSPayload);
            this.tabJWS.Controls.Add(this.gbxJWS);
            this.tabJWS.Controls.Add(this.btnJWSVerify);
            this.tabJWS.Controls.Add(this.btnJWSSign);
            this.tabJWS.Location = new System.Drawing.Point(4, 40);
            this.tabJWS.Name = "tabJWS";
            this.tabJWS.Size = new System.Drawing.Size(560, 304);
            this.tabJWS.TabIndex = 6;
            this.tabJWS.Text = "JWS";
            this.tabJWS.UseVisualStyleBackColor = true;
            // 
            // lblJWSJWK
            // 
            this.lblJWSJWK.AutoSize = true;
            this.lblJWSJWK.Location = new System.Drawing.Point(13, 85);
            this.lblJWSJWK.Name = "lblJWSJWK";
            this.lblJWSJWK.Size = new System.Drawing.Size(28, 12);
            this.lblJWSJWK.TabIndex = 54;
            this.lblJWSJWK.Text = "JWK";
            // 
            // lblJWSKey
            // 
            this.lblJWSKey.AutoSize = true;
            this.lblJWSKey.Location = new System.Drawing.Point(13, 60);
            this.lblJWSKey.Name = "lblJWSKey";
            this.lblJWSKey.Size = new System.Drawing.Size(24, 12);
            this.lblJWSKey.TabIndex = 53;
            this.lblJWSKey.Text = "Key";
            // 
            // lblJWSPayload
            // 
            this.lblJWSPayload.AutoSize = true;
            this.lblJWSPayload.Location = new System.Drawing.Point(13, 149);
            this.lblJWSPayload.Name = "lblJWSPayload";
            this.lblJWSPayload.Size = new System.Drawing.Size(45, 12);
            this.lblJWSPayload.TabIndex = 52;
            this.lblJWSPayload.Text = "Payload";
            // 
            // txtJWSJWK
            // 
            this.txtJWSJWK.Location = new System.Drawing.Point(85, 82);
            this.txtJWSJWK.Name = "txtJWSJWK";
            this.txtJWSJWK.ReadOnly = true;
            this.txtJWSJWK.Size = new System.Drawing.Size(285, 19);
            this.txtJWSJWK.TabIndex = 3;
            // 
            // txtJWSHeader
            // 
            this.txtJWSHeader.Location = new System.Drawing.Point(85, 107);
            this.txtJWSHeader.Multiline = true;
            this.txtJWSHeader.Name = "txtJWSHeader";
            this.txtJWSHeader.Size = new System.Drawing.Size(285, 33);
            this.txtJWSHeader.TabIndex = 51;
            // 
            // txtJWSKey
            // 
            this.txtJWSKey.Location = new System.Drawing.Point(85, 57);
            this.txtJWSKey.Name = "txtJWSKey";
            this.txtJWSKey.ReadOnly = true;
            this.txtJWSKey.Size = new System.Drawing.Size(285, 19);
            this.txtJWSKey.TabIndex = 2;
            // 
            // lblJWS3
            // 
            this.lblJWS3.AutoSize = true;
            this.lblJWS3.Location = new System.Drawing.Point(9, 188);
            this.lblJWS3.Name = "lblJWS3";
            this.lblJWS3.Size = new System.Drawing.Size(29, 12);
            this.lblJWS3.TabIndex = 50;
            this.lblJWS3.Text = "署名";
            // 
            // txtJWSSign
            // 
            this.txtJWSSign.Location = new System.Drawing.Point(85, 185);
            this.txtJWSSign.Name = "txtJWSSign";
            this.txtJWSSign.ReadOnly = true;
            this.txtJWSSign.Size = new System.Drawing.Size(285, 19);
            this.txtJWSSign.TabIndex = 49;
            // 
            // lblJWSHeader
            // 
            this.lblJWSHeader.AutoSize = true;
            this.lblJWSHeader.Location = new System.Drawing.Point(13, 110);
            this.lblJWSHeader.Name = "lblJWSHeader";
            this.lblJWSHeader.Size = new System.Drawing.Size(41, 12);
            this.lblJWSHeader.TabIndex = 48;
            this.lblJWSHeader.Text = "Header";
            // 
            // txtJWSPayload
            // 
            this.txtJWSPayload.Location = new System.Drawing.Point(85, 146);
            this.txtJWSPayload.Multiline = true;
            this.txtJWSPayload.Name = "txtJWSPayload";
            this.txtJWSPayload.Size = new System.Drawing.Size(285, 33);
            this.txtJWSPayload.TabIndex = 47;
            this.txtJWSPayload.Text = "{ \"aaa\": \"AAA\", \"bbb\": \"BBB\", \"ccc\": \"CCC\"}";
            // 
            // gbxJWS
            // 
            this.gbxJWS.Controls.Add(this.rbnJWSRS256_XML);
            this.gbxJWS.Controls.Add(this.rbnJWSRS256_Param);
            this.gbxJWS.Controls.Add(this.rbnJWSRS256_X509);
            this.gbxJWS.Controls.Add(this.rbnJWSHS256);
            this.gbxJWS.Location = new System.Drawing.Point(9, 7);
            this.gbxJWS.Name = "gbxJWS";
            this.gbxJWS.Size = new System.Drawing.Size(361, 44);
            this.gbxJWS.TabIndex = 46;
            this.gbxJWS.TabStop = false;
            this.gbxJWS.Text = "API選択";
            // 
            // rbnJWSRS256_XML
            // 
            this.rbnJWSRS256_XML.AutoSize = true;
            this.rbnJWSRS256_XML.Checked = true;
            this.rbnJWSRS256_XML.Location = new System.Drawing.Point(12, 18);
            this.rbnJWSRS256_XML.Name = "rbnJWSRS256_XML";
            this.rbnJWSRS256_XML.Size = new System.Drawing.Size(82, 16);
            this.rbnJWSRS256_XML.TabIndex = 3;
            this.rbnJWSRS256_XML.TabStop = true;
            this.rbnJWSRS256_XML.Text = "RS256_XML";
            this.rbnJWSRS256_XML.UseVisualStyleBackColor = true;
            // 
            // rbnJWSRS256_Param
            // 
            this.rbnJWSRS256_Param.AutoSize = true;
            this.rbnJWSRS256_Param.Checked = true;
            this.rbnJWSRS256_Param.Location = new System.Drawing.Point(110, 18);
            this.rbnJWSRS256_Param.Name = "rbnJWSRS256_Param";
            this.rbnJWSRS256_Param.Size = new System.Drawing.Size(92, 16);
            this.rbnJWSRS256_Param.TabIndex = 2;
            this.rbnJWSRS256_Param.TabStop = true;
            this.rbnJWSRS256_Param.Text = "RS256_Param";
            this.rbnJWSRS256_Param.UseVisualStyleBackColor = true;
            // 
            // rbnJWSRS256_X509
            // 
            this.rbnJWSRS256_X509.AutoSize = true;
            this.rbnJWSRS256_X509.Checked = true;
            this.rbnJWSRS256_X509.Location = new System.Drawing.Point(208, 18);
            this.rbnJWSRS256_X509.Name = "rbnJWSRS256_X509";
            this.rbnJWSRS256_X509.Size = new System.Drawing.Size(85, 16);
            this.rbnJWSRS256_X509.TabIndex = 1;
            this.rbnJWSRS256_X509.TabStop = true;
            this.rbnJWSRS256_X509.Text = "RS256_X509";
            this.rbnJWSRS256_X509.UseVisualStyleBackColor = true;
            // 
            // rbnJWSHS256
            // 
            this.rbnJWSHS256.AutoSize = true;
            this.rbnJWSHS256.Location = new System.Drawing.Point(299, 18);
            this.rbnJWSHS256.Name = "rbnJWSHS256";
            this.rbnJWSHS256.Size = new System.Drawing.Size(56, 16);
            this.rbnJWSHS256.TabIndex = 0;
            this.rbnJWSHS256.Text = "HS256";
            this.rbnJWSHS256.UseVisualStyleBackColor = true;
            // 
            // btnJWSVerify
            // 
            this.btnJWSVerify.Location = new System.Drawing.Point(203, 210);
            this.btnJWSVerify.Name = "btnJWSVerify";
            this.btnJWSVerify.Size = new System.Drawing.Size(167, 23);
            this.btnJWSVerify.TabIndex = 45;
            this.btnJWSVerify.Text = "検証";
            this.btnJWSVerify.UseVisualStyleBackColor = true;
            this.btnJWSVerify.Click += new System.EventHandler(this.btnJWSVerify_Click);
            // 
            // btnJWSSign
            // 
            this.btnJWSSign.Location = new System.Drawing.Point(11, 210);
            this.btnJWSSign.Name = "btnJWSSign";
            this.btnJWSSign.Size = new System.Drawing.Size(167, 23);
            this.btnJWSSign.TabIndex = 44;
            this.btnJWSSign.Text = "署名";
            this.btnJWSSign.UseVisualStyleBackColor = true;
            this.btnJWSSign.Click += new System.EventHandler(this.btnJWSSign_Click);
            // 
            // tabJWE
            // 
            this.tabJWE.Location = new System.Drawing.Point(4, 40);
            this.tabJWE.Name = "tabJWE";
            this.tabJWE.Size = new System.Drawing.Size(560, 304);
            this.tabJWE.TabIndex = 10;
            this.tabJWE.Text = "JWE";
            this.tabJWE.UseVisualStyleBackColor = true;
            // 
            // tabRKEX
            // 
            this.tabRKEX.Controls.Add(this.label2);
            this.tabRKEX.Controls.Add(this.label1);
            this.tabRKEX.Controls.Add(this.txtRKEXKeyInfo);
            this.tabRKEX.Controls.Add(this.lblRKEX2);
            this.tabRKEX.Controls.Add(this.lblRKEX1);
            this.tabRKEX.Controls.Add(this.txtRKEXBobString);
            this.tabRKEX.Controls.Add(this.txtRKEXAliceString);
            this.tabRKEX.Controls.Add(this.cbxRKEXPV);
            this.tabRKEX.Controls.Add(this.btnRKEXSR);
            this.tabRKEX.Controls.Add(this.btnRKEXEC);
            this.tabRKEX.Location = new System.Drawing.Point(4, 40);
            this.tabRKEX.Name = "tabRKEX";
            this.tabRKEX.Size = new System.Drawing.Size(560, 304);
            this.tabRKEX.TabIndex = 11;
            this.tabRKEX.Text = "RSA鍵交換";
            this.tabRKEX.UseVisualStyleBackColor = true;
            // 
            // tabEKEX
            // 
            this.tabEKEX.Location = new System.Drawing.Point(4, 40);
            this.tabEKEX.Name = "tabEKEX";
            this.tabEKEX.Size = new System.Drawing.Size(560, 304);
            this.tabEKEX.TabIndex = 12;
            this.tabEKEX.Text = "ECDH鍵交換";
            this.tabEKEX.UseVisualStyleBackColor = true;
            // 
            // btnRKEXEC
            // 
            this.btnRKEXEC.Location = new System.Drawing.Point(32, 187);
            this.btnRKEXEC.Name = "btnRKEXEC";
            this.btnRKEXEC.Size = new System.Drawing.Size(174, 23);
            this.btnRKEXEC.TabIndex = 1;
            this.btnRKEXEC.Text = "キー交換";
            this.btnRKEXEC.UseVisualStyleBackColor = true;
            this.btnRKEXEC.Click += new System.EventHandler(this.btnRKEXEC_Click);
            // 
            // btnRKEXSR
            // 
            this.btnRKEXSR.Location = new System.Drawing.Point(212, 187);
            this.btnRKEXSR.Name = "btnRKEXSR";
            this.btnRKEXSR.Size = new System.Drawing.Size(174, 23);
            this.btnRKEXSR.TabIndex = 2;
            this.btnRKEXSR.Text = "送受信";
            this.btnRKEXSR.UseVisualStyleBackColor = true;
            this.btnRKEXSR.Click += new System.EventHandler(this.btnRKEXSR_Click);
            // 
            // cbxRKEXPV
            // 
            this.cbxRKEXPV.FormattingEnabled = true;
            this.cbxRKEXPV.Location = new System.Drawing.Point(96, 14);
            this.cbxRKEXPV.Name = "cbxRKEXPV";
            this.cbxRKEXPV.Size = new System.Drawing.Size(290, 20);
            this.cbxRKEXPV.TabIndex = 33;
            // 
            // txtRKEXAliceString
            // 
            this.txtRKEXAliceString.Location = new System.Drawing.Point(96, 137);
            this.txtRKEXAliceString.Name = "txtRKEXAliceString";
            this.txtRKEXAliceString.Size = new System.Drawing.Size(290, 19);
            this.txtRKEXAliceString.TabIndex = 35;
            // 
            // txtRKEXBobString
            // 
            this.txtRKEXBobString.Location = new System.Drawing.Point(96, 162);
            this.txtRKEXBobString.Name = "txtRKEXBobString";
            this.txtRKEXBobString.ReadOnly = true;
            this.txtRKEXBobString.Size = new System.Drawing.Size(290, 19);
            this.txtRKEXBobString.TabIndex = 36;
            // 
            // lblRKEX1
            // 
            this.lblRKEX1.AutoSize = true;
            this.lblRKEX1.Location = new System.Drawing.Point(30, 17);
            this.lblRKEX1.Name = "lblRKEX1";
            this.lblRKEX1.Size = new System.Drawing.Size(51, 12);
            this.lblRKEX1.TabIndex = 37;
            this.lblRKEX1.Text = "プロバイダ";
            // 
            // lblRKEX2
            // 
            this.lblRKEX2.AutoSize = true;
            this.lblRKEX2.Location = new System.Drawing.Point(30, 54);
            this.lblRKEX2.Name = "lblRKEX2";
            this.lblRKEX2.Size = new System.Drawing.Size(41, 12);
            this.lblRKEX2.TabIndex = 38;
            this.lblRKEX2.Text = "鍵情報";
            // 
            // txtRKEXKeyInfo
            // 
            this.txtRKEXKeyInfo.Location = new System.Drawing.Point(96, 51);
            this.txtRKEXKeyInfo.Multiline = true;
            this.txtRKEXKeyInfo.Name = "txtRKEXKeyInfo";
            this.txtRKEXKeyInfo.ReadOnly = true;
            this.txtRKEXKeyInfo.Size = new System.Drawing.Size(290, 80);
            this.txtRKEXKeyInfo.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 40;
            this.label1.Text = "アリス";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 41;
            this.label2.Text = "ボブ";
            // 
            // cbxSCPV2
            // 
            this.cbxSCPV2.FormattingEnabled = true;
            this.cbxSCPV2.Location = new System.Drawing.Point(265, 59);
            this.cbxSCPV2.Name = "cbxSCPV2";
            this.cbxSCPV2.Size = new System.Drawing.Size(95, 20);
            this.cbxSCPV2.TabIndex = 27;
            // 
            // cbxSCPV3
            // 
            this.cbxSCPV3.FormattingEnabled = true;
            this.cbxSCPV3.Location = new System.Drawing.Point(366, 59);
            this.cbxSCPV3.Name = "cbxSCPV3";
            this.cbxSCPV3.Size = new System.Drawing.Size(95, 20);
            this.cbxSCPV3.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 367);
            this.Controls.Add(this.btnSPWDAuth2);
            this.Name = "Form1";
            this.Text = "暗号化・復号化ユーティリティ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btnSPWDAuth2.ResumeLayout(false);
            this.tabHash.ResumeLayout(false);
            this.tabHash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHSStretching)).EndInit();
            this.gbxHS.ResumeLayout(false);
            this.gbxHS.PerformLayout();
            this.tabKeyedHash.ResumeLayout(false);
            this.tabKeyedHash.PerformLayout();
            this.gbxKHS.ResumeLayout(false);
            this.gbxKHS.PerformLayout();
            this.tabPwdDB1.ResumeLayout(false);
            this.tabPwdDB1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSPWDStretchCount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSPWDSaltLength1)).EndInit();
            this.tabPwdDB2.ResumeLayout(false);
            this.tabPwdDB2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSPWDStretchCount2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSPWDSaltLength2)).EndInit();
            this.tabSC.ResumeLayout(false);
            this.tabSC.PerformLayout();
            this.gbxSC.ResumeLayout(false);
            this.gbxSC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSCStretching)).EndInit();
            this.tabASC.ResumeLayout(false);
            this.tabASC.PerformLayout();
            this.gbxASC.ResumeLayout(false);
            this.gbxASC.PerformLayout();
            this.tabDS.ResumeLayout(false);
            this.tabDS.PerformLayout();
            this.gbxDS.ResumeLayout(false);
            this.gbxDS.PerformLayout();
            this.tabMAC.ResumeLayout(false);
            this.tabMAC.PerformLayout();
            this.tabJWS.ResumeLayout(false);
            this.tabJWS.PerformLayout();
            this.gbxJWS.ResumeLayout(false);
            this.gbxJWS.PerformLayout();
            this.tabRKEX.ResumeLayout(false);
            this.tabRKEX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl btnSPWDAuth2;
        private System.Windows.Forms.TabPage tabSC;
        private System.Windows.Forms.ComboBox cbxSCPV1;
        private System.Windows.Forms.Button btnSCDecrypt;
        private System.Windows.Forms.Button btnSCEncrypt;
        private System.Windows.Forms.TextBox txtSCCode;
        private System.Windows.Forms.TextBox txtSCSalt;
        private System.Windows.Forms.Label lblSC3;
        private System.Windows.Forms.Label lblSC2;
        private System.Windows.Forms.Label lblSC1;
        private System.Windows.Forms.TextBox txtSCPassword;
        private System.Windows.Forms.TextBox txtSCString;
        private System.Windows.Forms.TabPage tabASC;
        private System.Windows.Forms.Label lblSC5;
        private System.Windows.Forms.Label lblSC4;
        private System.Windows.Forms.NumericUpDown nudSCStretching;
        private System.Windows.Forms.Label lblSC6;
        private System.Windows.Forms.GroupBox gbxSC;
        private System.Windows.Forms.RadioButton rbnSCBytes;
        private System.Windows.Forms.RadioButton rbnSCString;
        private System.Windows.Forms.Label lblASC4;
        private System.Windows.Forms.TextBox txtASCCode;
        private System.Windows.Forms.TextBox txtASCPublic;
        private System.Windows.Forms.TextBox txtASCPrivate;
        private System.Windows.Forms.Label lblASC3;
        private System.Windows.Forms.GroupBox gbxASC;
        private System.Windows.Forms.RadioButton rbnASCBytes;
        private System.Windows.Forms.RadioButton rbnASCString;
        private System.Windows.Forms.Label lblASC5;
        private System.Windows.Forms.Button btnASCDecrypt;
        private System.Windows.Forms.Button btnASCEncrypt;
        private System.Windows.Forms.Label lblASC2;
        private System.Windows.Forms.Label lblASC1;
        private System.Windows.Forms.TextBox txtASCString;
        private System.Windows.Forms.Button btnASCGetKey;
        private System.Windows.Forms.TabPage tabHash;
        private System.Windows.Forms.Button btnGetHash;
        private System.Windows.Forms.GroupBox gbxHS;
        private System.Windows.Forms.RadioButton rbnHSBytes;
        private System.Windows.Forms.RadioButton rbnHSString;
        private System.Windows.Forms.ComboBox cbxHSPV;
        private System.Windows.Forms.Label lblHS1;
        private System.Windows.Forms.Label lblHS4;
        private System.Windows.Forms.TextBox txtHSCode;
        private System.Windows.Forms.Label lblHS2;
        private System.Windows.Forms.TextBox txtHSString;
        private System.Windows.Forms.TabPage tabKeyedHash;
        private System.Windows.Forms.GroupBox gbxKHS;
        private System.Windows.Forms.RadioButton rbnKHSBytes;
        private System.Windows.Forms.RadioButton rbnKHSString;
        private System.Windows.Forms.Label lblKHS6;
        private System.Windows.Forms.ComboBox cbxKHSPV;
        private System.Windows.Forms.Button btnGetKeyedHash;
        private System.Windows.Forms.TextBox txtKHSCode;
        private System.Windows.Forms.Label lblKHS3;
        private System.Windows.Forms.Label lblKHS2;
        private System.Windows.Forms.Label lblKHS1;
        private System.Windows.Forms.TextBox txtKHSPassword;
        private System.Windows.Forms.TextBox txtKHSString;
        private System.Windows.Forms.TabPage tabPwdDB1;
        private System.Windows.Forms.Label lblSPWD15;
        private System.Windows.Forms.TextBox txtSPWDSaltedPassword1;
        private System.Windows.Forms.Label lblSPWD12;
        private System.Windows.Forms.TextBox txtSPWDRawPassword1;
        private System.Windows.Forms.ComboBox cbxSPWDPV1;
        private System.Windows.Forms.Label lblSPWD11;
        private System.Windows.Forms.Button btnSPWDGen1;
        private System.Windows.Forms.Button btnSPWDAuth1;
        private System.Windows.Forms.NumericUpDown nudSPWDSaltLength1;
        private System.Windows.Forms.Label lblSPWD13;
        private System.Windows.Forms.NumericUpDown nudHSStretching;
        private System.Windows.Forms.Label lblHS3;
        private System.Windows.Forms.TabPage tabPwdDB2;
        private System.Windows.Forms.TabPage tabJWS;
        private System.Windows.Forms.TabPage tabDS;
        private System.Windows.Forms.NumericUpDown nudSPWDSaltLength2;
        private System.Windows.Forms.Label lblSPWD24;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSPWD26;
        private System.Windows.Forms.TextBox txtSPWDSaltedPassword2;
        private System.Windows.Forms.Label lblSPWD22;
        private System.Windows.Forms.TextBox txtSPWDRawPassword2;
        private System.Windows.Forms.ComboBox cbxSPWDPV2;
        private System.Windows.Forms.Label lblSPWD21;
        private System.Windows.Forms.Button btnSPWDGen2;
        private System.Windows.Forms.Label lblSPWD23;
        private System.Windows.Forms.TextBox txtSPWDKey2;
        private System.Windows.Forms.NumericUpDown nudSPWDStretchCount2;
        private System.Windows.Forms.Label lblSPWD25;
        private System.Windows.Forms.NumericUpDown nudSPWDStretchCount1;
        private System.Windows.Forms.Label lblSPWD14;
        private System.Windows.Forms.Button btnDSSign;
        private System.Windows.Forms.GroupBox gbxDS;
        private System.Windows.Forms.RadioButton rbnDSX509;
        private System.Windows.Forms.RadioButton rbnDSXML;
        private System.Windows.Forms.ComboBox cbxDSPV;
        private System.Windows.Forms.Label lblDS1;
        private System.Windows.Forms.Label lblDS3;
        private System.Windows.Forms.Label lblDS2;
        private System.Windows.Forms.TextBox txtDSData;
        private System.Windows.Forms.TextBox txtDSHash;
        private System.Windows.Forms.Label lblDS6;
        private System.Windows.Forms.TextBox txtDSSign;
        private System.Windows.Forms.Label lblDS5;
        private System.Windows.Forms.TextBox txtDSPublicKey;
        private System.Windows.Forms.Label lblDS4;
        private System.Windows.Forms.TextBox txtDSPrivateKey;
        private System.Windows.Forms.Button btnDSVerify;
        private System.Windows.Forms.Button btnJWSVerify;
        private System.Windows.Forms.Button btnJWSSign;
        private System.Windows.Forms.Label lblJWS3;
        private System.Windows.Forms.TextBox txtJWSSign;
        private System.Windows.Forms.Label lblJWSHeader;
        private System.Windows.Forms.TextBox txtJWSPayload;
        private System.Windows.Forms.TextBox txtJWSHeader;
        private System.Windows.Forms.RadioButton rbnDSParam;
        private System.Windows.Forms.TextBox txtJWSJWK;
        private System.Windows.Forms.TextBox txtJWSKey;
        private System.Windows.Forms.GroupBox gbxJWS;
        private System.Windows.Forms.RadioButton rbnJWSRS256_X509;
        private System.Windows.Forms.RadioButton rbnJWSHS256;
        private System.Windows.Forms.Label lblJWSPayload;
        private System.Windows.Forms.Label lblJWSJWK;
        private System.Windows.Forms.Label lblJWSKey;
        private System.Windows.Forms.RadioButton rbnJWSRS256_Param;
        private System.Windows.Forms.RadioButton rbnJWSRS256_XML;
        private System.Windows.Forms.ComboBox cbxASCPV;
        private System.Windows.Forms.TabPage tabMAC;
        private System.Windows.Forms.Button btnVerifyMAC;
        private System.Windows.Forms.Label lblMAC4;
        private System.Windows.Forms.ComboBox cbxMACPV;
        private System.Windows.Forms.Button btnGetMAC;
        private System.Windows.Forms.TextBox txtMACValue;
        private System.Windows.Forms.Label lblMAC3;
        private System.Windows.Forms.Label lblMAC2;
        private System.Windows.Forms.Label lblMAC1;
        private System.Windows.Forms.TextBox txtMACPassword;
        private System.Windows.Forms.TextBox txtMACString;
        private System.Windows.Forms.TabPage tabAEAD;
        private System.Windows.Forms.TabPage tabJWE;
        private System.Windows.Forms.TabPage tabRKEX;
        private System.Windows.Forms.TabPage tabEKEX;
        private System.Windows.Forms.Button btnRKEXSR;
        private System.Windows.Forms.Button btnRKEXEC;
        private System.Windows.Forms.ComboBox cbxRKEXPV;
        private System.Windows.Forms.Label lblRKEX1;
        private System.Windows.Forms.TextBox txtRKEXBobString;
        private System.Windows.Forms.TextBox txtRKEXAliceString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRKEXKeyInfo;
        private System.Windows.Forms.Label lblRKEX2;
        private System.Windows.Forms.ComboBox cbxSCPV3;
        private System.Windows.Forms.ComboBox cbxSCPV2;
    }
}

