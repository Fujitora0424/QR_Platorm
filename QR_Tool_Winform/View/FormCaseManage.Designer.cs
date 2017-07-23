namespace QR_Tool_Winform.View
{
    partial class FormCaseManage
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button生成 = new MetroFramework.Controls.MetroButton();
            this.treeView案例 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip树 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.前面添加节点toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.后面添加节点toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加子节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.修改节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.删除节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.移动节点向上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移动节点向下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.移动节点到上一层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移动节点到下一层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button保存 = new MetroFramework.Controls.MetroButton();
            this.listView案例 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip树.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1369, 653);
            this.splitContainer1.SplitterDistance = 455;
            this.splitContainer1.TabIndex = 0;
            // 
            // button生成
            // 
            this.button生成.DisplayFocus = true;
            this.button生成.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button生成.Highlight = true;
            this.button生成.Location = new System.Drawing.Point(0, 0);
            this.button生成.Name = "button生成";
            this.button生成.Size = new System.Drawing.Size(455, 109);
            this.button生成.TabIndex = 3;
            this.button生成.Text = "生成到右侧列表";
            this.button生成.UseCustomBackColor = true;
            this.button生成.UseCustomForeColor = true;
            this.button生成.UseSelectable = true;
            this.button生成.Click += new System.EventHandler(this.button生成_Click_1);
            // 
            // treeView案例
            // 
            this.treeView案例.ContextMenuStrip = this.contextMenuStrip树;
            this.treeView案例.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView案例.Location = new System.Drawing.Point(0, 0);
            this.treeView案例.Name = "treeView案例";
            this.treeView案例.Size = new System.Drawing.Size(455, 540);
            this.treeView案例.TabIndex = 4;
            this.treeView案例.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView案例_AfterSelect);
            // 
            // contextMenuStrip树
            // 
            this.contextMenuStrip树.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.前面添加节点toolStripMenuItem,
            this.后面添加节点toolStripMenuItem,
            this.添加子节点ToolStripMenuItem,
            this.toolStripSeparator1,
            this.修改节点ToolStripMenuItem,
            this.toolStripSeparator2,
            this.删除节点ToolStripMenuItem,
            this.toolStripSeparator3,
            this.移动节点向上ToolStripMenuItem,
            this.移动节点向下ToolStripMenuItem,
            this.toolStripSeparator4,
            this.移动节点到上一层ToolStripMenuItem,
            this.移动节点到下一层ToolStripMenuItem});
            this.contextMenuStrip树.Name = "contextMenuStrip树";
            this.contextMenuStrip树.Size = new System.Drawing.Size(173, 226);
            this.contextMenuStrip树.Opened += new System.EventHandler(this.contextMenuStrip树_Opened);
            // 
            // 前面添加节点toolStripMenuItem
            // 
            this.前面添加节点toolStripMenuItem.Name = "前面添加节点toolStripMenuItem";
            this.前面添加节点toolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.前面添加节点toolStripMenuItem.Text = "前面添加节点";
            this.前面添加节点toolStripMenuItem.Click += new System.EventHandler(this.前面添加节点toolStripMenuItem_Click);
            // 
            // 后面添加节点toolStripMenuItem
            // 
            this.后面添加节点toolStripMenuItem.Name = "后面添加节点toolStripMenuItem";
            this.后面添加节点toolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.后面添加节点toolStripMenuItem.Text = "后面添加节点";
            this.后面添加节点toolStripMenuItem.Click += new System.EventHandler(this.后面添加节点toolStripMenuItem_Click);
            // 
            // 添加子节点ToolStripMenuItem
            // 
            this.添加子节点ToolStripMenuItem.Name = "添加子节点ToolStripMenuItem";
            this.添加子节点ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.添加子节点ToolStripMenuItem.Text = "添加子节点";
            this.添加子节点ToolStripMenuItem.Click += new System.EventHandler(this.添加子节点ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // 修改节点ToolStripMenuItem
            // 
            this.修改节点ToolStripMenuItem.Name = "修改节点ToolStripMenuItem";
            this.修改节点ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.修改节点ToolStripMenuItem.Text = "修改节点";
            this.修改节点ToolStripMenuItem.Click += new System.EventHandler(this.修改节点ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // 删除节点ToolStripMenuItem
            // 
            this.删除节点ToolStripMenuItem.Name = "删除节点ToolStripMenuItem";
            this.删除节点ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.删除节点ToolStripMenuItem.Text = "删除节点";
            this.删除节点ToolStripMenuItem.Click += new System.EventHandler(this.删除节点ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // 移动节点向上ToolStripMenuItem
            // 
            this.移动节点向上ToolStripMenuItem.Name = "移动节点向上ToolStripMenuItem";
            this.移动节点向上ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.移动节点向上ToolStripMenuItem.Text = "移动节点向上";
            this.移动节点向上ToolStripMenuItem.Click += new System.EventHandler(this.移动节点向上ToolStripMenuItem_Click);
            // 
            // 移动节点向下ToolStripMenuItem
            // 
            this.移动节点向下ToolStripMenuItem.Name = "移动节点向下ToolStripMenuItem";
            this.移动节点向下ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.移动节点向下ToolStripMenuItem.Text = "移动节点向下";
            this.移动节点向下ToolStripMenuItem.Click += new System.EventHandler(this.移动节点向下ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(169, 6);
            // 
            // 移动节点到上一层ToolStripMenuItem
            // 
            this.移动节点到上一层ToolStripMenuItem.Name = "移动节点到上一层ToolStripMenuItem";
            this.移动节点到上一层ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.移动节点到上一层ToolStripMenuItem.Text = "移动节点到上一层";
            this.移动节点到上一层ToolStripMenuItem.Click += new System.EventHandler(this.移动节点到上一层ToolStripMenuItem_Click);
            // 
            // 移动节点到下一层ToolStripMenuItem
            // 
            this.移动节点到下一层ToolStripMenuItem.Name = "移动节点到下一层ToolStripMenuItem";
            this.移动节点到下一层ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.移动节点到下一层ToolStripMenuItem.Text = "移动节点到下一层";
            // 
            // button保存
            // 
            this.button保存.DisplayFocus = true;
            this.button保存.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button保存.Highlight = true;
            this.button保存.Location = new System.Drawing.Point(0, 0);
            this.button保存.Name = "button保存";
            this.button保存.Size = new System.Drawing.Size(910, 108);
            this.button保存.TabIndex = 2;
            this.button保存.Text = "保存到数据库";
            this.button保存.UseCustomBackColor = true;
            this.button保存.UseCustomForeColor = true;
            this.button保存.UseSelectable = true;
            this.button保存.Click += new System.EventHandler(this.button保存_Click);
            // 
            // listView案例
            // 
            this.listView案例.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView案例.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView案例.FullRowSelect = true;
            this.listView案例.GridLines = true;
            this.listView案例.Location = new System.Drawing.Point(0, 0);
            this.listView案例.Name = "listView案例";
            this.listView案例.Size = new System.Drawing.Size(910, 541);
            this.listView案例.TabIndex = 3;
            this.listView案例.UseCompatibleStateImageBehavior = false;
            this.listView案例.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ParentID";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DisplayOrder";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NodeText";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Character";
            this.columnHeader5.Width = 100;
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
            this.splitContainer2.Panel1.Controls.Add(this.treeView案例);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button生成);
            this.splitContainer2.Size = new System.Drawing.Size(455, 653);
            this.splitContainer2.SplitterDistance = 540;
            this.splitContainer2.TabIndex = 5;
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
            this.splitContainer3.Panel1.Controls.Add(this.listView案例);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.button保存);
            this.splitContainer3.Size = new System.Drawing.Size(910, 653);
            this.splitContainer3.SplitterDistance = 541;
            this.splitContainer3.TabIndex = 4;
            // 
            // FormCaseManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 733);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormCaseManage";
            this.Text = "案例列表生成";
            this.Load += new System.EventHandler(this.FormCaseManage2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip树.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton button生成;
        private System.Windows.Forms.TreeView treeView案例;
        private MetroFramework.Controls.MetroContextMenu contextMenuStrip树;
        private System.Windows.Forms.ToolStripMenuItem 前面添加节点toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 后面添加节点toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加子节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 修改节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 删除节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 移动节点向上ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移动节点向下ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 移动节点到上一层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移动节点到下一层ToolStripMenuItem;
        private MetroFramework.Controls.MetroButton button保存;
        private System.Windows.Forms.ListView listView案例;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}