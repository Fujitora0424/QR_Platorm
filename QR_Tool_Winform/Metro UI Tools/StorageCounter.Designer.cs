namespace QR_Tool_Winform.Metro_UI_Tools
{
    partial class StorageCounter
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.countbutton = new System.Windows.Forms.Button();
            this.counttextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // countbutton
            // 
            this.countbutton.Location = new System.Drawing.Point(223, 28);
            this.countbutton.Name = "countbutton";
            this.countbutton.Size = new System.Drawing.Size(75, 23);
            this.countbutton.TabIndex = 0;
            this.countbutton.Text = "确定";
            this.countbutton.UseVisualStyleBackColor = true;
            this.countbutton.Click += new System.EventHandler(this.countbutton_Click);
            // 
            // counttextBox
            // 
            this.counttextBox.Location = new System.Drawing.Point(68, 30);
            this.counttextBox.Name = "counttextBox";
            this.counttextBox.Size = new System.Drawing.Size(100, 21);
            this.counttextBox.TabIndex = 1;
            // 
            // StorageCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(345, 81);
            this.Controls.Add(this.counttextBox);
            this.Controls.Add(this.countbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StorageCounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请输入之前的交易序号";
            this.Load += new System.EventHandler(this.StorageCounter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button countbutton;
        private System.Windows.Forms.TextBox counttextBox;
    }
}