using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            //f.ShowDialog();
            f.Show();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i <= 5; i++)
            {
                Form2 f = new Form2();
                //f.ShowDialog();
                f.Show();
            }
            */

            Form2 f = new Form2();
            //f.ShowDialog();
            f.Show();

        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.MdiParent = this;
            form.Show();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Application.Exit();
            //MessageBox.Show("Do you want to Close?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // Do something
            }
        }
    }
}
