namespace QR_Tool_Winform.View
{
    partial class FormCaseItem
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
            this.button确定 = new MetroFramework.Controls.MetroButton();
            this.comboBox特征 = new System.Windows.Forms.ComboBox();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.textBox节点名称 = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // button确定
            // 
            this.button确定.Highlight = true;
            this.button确定.Location = new System.Drawing.Point(68, 152);
            this.button确定.Name = "button确定";
            this.button确定.Size = new System.Drawing.Size(157, 50);
            this.button确定.TabIndex = 5;
            this.button确定.Text = "确定";
            this.button确定.UseCustomBackColor = true;
            this.button确定.UseCustomForeColor = true;
            this.button确定.UseSelectable = true;
            this.button确定.Click += new System.EventHandler(this.button确定_Click);
            // 
            // comboBox特征
            // 
            this.comboBox特征.AllowDrop = true;
            this.comboBox特征.FormattingEnabled = true;
            this.comboBox特征.ItemHeight = 23;
            this.comboBox特征.Items.AddRange(new object[] {
            "Node"});
            this.comboBox特征.Location = new System.Drawing.Point(127, 100);
            this.comboBox特征.Name = "comboBox特征";
            this.comboBox特征.Size = new System.Drawing.Size(126, 29);
            this.comboBox特征.TabIndex = 6;
            this.comboBox特征.SelectedIndexChanged += new System.EventHandler(this.comboBox特征_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "节点特征";
            // 
            // textBox节点名称
            // 
            this.textBox节点名称.Lines = new string[0];
            this.textBox节点名称.Location = new System.Drawing.Point(127, 40);
            this.textBox节点名称.MaxLength = 32767;
            this.textBox节点名称.Name = "textBox节点名称";
            this.textBox节点名称.PasswordChar = '\0';
            this.textBox节点名称.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox节点名称.SelectedText = "";
            this.textBox节点名称.Size = new System.Drawing.Size(126, 21);
            this.textBox节点名称.TabIndex = 8;
            this.textBox节点名称.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "节点名称";
            // 
            // FormCaseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 223);
            this.Controls.Add(this.button确定);
            this.Controls.Add(this.comboBox特征);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox节点名称);
            this.Controls.Add(this.label1);
            this.DisplayHeader = false;
            this.Name = "FormCaseItem";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCaseItem";
            this.Load += new System.EventHandler(this.FormCaseItem_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCaseItem_MouseDown);
            this.MouseLeave += new System.EventHandler(this.FormCaseItem_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormCaseItem_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormCaseItem_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton button确定;
        private System.Windows.Forms.ComboBox comboBox特征;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroTextBox textBox节点名称;
        private MetroFramework.Controls.MetroLabel label1;
    }
}