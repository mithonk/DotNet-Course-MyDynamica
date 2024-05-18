using System.Windows.Forms.Design;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {
            String _fname = fname.Text;
            String _lname = lname.Text;
            String _fullname = $"{_fname} {_lname}";


            //MessageBox.Show($"Your Fullname is : {fname.Text} {lname.Text}");
            //MessageBox.Show("Your Fullname is : "+fname.Text+" "+lname.Text);

            //MessageBox.Show($"Your Fullname is : {_fullname}", "Your Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show($"Your Fullname is : {_fullname}", "Your Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            fullname.Text = _fullname;
            viewtext.Text = _fullname;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
