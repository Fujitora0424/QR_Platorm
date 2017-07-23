using System.Windows.Forms;

namespace QR_Tool_Winform.View
{
    partial class FormCaseSelect
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
            this.cbTestCase = new MetroFramework.Controls.MetroComboBox();
            this.btConfirm = new MetroFramework.Controls.MetroButton();
            this.btCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cbTestCase
            // 
            this.cbTestCase.FormattingEnabled = true;
            this.cbTestCase.ItemHeight = 23;
            this.cbTestCase.Items.AddRange(new object[] {
            "POSTestCase",
            "OfflineDeviceTestCase",
            "OnlineDeviceTestCase"});
            this.cbTestCase.Location = new System.Drawing.Point(46, 134);
            this.cbTestCase.Name = "cbTestCase";
            this.cbTestCase.Size = new System.Drawing.Size(329, 29);
            this.cbTestCase.TabIndex = 0;
            this.cbTestCase.UseSelectable = true;
            // 
            // btConfirm
            // 
            this.btConfirm.Highlight = true;
            this.btConfirm.Location = new System.Drawing.Point(46, 230);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(112, 37);
            this.btConfirm.Style = MetroFramework.MetroColorStyle.Blue;
            this.btConfirm.TabIndex = 1;
            this.btConfirm.Text = "确定";
            this.btConfirm.UseCustomBackColor = true;
            this.btConfirm.UseCustomForeColor = true;
            this.btConfirm.UseSelectable = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Highlight = true;
            this.btCancel.Location = new System.Drawing.Point(263, 230);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(112, 37);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "取消";
            this.btCancel.UseCustomBackColor = true;
            this.btCancel.UseCustomForeColor = true;
            this.btCancel.UseSelectable = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FormCaseSelect
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(419, 341);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.cbTestCase);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCaseSelect";
            this.Text = "更新案例类型";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormCaseSelect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbTestCase;
        private MetroFramework.Controls.MetroButton btConfirm;
        private MetroFramework.Controls.MetroButton btCancel;
    }
}