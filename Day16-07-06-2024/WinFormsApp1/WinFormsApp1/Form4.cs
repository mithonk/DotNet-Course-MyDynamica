using Microsoft.Data.SqlClient;
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
    public partial class Form4 : Form
    {
        string id = null;
        string firstname = null;
        string lastname = null;
        string grade = null;
        string address = null;
        public Form4(string id, string firstname, string lastname, string grade, string address)
        {
            InitializeComponent();
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.grade = grade;
            this.address = address;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            form4Fname.Text = firstname;
            form4Lname.Text = lastname;
            form4Grade.Text = grade;
            form4Address.Text = address;
        }

        private void form4Update_Click(object sender, EventArgs e)
        {

        }
    }
}
