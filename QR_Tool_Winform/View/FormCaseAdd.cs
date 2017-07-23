using MetroFramework;
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
    public partial class FormCaseAdd : MetroForm
    {
        string nowTableName;
        public FormCaseAdd(string tableName)
        {
            InitializeComponent();
            nowTableName = tableName;
        }

        private void FormCaseAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(rtbTestManaulMessage.Text!=""&&rtbtestName.Text!=""&& rtbTextContent.Text!="")
            {
                Dictionary<string, object> insert_Dic = new Dictionary<string, object>();
                insert_Dic["testCaseName"] = rtbtestName.Text;
                insert_Dic["testCaseContent"] = rtbTextContent.Text;
                insert_Dic["testCaseManualMessage"] = rtbTestManaulMessage.Text;
                DataBase.Dictionary.InsertLog(insert_Dic, nowTableName);
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "数据为空");

            }
        }
    }
}
