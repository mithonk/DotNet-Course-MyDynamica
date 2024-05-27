using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HW1
{
    public partial class Form2 : Form
    {
        String firstname = null;
        String lastname = null;
        String address = null;
        String gradeD = null;
        String genderD = null;
        public Form2(String fname, String lname, String add, string grade, string gender)
        {
            InitializeComponent();
            this.firstname = fname;
            this.lastname = lname;
            this.address = add;
            this.gradeD = grade;
            this.genderD = gender;

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            viewFname.Text = this.firstname;
            viewLname.Text = this.lastname;
            viewAddress.Text = this.address;
            viewGrade.Text = this.gradeD;
            viewGender.Text = this.genderD;
        }
    }
}
