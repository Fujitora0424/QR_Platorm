using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Forms;

namespace QR_Tool_Winform
{

    public partial class Project : MetroForm
    {
        public static String ProjectName = "银行卡检测中心";
        public static String ProjectPath = Application.StartupPath + "\\" + "Log";
        public MainWindow mw;
        public static DataSet dst = null;
        public static int select()
        {
            try
            {
                string[] strFormNum = new string[1] { "TDBG" };
                CDBControl dbcontrol = new CDBControl();
                dbcontrol.Sql = "SELECT FormNum, Project, Vendor, Product FROM dbo.V_TestWorkSearch where ((FormNum LIKE '%" + strFormNum[0] + "%'or FormNum LIKE '%" + strFormNum[1] + "%')AND (Status = '测试中'))";
                dbcontrol.readerData();
                dbcontrol.clear();
                dbcontrol.dataView();
                dst = dbcontrol.ds;
                return dbcontrol.ds.Tables[0].Rows.Count;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;

            }
        }


       
        public static string get(int row, int colunm)
        {
            DataView dvs = new DataView(dst.Tables[0]);
            dvs.Sort = "FormNum asc";
            DataTable dtb = dvs.ToTable();
            return dtb.Rows[row][colunm].ToString();
        }

       

        public Project()
        {
            InitializeComponent();
        }

        private void Project_Load(object sender, EventArgs e)
        {
            //显示待测流程单信息
            listView1.Columns.Add("序号");
            listView1.Columns.Add("流程单号", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("项目名称", 350, HorizontalAlignment.Left);
            listView1.Columns.Add("厂商名称", 300, HorizontalAlignment.Left);
            listView1.Columns.Add("产品型号", 100, HorizontalAlignment.Left);
            int num = select();
            for (int i = 1; i <= num; i++)
            {
                ListViewItem item1 = new ListViewItem();
                string sb1;
                sb1 = get(i - 1, 0);
                item1.Text = i.ToString();
                item1.SubItems.Add(sb1.ToString());
                sb1 = get(i - 1, 1);
                item1.SubItems.Add(sb1.ToString());
                sb1 = get(i - 1, 2);
                item1.SubItems.Add(sb1.ToString());
                sb1 = get(i - 1, 3);
                item1.SubItems.Add(sb1.ToString());
                listView1.Items.Add(item1);
            }
        }

        private void Select_Project(object sender, MouseEventArgs e)//获得新建工程名称/LOG文件夹名称
        {
            ProjectName = listView1.SelectedItems[0].SubItems[1].Text.Trim()
                + "_" + listView1.SelectedItems[0].SubItems[3].Text.Trim()
                + "_" + listView1.SelectedItems[0].SubItems[4].Text.Trim()
                + "_" + DateTime.Now.Year.ToString("D4")
                + "-" + DateTime.Now.Month.ToString("D2")
                + "-" + DateTime.Now.Day.ToString("D2")
                + "-" + DateTime.Now.Hour.ToString("D2")
                + "-" + DateTime.Now.Minute.ToString("D2")
                + "-" + DateTime.Now.Second.ToString("D2");
            if (ProjectPath != "")
            {
                FilePosition.Text = ProjectPath + "\\" + ProjectName;
            }
            else
            {
                FilePosition.Text = ProjectName;
            }
        }

        private void ProjectCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ProjectConfirm_Click(object sender, EventArgs e)
        {
            if (ProjectPath.Trim() != "" && ProjectName.Trim() != "")
            {
                Directory.CreateDirectory(ProjectPath.Trim() + "\\" + ProjectName.Trim());
                StreamWriter sw = new StreamWriter(ProjectPath.Trim() + "\\" + ProjectName.Trim() + "\\ProjectTestConfig.json");
                Global.ResultConfig rc = new Global.ResultConfig();
                rc.projectName = ProjectName.Trim();
                string str =  JsonHelper.SerializeObject(rc);
                //String str = "##ProjectName=" + ProjectName.Trim() + "\r\n";
                sw.Write(str);
                sw.Close();
                mw.SetProjectState(ProjectName);
                this.Close();
            }
            else
            {
                MessageBox.Show("存储路径错误，请检查后点击新建按钮");
                 mw.SetProjectState("未加载");
            }
        }

        private void FindFile_Click(object sender, EventArgs e)
        {
            FindFilePosition.RootFolder = Environment.SpecialFolder.Desktop;
            if (FindFilePosition.ShowDialog() == DialogResult.OK)
            {
                ProjectPath = FindFilePosition.SelectedPath;
                FilePosition.Text = ProjectPath + "\\" + ProjectName;
            }
        }

    }
}