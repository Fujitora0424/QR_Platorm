namespace QR_Tool_Winform.View
{
    partial class FormCaseContent
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtbTestCaseContent = new System.Windows.Forms.RichTextBox();
            this.rtbTestCaseManualMessage = new System.Windows.Forms.RichTextBox();
            this.btShow = new MetroFramework.Controls.MetroButton();
            this.btUpdate = new MetroFramework.Controls.MetroButton();
            this.cbTestName = new MetroFramework.Controls.MetroComboBox();
            this.btInsert = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(392, 618);
            this.splitContainer1.SplitterDistance = 514;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(392, 514);
            this.splitContainer2.SplitterDistance = 48;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer3.Size = new System.Drawing.Size(392, 462);
            this.splitContainer3.SplitterDistance = 229;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTestName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "案例编号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbTestCaseContent);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 229);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "案例描述";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtbTestCaseManualMessage);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 229);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "案例提示";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btInsert);
            this.groupBox4.Controls.Add(this.btUpdate);
            this.groupBox4.Controls.Add(this.btShow);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "控制";
            // 
            // rtbTestCaseContent
            // 
            this.rtbTestCaseContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTestCaseContent.Location = new System.Drawing.Point(3, 17);
            this.rtbTestCaseContent.Name = "rtbTestCaseContent";
            this.rtbTestCaseContent.Size = new System.Drawing.Size(386, 209);
            this.rtbTestCaseContent.TabIndex = 0;
            this.rtbTestCaseContent.Text = "";
            // 
            // rtbTestCaseManualMessage
            // 
            this.rtbTestCaseManualMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTestCaseManualMessage.Location = new System.Drawing.Point(3, 17);
            this.rtbTestCaseManualMessage.Name = "rtbTestCaseManualMessage";
            this.rtbTestCaseManualMessage.Size = new System.Drawing.Size(386, 209);
            this.rtbTestCaseManualMessage.TabIndex = 0;
            this.rtbTestCaseManualMessage.Text = "";
            // 
            // btShow
            // 
            this.btShow.Highlight = true;
            this.btShow.Location = new System.Drawing.Point(20, 29);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(75, 53);
            this.btShow.TabIndex = 0;
            this.btShow.Text = "显示";
            this.btShow.UseSelectable = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Highlight = true;
            this.btUpdate.Location = new System.Drawing.Point(145, 29);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 53);
            this.btUpdate.TabIndex = 1;
            this.btUpdate.Text = "更新";
            this.btUpdate.UseSelectable = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // cbTestName
            // 
            this.cbTestName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTestName.FormattingEnabled = true;
            this.cbTestName.ItemHeight = 23;
            this.cbTestName.Location = new System.Drawing.Point(3, 17);
            this.cbTestName.Name = "cbTestName";
            this.cbTestName.Size = new System.Drawing.Size(386, 29);
            this.cbTestName.TabIndex = 0;
            this.cbTestName.UseSelectable = true;
            this.cbTestName.SelectedIndexChanged += new System.EventHandler(this.cbTestName_SelectedIndexChanged);
            // 
            // btInsert
            // 
            this.btInsert.Highlight = true;
            this.btInsert.Location = new System.Drawing.Point(268, 29);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 53);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "添加";
            this.btInsert.UseSelectable = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // FormCaseContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 698);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormCaseContent";
            this.Text = "案例描述";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormCaseContent_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbTestCaseContent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbTestCaseManualMessage;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton btUpdate;
        private MetroFramework.Controls.MetroButton btShow;
        private MetroFramework.Controls.MetroComboBox cbTestName;
        private MetroFramework.Controls.MetroButton btInsert;
    }
}