namespace QR_Tool_Winform
{
    partial class TestConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbQRPlatformUrl = new MetroFramework.Controls.MetroTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbQRAPPIP = new MetroFramework.Controls.MetroTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbBackUrl = new MetroFramework.Controls.MetroTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbEncoding = new MetroFramework.Controls.MetroComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbUnqiueNumber = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbMacQRcode = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDeviceTypeSelect = new MetroFramework.Controls.MetroComboBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(30, 90);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox7);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.metroButton2);
            this.splitContainer1.Panel2.Controls.Add(this.btnConfirm);
            this.splitContainer1.Size = new System.Drawing.Size(668, 862);
            this.splitContainer1.SplitterDistance = 716;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbQRPlatformUrl);
            this.groupBox7.Location = new System.Drawing.Point(36, 582);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(602, 81);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "二维码平台地址";
            // 
            // tbQRPlatformUrl
            // 
            this.tbQRPlatformUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQRPlatformUrl.Lines = new string[] {
        "https://1715m7746k.51mypc.cn:15107/"};
            this.tbQRPlatformUrl.Location = new System.Drawing.Point(4, 25);
            this.tbQRPlatformUrl.Margin = new System.Windows.Forms.Padding(4);
            this.tbQRPlatformUrl.MaxLength = 32767;
            this.tbQRPlatformUrl.Multiline = true;
            this.tbQRPlatformUrl.Name = "tbQRPlatformUrl";
            this.tbQRPlatformUrl.PasswordChar = '\0';
            this.tbQRPlatformUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbQRPlatformUrl.SelectedText = "";
            this.tbQRPlatformUrl.Size = new System.Drawing.Size(594, 52);
            this.tbQRPlatformUrl.TabIndex = 1;
            this.tbQRPlatformUrl.Text = "https://1715m7746k.51mypc.cn:15107/";
            this.tbQRPlatformUrl.UseSelectable = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbQRAPPIP);
            this.groupBox6.Location = new System.Drawing.Point(32, 470);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(606, 81);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "二维码APP监听地址";
            // 
            // tbQRAPPIP
            // 
            this.tbQRAPPIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQRAPPIP.Lines = new string[0];
            this.tbQRAPPIP.Location = new System.Drawing.Point(4, 25);
            this.tbQRAPPIP.Margin = new System.Windows.Forms.Padding(4);
            this.tbQRAPPIP.MaxLength = 32767;
            this.tbQRAPPIP.Multiline = true;
            this.tbQRAPPIP.Name = "tbQRAPPIP";
            this.tbQRAPPIP.PasswordChar = '\0';
            this.tbQRAPPIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbQRAPPIP.SelectedText = "";
            this.tbQRAPPIP.Size = new System.Drawing.Size(598, 52);
            this.tbQRAPPIP.TabIndex = 1;
            this.tbQRAPPIP.UseSelectable = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbBackUrl);
            this.groupBox5.Location = new System.Drawing.Point(32, 360);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(606, 81);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "后台通知地址";
            // 
            // tbBackUrl
            // 
            this.tbBackUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBackUrl.Lines = new string[0];
            this.tbBackUrl.Location = new System.Drawing.Point(4, 25);
            this.tbBackUrl.Margin = new System.Windows.Forms.Padding(4);
            this.tbBackUrl.MaxLength = 32767;
            this.tbBackUrl.Multiline = true;
            this.tbBackUrl.Name = "tbBackUrl";
            this.tbBackUrl.PasswordChar = '\0';
            this.tbBackUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbBackUrl.SelectedText = "";
            this.tbBackUrl.Size = new System.Drawing.Size(598, 52);
            this.tbBackUrl.TabIndex = 1;
            this.tbBackUrl.UseSelectable = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbEncoding);
            this.groupBox4.Location = new System.Drawing.Point(408, 24);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(230, 80);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "编码类型";
            // 
            // cbEncoding
            // 
            this.cbEncoding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEncoding.FormattingEnabled = true;
            this.cbEncoding.ItemHeight = 23;
            this.cbEncoding.Items.AddRange(new object[] {
            "GBK",
            "UTF-8"});
            this.cbEncoding.Location = new System.Drawing.Point(4, 25);
            this.cbEncoding.Margin = new System.Windows.Forms.Padding(4);
            this.cbEncoding.Name = "cbEncoding";
            this.cbEncoding.Size = new System.Drawing.Size(222, 29);
            this.cbEncoding.TabIndex = 1;
            this.cbEncoding.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbUnqiueNumber);
            this.groupBox3.Location = new System.Drawing.Point(32, 252);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(606, 81);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设备序列号";
            // 
            // txbUnqiueNumber
            // 
            this.txbUnqiueNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbUnqiueNumber.Lines = new string[0];
            this.txbUnqiueNumber.Location = new System.Drawing.Point(4, 25);
            this.txbUnqiueNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txbUnqiueNumber.MaxLength = 32767;
            this.txbUnqiueNumber.Multiline = true;
            this.txbUnqiueNumber.Name = "txbUnqiueNumber";
            this.txbUnqiueNumber.PasswordChar = '\0';
            this.txbUnqiueNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbUnqiueNumber.SelectedText = "";
            this.txbUnqiueNumber.Size = new System.Drawing.Size(598, 52);
            this.txbUnqiueNumber.TabIndex = 1;
            this.txbUnqiueNumber.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbMacQRcode);
            this.groupBox2.Location = new System.Drawing.Point(32, 138);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(606, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "支持的最大字母/数字";
            // 
            // txbMacQRcode
            // 
            this.txbMacQRcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbMacQRcode.Lines = new string[] {
        "100"};
            this.txbMacQRcode.Location = new System.Drawing.Point(4, 25);
            this.txbMacQRcode.Margin = new System.Windows.Forms.Padding(4);
            this.txbMacQRcode.MaxLength = 32767;
            this.txbMacQRcode.Multiline = true;
            this.txbMacQRcode.Name = "txbMacQRcode";
            this.txbMacQRcode.PasswordChar = '\0';
            this.txbMacQRcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbMacQRcode.SelectedText = "";
            this.txbMacQRcode.Size = new System.Drawing.Size(598, 52);
            this.txbMacQRcode.TabIndex = 0;
            this.txbMacQRcode.Text = "100";
            this.txbMacQRcode.UseSelectable = true;
            this.txbMacQRcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMacQRcode_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDeviceTypeSelect);
            this.groupBox1.Location = new System.Drawing.Point(32, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(230, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备类型";
            // 
            // cbDeviceTypeSelect
            // 
            this.cbDeviceTypeSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDeviceTypeSelect.FormattingEnabled = true;
            this.cbDeviceTypeSelect.ItemHeight = 23;
            this.cbDeviceTypeSelect.Items.AddRange(new object[] {
            "POS",
            "OfflineDevice",
            "OnlineDevice"});
            this.cbDeviceTypeSelect.Location = new System.Drawing.Point(4, 25);
            this.cbDeviceTypeSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cbDeviceTypeSelect.Name = "cbDeviceTypeSelect";
            this.cbDeviceTypeSelect.Size = new System.Drawing.Size(222, 29);
            this.cbDeviceTypeSelect.TabIndex = 0;
            this.cbDeviceTypeSelect.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(524, 4);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(112, 112);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "取消";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Highlight = true;
            this.btnConfirm.Location = new System.Drawing.Point(32, 4);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 112);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseCustomBackColor = true;
            this.btnConfirm.UseCustomForeColor = true;
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // TestConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(728, 982);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestConfigForm";
            this.Padding = new System.Windows.Forms.Padding(30, 90, 30, 30);
            this.Text = "测试配置";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestConfigForm_FormClosed);
            this.Load += new System.EventHandler(this.TestConfigForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnConfirm;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox cbDeviceTypeSelect;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox txbUnqiueNumber;
        private MetroFramework.Controls.MetroTextBox txbMacQRcode;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroComboBox cbEncoding;
        private System.Windows.Forms.GroupBox groupBox7;
        private MetroFramework.Controls.MetroTextBox tbQRPlatformUrl;
        private System.Windows.Forms.GroupBox groupBox6;
        private MetroFramework.Controls.MetroTextBox tbQRAPPIP;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroTextBox tbBackUrl;
    }
}