using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QR_Tool_Winform.Metro_UI_Tools
{
    public partial class StorageCounter : Form
    {
        public StorageCounter()
        {
            InitializeComponent();
        }

        private void StorageCounter_Load(object sender, EventArgs e)
        {

        }

        private void countbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (counttextBox.Text != "")
            {
                Tools.CountNumber = counttextBox.Text.Trim();
            }
            else 
            {
                MessageBox.Show("«Î ‰»ÎΩª“◊–Ú∫≈");
                Tools.CountNumber = "0";
            }
        }
    }
}