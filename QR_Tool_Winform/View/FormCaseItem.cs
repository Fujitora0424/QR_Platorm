using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace QR_Tool_Winform.View
{
    public partial class FormCaseItem : MetroForm
    {
        private bool Moving = false;
        private int PosX;
        private int PosY;

        public string CaseName
        {
            get
            {
                return this.textBox节点名称.Text;
            }
        }

        public string Character
        {
            get
            {
                return this.comboBox特征.Text;
            }
        }

        public FormCaseItem()
        {
            InitializeComponent();
        }

        public FormCaseItem(string Name, string Character)
        {
            InitializeComponent();

            this.textBox节点名称.Text = Name;
            this.comboBox特征.Text = Character;
        }

        private void FormCaseItem_MouseDown(object sender, MouseEventArgs e)
        {
            this.Moving = true;
            this.PosX = e.X;
            this.PosY = e.Y;
        }

        private void FormCaseItem_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Moving)
            {
                this.Left += e.X - this.PosX;
                this.Top += e.Y - this.PosY;
            }
        }

        private void FormCaseItem_MouseUp(object sender, MouseEventArgs e)
        {
            this.Moving = false;
        }


        private void FormCaseItem_MouseLeave(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Cursor.Position.X >= this.Location.X + this.Width - 10
                || System.Windows.Forms.Cursor.Position.X <= this.Location.X + 10
                || System.Windows.Forms.Cursor.Position.Y >= this.Location.Y + this.Height - 10
                || System.Windows.Forms.Cursor.Position.Y <= this.Location.Y + 10)
            {
                this.Close();
            }
        }

        private void button确定_Click(object sender, EventArgs e)
        {
            if (this.textBox节点名称.Text.Length == 0)
            {
                MessageBox.Show("必须填写节点名称。");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void FormCaseItem_Load(object sender, EventArgs e)
        {

        }

        private void comboBox特征_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
