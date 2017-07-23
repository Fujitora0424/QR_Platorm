using MetroFramework.Controls;
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
    public partial class ShowResult :  MetroForm
    {
        string sresult ;
        string[] messageList = null;
        public ShowResult(string message)
        {
            InitializeComponent();
            sresult = "";
            messageList = message.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i<messageList.Length;i++)
            {
             
                MetroLabel ml= new MetroLabel();
                MetroComboBox mcb = new MetroComboBox();
                ml.Style = MetroFramework.MetroColorStyle.Blue;
                ml.Text = messageList[i];
                mcb.Items.Add("正确");
                mcb.Items.Add("错误");
                mcb.SelectedIndex = 0;
                ml.AutoSize = true;
                ml.Dock = DockStyle.Top;
                mcb.Dock = DockStyle.Top;
                plResult.Controls.Add(ml);
                plResult.Controls.Add(mcb);
                ml.BringToFront();
                mcb.BringToFront();
            }
        }

        public string GetResultMessage()
        {
            return sresult;
        }
        private void ShowResultcs_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPASS_Click(object sender, EventArgs e)
        {
            List<string> relist = new List<string>();
            foreach (Control c in plResult.Controls)
            {
                if (c is MetroComboBox)
                {
                    string re= (c as MetroComboBox).SelectedItem.ToString();
                    relist.Add(re);
                }
            }

            if (relist.Contains("错误"))
            {
                for(int i =0;i<relist.Count;i++)
                {

                    if(relist[i].Equals("错误"))
                    {

                        sresult += messageList[i] + ",人工判断错误" + "\r\n";

                    }


                }


                
            }
            this.Close();
          
          
        }

        private void btnFail_Click(object sender, EventArgs e)
        {
         
        }

        private void plResult_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowResult_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
