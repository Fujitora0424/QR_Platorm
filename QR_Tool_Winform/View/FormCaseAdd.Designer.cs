namespace QR_Tool_Winform.View
{
    partial class FormCaseAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.rtbtestName = new System.Windows.Forms.RichTextBox();
            this.rtbTextContent = new System.Windows.Forms.RichTextBox();
            this.rtbTestManaulMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbtestName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "案例号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbTextContent);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(20, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "案例内容";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtbTestManaulMessage);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(20, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 171);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "案例提示";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfirm.Location = new System.Drawing.Point(20, 436);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(272, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "提交";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // rtbtestName
            // 
            this.rtbtestName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbtestName.Location = new System.Drawing.Point(3, 17);
            this.rtbtestName.Name = "rtbtestName";
            this.rtbtestName.Size = new System.Drawing.Size(266, 30);
            this.rtbtestName.TabIndex = 0;
            this.rtbtestName.Text = "";
            // 
            // rtbTextContent
            // 
            this.rtbTextContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTextContent.Location = new System.Drawing.Point(3, 17);
            this.rtbTextContent.Name = "rtbTextContent";
            this.rtbTextContent.Size = new System.Drawing.Size(266, 135);
            this.rtbTextContent.TabIndex = 0;
            this.rtbTextContent.Text = "";
            // 
            // rtbTestManaulMessage
            // 
            this.rtbTestManaulMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTestManaulMessage.Location = new System.Drawing.Point(3, 17);
            this.rtbTestManaulMessage.Name = "rtbTestManaulMessage";
            this.rtbTestManaulMessage.Size = new System.Drawing.Size(266, 151);
            this.rtbTestManaulMessage.TabIndex = 0;
            this.rtbTestManaulMessage.Text = "";
            // 
            // FormCaseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 480);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCaseAdd";
            this.Text = "添加案例";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormCaseAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbtestName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbTextContent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbTestManaulMessage;
        private MetroFramework.Controls.MetroButton btnConfirm;
    }
}