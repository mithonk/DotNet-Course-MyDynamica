namespace HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            String gender = null;

            if (male.Checked)
            {
                gender = male.Text;
            }
            else if (female.Checked) { 
                gender = female.Text;
            }

            Form2 f = new Form2(fname.Text, lname.Text, add.Text, grade.Text, gender);
            f.ShowDialog();

 

        }


    }
}
