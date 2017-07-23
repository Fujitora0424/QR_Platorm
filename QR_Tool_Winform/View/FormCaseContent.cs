using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Tool_Winform.View
{
    public partial class FormCaseContent : MetroForm
    {
        DataTable nowDataTable;
        string nowDataTableName;
        public FormCaseContent(string dataTableName)
        {
            InitializeComponent();
            nowDataTableName = dataTableName;
            updateView();

        }

        private void FormCaseContent_Load(object sender, EventArgs e)
        {

        }

        private void cbTestName_SelectedIndexChanged(object sender, EventArgs e)
        {

            rtbTestCaseContent.Clear();
            rtbTestCaseManualMessage.Clear();
            string testName = cbTestName.SelectedItem.ToString();
            rtbTestCaseContent.Text = GetContent(testName, "testCaseContent");
            rtbTestCaseManualMessage.Text = GetContent(testName, "testCaseManualMessage");
        }
       
        private string GetContent(string TestName,string contentName)
        {
            var testCaseContent = "";
            string sql = String.Format("testCaseName = '{0}'", TestName);
            try
            {
                testCaseContent = (string)nowDataTable.Select(sql)[0][contentName];
            }
            catch
            {
                testCaseContent = "不存在";
            }
            return testCaseContent;

        }

        private void btShow_Click(object sender, EventArgs e)
        {
            updateView();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> updata_Dic = new Dictionary<string, object>();
            updata_Dic["testCaseName"] = cbTestName.SelectedItem.ToString();
            updata_Dic["testCaseContent"] = rtbTestCaseContent.Text;
            updata_Dic["testCaseManualMessage"] = rtbTestCaseManualMessage.Text;

            DataBase.Dictionary.UpdateLog(updata_Dic, nowDataTableName);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            FormCaseAdd fca = new FormCaseAdd(nowDataTableName);
            fca.Show();
        }

        private void updateView()
        {
            cbTestName.Items.Clear();
            List<string> listTestName = new List<string>();
            nowDataTable = DataBase.Dictionary.GetDictionaryTable(nowDataTableName);
            foreach (DataRow dr in nowDataTable.Rows)
            {
                listTestName.Add(dr["testCaseName"].ToString());
            }
            listTestName.Sort();
            foreach (string s in listTestName)
            {
                cbTestName.Items.Add(s);
            }

        }
    }
}
