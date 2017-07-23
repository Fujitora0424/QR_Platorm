namespace QR_Tool_Winform
{
    partial class Project
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ProjectConfirm = new MetroFramework.Controls.MetroButton();
            this.ProjectCancel = new MetroFramework.Controls.MetroButton();
            this.FilePosition = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.FindFile = new MetroFramework.Controls.MetroButton();
            this.FindFilePosition = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(888, 390);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Project);
            // 
            // ProjectConfirm
            // 
            this.ProjectConfirm.Location = new System.Drawing.Point(757, 488);
            this.ProjectConfirm.Name = "ProjectConfirm";
            this.ProjectConfirm.Size = new System.Drawing.Size(67, 27);
            this.ProjectConfirm.TabIndex = 1;
            this.ProjectConfirm.Text = "新建";
            this.ProjectConfirm.UseSelectable = true;
            this.ProjectConfirm.Click += new System.EventHandler(this.ProjectConfirm_Click);
            // 
            // ProjectCancel
            // 
            this.ProjectCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ProjectCancel.Location = new System.Drawing.Point(844, 488);
            this.ProjectCancel.Name = "ProjectCancel";
            this.ProjectCancel.Size = new System.Drawing.Size(67, 27);
            this.ProjectCancel.TabIndex = 2;
            this.ProjectCancel.Text = "取消";
            this.ProjectCancel.UseSelectable = true;
            this.ProjectCancel.Click += new System.EventHandler(this.ProjectCancel_Click);
            // 
            // FilePosition
            // 
            this.FilePosition.Lines = new string[0];
            this.FilePosition.Location = new System.Drawing.Point(161, 488);
            this.FilePosition.MaxLength = 32767;
            this.FilePosition.Name = "FilePosition";
            this.FilePosition.PasswordChar = '\0';
            this.FilePosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FilePosition.SelectedText = "";
            this.FilePosition.Size = new System.Drawing.Size(479, 21);
            this.FilePosition.TabIndex = 3;
            this.FilePosition.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "测试LOG存储位置：";
            // 
            // FindFile
            // 
            this.FindFile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FindFile.Location = new System.Drawing.Point(665, 488);
            this.FindFile.Name = "FindFile";
            this.FindFile.Size = new System.Drawing.Size(67, 27);
            this.FindFile.TabIndex = 5;
            this.FindFile.Text = "浏览...";
            this.FindFile.UseSelectable = true;
            this.FindFile.Click += new System.EventHandler(this.FindFile_Click);
            // 
            // Project
            // 
            this.AcceptButton = this.ProjectConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CancelButton = this.ProjectCancel;
            this.ClientSize = new System.Drawing.Size(952, 531);
            this.Controls.Add(this.FindFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilePosition);
            this.Controls.Add(this.ProjectCancel);
            this.Controls.Add(this.ProjectConfirm);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Project";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "请选择流程单";
            this.Load += new System.EventHandler(this.Project_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private MetroFramework.Controls.MetroButton ProjectConfirm;
        private MetroFramework.Controls.MetroButton ProjectCancel;
        private MetroFramework.Controls.MetroTextBox FilePosition;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroButton FindFile;
        private System.Windows.Forms.FolderBrowserDialog FindFilePosition;
    }
}

