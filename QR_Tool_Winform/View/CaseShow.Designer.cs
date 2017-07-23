namespace QR_Tool_Winform
{
    partial class CaseShow
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
            this.ShowText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ShowText
            // 
            this.ShowText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowText.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowText.Location = new System.Drawing.Point(20, 60);
            this.ShowText.Name = "ShowText";
            this.ShowText.Size = new System.Drawing.Size(410, 323);
            this.ShowText.TabIndex = 0;
            this.ShowText.Text = "";
            this.ShowText.TextChanged += new System.EventHandler(this.ShowText_TextChanged);
            // 
            // CaseShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(450, 403);
            this.Controls.Add(this.ShowText);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Location = new System.Drawing.Point(800, 200);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(938, 634);
            this.Name = "CaseShow";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "案例说明";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CaseShow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ShowText;
    }
}