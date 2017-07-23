using MetroFramework.Forms;
using QR_Tool_Winform.Properties;
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
    public partial class StartForm : MetroForm
    {

        public StartForm()
        {
            InitializeComponent();
         
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

            FormBorderStyle = FormBorderStyle.None;
            //BackgroundImage = Resources.pass;
            this.timer1.Start();
            this.timer1.Interval = 100;
            metroProgressBar1.Value = 0;
            metroProgressBar1.Maximum = 200;
            metroProgressBar1.Step = 20;
        }
        

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            metroProgressBar1.PerformStep();
            if (metroProgressBar1.Value == metroProgressBar1.Maximum)
            {
                DataBase.TestCaseDataBase.InitTestCase();
                Close();
            }
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.timer1.Stop();
        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
