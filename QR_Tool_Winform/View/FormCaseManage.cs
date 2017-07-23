using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Tool_Winform.View
{
    public partial class FormCaseManage : MetroForm
    {
        //private OleDbConnection DBConnection = new OleDbConnection();   //添加树状控件需要的三个变量
        //private OleDbCommand DBCommand = new OleDbCommand();
        private DataTable dtCaseBase = new DataTable();
        private string Database = null;

        private enum CONTEXTMENU { 前面添加节点 = 0, 后面添加节点, 添加子节点, 修改节点 = 4, 删除节点 = 6, 移动节点向上 = 8, 移动节点向下, 移动节点到上一层 = 11, 移动节点到下一层 };

        private int CurrentID = 0;

      

        public FormCaseManage(string database)
        {
            InitializeComponent();
            Database = database;
            this.AddCaseFromDatabase(database);

            this.DisableItems();
        }

        private void DisableItems()
        {
            for (int i = 0; i < this.contextMenuStrip树.Items.Count; i++)
            {
                this.contextMenuStrip树.Items[i].Enabled = false;
            }
            this.contextMenuStrip树.Items[2].Enabled = true;//添加子节点功能任意时候打开        
        }

        private void AddCaseFromDatabase(string database)//从数据库读取案例写到树状控件里,并且用数组记录
        {
            try
            {
                //    this.DBConnection.ConnectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0};", database);
                //    this.DBConnection.Open();

                //    DataSet dsCaseBase = new DataSet();
                //    OleDbDataAdapter OdbAdapter = new OleDbDataAdapter(("SELECT ID,ParentID,DisplayOrder,NodeText,[Character] FROM AllCase Order by DisplayOrder"), DBConnection);
                //    OdbAdapter.Fill(dsCaseBase);
                this.dtCaseBase = DataBase.TestCaseDataBase.GetTestCase(database);
            
            
      

            this.treeView案例.Nodes.Clear();
            this.BuildTree(this.treeView案例.Nodes, 0);
    }

            catch (Exception ee)
            {
              MessageBox.Show(ee.ToString());
              Environment.Exit(0);
           }
        }

        private void BuildTree(TreeNodeCollection fnode, int intParentID)//通过递归辅助完成上一函数
        {
            try
            {
                foreach (DataRow row in dtCaseBase.Select(String.Format("ParentID = {0}", intParentID)))
                {

                    TreeNode Tnnode = new TreeNode();
                    Tnnode.Text = row["NodeText"].ToString() + '【' + row["Character"].ToString() + '】';
                    Tnnode.Tag = row;
                    this.BuildTree(Tnnode.Nodes, Convert.ToInt32(row["ID"]));
                    fnode.Add(Tnnode);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void dropItem_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode movingNode = this.treeView案例.SelectedNode;//要移动的那个节点
                TreeNode currentNode;
                if (this.treeView案例.SelectedNode.Parent == null)
                {
                    currentNode = this.treeView案例.Nodes[0];
                }
                else
                {
                    currentNode = this.treeView案例.SelectedNode.Parent.FirstNode;
                }
                do
                {
                    if (currentNode.Text == ((ToolStripItem)sender).Text)
                    {
                        this.treeView案例.SelectedNode.Remove();
                        currentNode.Nodes.Add(movingNode);
                        break;
                    }

                    currentNode = currentNode.NextNode;
                } while (currentNode != null);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

  

     
     


    
    



  

        private void 添加节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCaseItem formCaseItem = new FormCaseItem();

            if (formCaseItem.ShowDialog() == DialogResult.OK)
            {
                this.treeView案例.Nodes.Add(string.Format("{0}【{1}】", formCaseItem.CaseName, formCaseItem.Character));

                this.treeView案例.Update();
            }
        }

     
  

        private bool CheckNodesTypeOK(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Nodes.Count > 0 && node.Text.IndexOf("【Node】") < 0)
                {
                    MessageBox.Show(string.Format("节点{0}有至少一个子节点，但是特征类型不是【Node】。请修改。", node.Text), "提示");
                    return false;
                }
                if (node.Nodes.Count == 0 && node.Text.IndexOf("【Node】") >= 0)
                {
                    MessageBox.Show(string.Format("节点{0}没有子节点，但是特征类型是【Node】。\n\n平台目前允许空节点。", node.Text), "提示");
                    //return false;
                }

                if (node.Nodes.Count > 0)
                {
                    if (this.CheckNodesTypeOK(node.Nodes) == false)
                        return false;
                }
            }
            return true;
        }

        private void BuildTable(int parentID, TreeNodeCollection nodes)
        {
            int displayOrder = 0;
            int[] fatherID = new int[nodes.Count];
            ListViewItem item = new ListViewItem();

            for (int i = 0; i < nodes.Count; i++)
            {
                int index左中括号 = nodes[i].Text.IndexOf('【');
                item = new ListViewItem((++this.CurrentID).ToString());
                item.SubItems.Add(parentID.ToString());
                item.SubItems.Add((++displayOrder).ToString());
                item.SubItems.Add(nodes[i].Text.Substring(0, index左中括号));
                item.SubItems.Add(nodes[i].Text.Substring(index左中括号 + 1, nodes[i].Text.Length - index左中括号 - 2));

                this.listView案例.Items.Add(item);

                fatherID[i] = this.CurrentID;
            }

            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].Nodes.Count > 0)
                {
                    this.BuildTable(fatherID[i], nodes[i].Nodes);
                }
            }
        }

        private void treeView案例_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (this.treeView案例.SelectedNode.Text.IndexOf("【Node】") < 0)
            {
                this.修改节点ToolStripMenuItem_Click(null, null);
            }
        }

        private void contextMenuStrip树_Opened(object sender, EventArgs e)
        {
            if (this.treeView案例.SelectedNode == null)
            {
                this.DisableItems();
                return;
            }

            for (int i = 0; i < this.contextMenuStrip树.Items.Count; i++)
            {
                this.contextMenuStrip树.Items[i].Enabled = true;
            }
            if (this.treeView案例.SelectedNode.Parent == null)
            {
                this.contextMenuStrip树.Items[(int)CONTEXTMENU.移动节点到上一层].Enabled = false;
            }
            if (this.treeView案例.SelectedNode.Index == 0)
            {
                this.contextMenuStrip树.Items[(int)CONTEXTMENU.移动节点向上].Enabled = false;
            }
            if (this.treeView案例.SelectedNode.Parent == null)
            {
                if (this.treeView案例.Nodes.Count < 2)
                {
                    this.contextMenuStrip树.Items[(int)CONTEXTMENU.移动节点到下一层].Enabled = false;
                }
                if (this.treeView案例.SelectedNode.Index == this.treeView案例.Nodes.Count - 1)
                {
                    this.contextMenuStrip树.Items[(int)CONTEXTMENU.移动节点向下].Enabled = false;
                }
            }
            else
            {
                if (this.treeView案例.SelectedNode.Parent.Nodes.Count < 2)
                {
                    this.contextMenuStrip树.Items[(int)CONTEXTMENU.移动节点到下一层].Enabled = false;
                }
                if (this.treeView案例.SelectedNode.Index == this.treeView案例.SelectedNode.Parent.Nodes.Count - 1)
                {
                    this.contextMenuStrip树.Items[(int)CONTEXTMENU.移动节点向下].Enabled = false;
                }
            }

            if (this.contextMenuStrip树.Items[(int)CONTEXTMENU.移动节点到下一层].Enabled == true)
            {
                ToolStripMenuItem item = this.移动节点到下一层ToolStripMenuItem;
                item.DropDownItems.Clear();

                if (this.treeView案例.SelectedNode.Parent == null)
                {
                    for (int i = 0; i < this.treeView案例.Nodes.Count; i++)
                    {
                        if (i != this.treeView案例.SelectedNode.Index)
                        {
                            item.DropDownItems.Add(this.treeView案例.Nodes[i].Text);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < this.treeView案例.SelectedNode.Parent.Nodes.Count; i++)
                    {
                        if (i != this.treeView案例.SelectedNode.Index)
                        {
                            item.DropDownItems.Add(this.treeView案例.SelectedNode.Parent.Nodes[i].Text);
                        }
                    }
                }

                foreach (ToolStripItem dropItem in item.DropDownItems)
                {
                    dropItem.Click += new EventHandler(dropItem_Click);
                }
                this.contextMenuStrip树.Items.Add(item);
            }
        }

        private void treeView案例_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.treeView案例.SelectedNode = e.Node;
        }

        private void FormCaseManage2_Load(object sender, EventArgs e)
        {

        }

        private void button生成_Click_1(object sender, EventArgs e)
        {
            if (this.CheckNodesTypeOK(this.treeView案例.Nodes) == true)
            {
                this.CurrentID = 0;
                this.listView案例.Items.Clear();

                this.BuildTable(0, this.treeView案例.Nodes);
            }
        }

        private void 前面添加节点toolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCaseItem formCaseItem = new FormCaseItem();

            if (formCaseItem.ShowDialog() == DialogResult.OK)
            {
                if (this.treeView案例.SelectedNode.Parent == null)
                {
                    this.treeView案例.Nodes.Insert(this.treeView案例.SelectedNode.Index, string.Format("{0}【{1}】", formCaseItem.CaseName, formCaseItem.Character));
                }
                else
                {
                    this.treeView案例.SelectedNode.Parent.Nodes.Insert(this.treeView案例.SelectedNode.Index, string.Format("{0}【{1}】", formCaseItem.CaseName, formCaseItem.Character));
                }
            }
        }

        private void 后面添加节点toolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCaseItem formCaseItem = new FormCaseItem();

            if (formCaseItem.ShowDialog() == DialogResult.OK)
            {
                if (this.treeView案例.SelectedNode.Parent == null)
                {
                    this.treeView案例.Nodes.Insert(this.treeView案例.SelectedNode.Index + 1, string.Format("{0}【{1}】", formCaseItem.CaseName, formCaseItem.Character));
                }
                else
                {
                    this.treeView案例.SelectedNode.Parent.Nodes.Insert(this.treeView案例.SelectedNode.Index + 1, string.Format("{0}【{1}】", formCaseItem.CaseName, formCaseItem.Character));
                }
            }
        }

        private void 添加子节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCaseItem formCaseItem = new FormCaseItem();

            if (formCaseItem.ShowDialog() == DialogResult.OK)
            {
                if (this.treeView案例.SelectedNode == null)
                {
                    this.treeView案例.Nodes.Add(string.Format("{0}【{1}】", formCaseItem.CaseName, formCaseItem.Character));
                }
                else
                {
                    this.treeView案例.SelectedNode.Nodes.Add(string.Format("{0}【{1}】", formCaseItem.CaseName, formCaseItem.Character));
                }

                this.treeView案例.Update();
            }
        }

        private void 修改节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeView案例.SelectedNode == null)
            {
                return;
            }

            int last左括号 = this.treeView案例.SelectedNode.Text.LastIndexOf('【');
            string caseName = this.treeView案例.SelectedNode.Text.Substring(0, last左括号);
            string character = this.treeView案例.SelectedNode.Text.Substring(last左括号 + 1, this.treeView案例.SelectedNode.Text.Length - last左括号 - 2);

            FormCaseItem formCaseItem = new FormCaseItem(caseName, character);

            if (formCaseItem.ShowDialog() == DialogResult.OK)
            {
                this.treeView案例.SelectedNode.Text = string.Format("{0}【{1}】", formCaseItem.CaseName, formCaseItem.Character);

                this.treeView案例.Update();
            }
        }

        private void 删除节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeView案例.SelectedNode == null)
            {
                return;
            }

            if (MessageBox.Show("确定要删除该节点及其所有子节点？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.treeView案例.SelectedNode.Remove();

                this.treeView案例.Update();


                if (this.treeView案例.SelectedNode == null)
                {
                    this.DisableItems();
                }
            }
        }

        private void 移动节点向上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeView案例.SelectedNode == null)
            {
                return;
            }

            int currentNodeIndex = this.treeView案例.SelectedNode.Index;
            TreeNode currentNode = this.treeView案例.SelectedNode;
            TreeNode parent = this.treeView案例.SelectedNode.Parent;
            this.treeView案例.SelectedNode.Remove();
            if (parent == null)
            {
                treeView案例.Nodes.Insert(Math.Max(currentNodeIndex - 1, 0), currentNode);
            }
            else
            {
                parent.Nodes.Insert(Math.Max(currentNodeIndex - 1, 0), currentNode);
            }

        }

        private void 移动节点向下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeView案例.SelectedNode == null)
            {
                return;
            }

            int currentNodeIndex = this.treeView案例.SelectedNode.Index;
            TreeNode currentNode = this.treeView案例.SelectedNode;
            TreeNode parent = this.treeView案例.SelectedNode.Parent;
            this.treeView案例.SelectedNode.Remove();
            if (parent == null)
            {
                treeView案例.Nodes.Insert(Math.Min(currentNodeIndex + 1, this.treeView案例.Nodes.Count), currentNode);
            }
            else
            {
                parent.Nodes.Insert(Math.Min(currentNodeIndex + 1, parent.Nodes.Count), currentNode);
            }
        }

        private void 移动节点到上一层ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.treeView案例.SelectedNode == null)
            {
                return;
            }

            TreeNode currentNode = this.treeView案例.SelectedNode;
            TreeNode parent = this.treeView案例.SelectedNode.Parent;
            this.treeView案例.SelectedNode.Remove();

            if (parent.Parent == null)
            {
                this.treeView案例.Nodes.Add(currentNode);
            }
            else
            {
                parent.Parent.Nodes.Add(currentNode);
            }
        }

        private void button保存_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this,"确定把这些项替换数据库里的内容？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {

                using (SQLiteConnection conn = new SQLiteConnection("data source=" + Application.StartupPath + @"\DataBase\TestCase.db"))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        SQLiteHelper sh = new SQLiteHelper(cmd);
                        sh.BeginTransaction();
                        try
                        {
                            string sql_update = string.Format("Update {0} Set Deleting = 1", Database);
                            sh.Execute(sql_update);
             

                            sh.Commit();
                        }
                        catch
                        {
                            sh.Rollback();
                        }

                        foreach (ListViewItem item in this.listView案例.Items)
                        {
                            string sql = string.Format("Insert Into "+ Database + " (ID, ParentID, DisplayOrder, NodeText, [Character], Deleting) Values ({0},{1},{2},'{3}','{4}',0)",
                                int.Parse(item.SubItems[0].Text),
                                int.Parse(item.SubItems[1].Text),
                                int.Parse(item.SubItems[2].Text),
                                 item.SubItems[3].Text,
                                 item.SubItems[4].Text);
                            sh.Execute(sql);
                        }
                        string sql_delete = string.Format("delete from {0} where Deleting = 1", Database);
                        sh.Execute(sql_delete);
                        conn.Close();
                    }
                }
             

                MetroMessageBox.Show(this,"写入成功！");

            }
        }

        private void treeView案例_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
