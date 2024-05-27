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
    public partial class Form2 : Form
    {
        String firstname = null;
        public Form2(String fname)
        {
            InitializeComponent();
            this.firstname = fname;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            viewName.Text = this.firstname;  
        }
    }
}
