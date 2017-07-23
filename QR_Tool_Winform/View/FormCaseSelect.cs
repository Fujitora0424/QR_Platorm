using MetroFramework;
using MetroFramework.Forms;
using QR_Tool_Winform.Global;
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
    public partial class FormCaseSelect : MetroForm
    {
        public FormCaseSelect()
        {
            InitializeComponent();
        }

        private void FormCaseSelect_Load(object sender, EventArgs e)
        {

        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
           if(cbTestCase.SelectedItem.ToString().Equals(""))
            {
                MetroMessageBox.Show(this, "未选择案例类型", "错误提示");
            }
           else
            {
                Parameters.dbTestCaseSoure = cbTestCase.SelectedItem.ToString();

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
