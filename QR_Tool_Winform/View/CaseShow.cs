using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QR_Tool_Winform
{
    public partial class CaseShow : MetroForm
    {
        public CaseShow()
        {
            InitializeComponent();
        }
        public void SetText(string str)
        {
            ShowText.Text = str;
        }

        private void CaseShow_Load(object sender, EventArgs e)
        {

        }

        private void ShowText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}