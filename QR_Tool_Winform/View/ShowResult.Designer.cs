namespace QR_Tool_Winform.View
{
    partial class ShowResult
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
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.plResult = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Red;
            this.btnConfirm.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnConfirm.Highlight = true;
            this.btnConfirm.Location = new System.Drawing.Point(29, 295);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(329, 61);
            this.btnConfirm.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseCustomBackColor = true;
            this.btnConfirm.UseCustomForeColor = true;
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnPASS_Click);
            // 
            // plResult
            // 
            this.plResult.AutoScroll = true;
            this.plResult.HorizontalScrollbar = true;
            this.plResult.HorizontalScrollbarBarColor = true;
            this.plResult.HorizontalScrollbarHighlightOnWheel = false;
            this.plResult.HorizontalScrollbarSize = 10;
            this.plResult.Location = new System.Drawing.Point(29, 72);
            this.plResult.Name = "plResult";
            this.plResult.Padding = new System.Windows.Forms.Padding(10);
            this.plResult.Size = new System.Drawing.Size(328, 217);
            this.plResult.TabIndex = 4;
            this.plResult.VerticalScrollbar = true;
            this.plResult.VerticalScrollbarBarColor = true;
            this.plResult.VerticalScrollbarHighlightOnWheel = false;
            this.plResult.VerticalScrollbarSize = 10;
            this.plResult.Paint += new System.Windows.Forms.PaintEventHandler(this.plResult_Paint);
            // 
            // ShowResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 390);
            this.Controls.Add(this.plResult);
            this.Controls.Add(this.btnConfirm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowResult";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Text = "人工判断";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowResult_FormClosing);
            this.Load += new System.EventHandler(this.ShowResultcs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnConfirm;
        private MetroFramework.Controls.MetroPanel plResult;
    }
}