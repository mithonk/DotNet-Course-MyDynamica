namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Your Fullname is " + fname.Text + " " + lname.Text);
            //MessageBox.Show($"Your Fullname is {fname.Text} {lname.Text}");

            /*
            String firstName = fname.Text;
            String lastName = lname.Text;
            String fullName = $"{firstName} {lastName}";

            MessageBox.Show($"Your Fullname is {fullName}");
            */

            /*
            String firstName, lastName, fullName;

            firstName = fname.Text;
            lastName = lname.Text;
            fullName = $"{firstName} {lastName}";

            MessageBox.Show($"Your Fullname is {fullName}");
            */

            String _firstName = null;
            String _lastName = null;
            String _fullName = null;

            _firstName = fname.Text;
            _lastName = lname.Text;
            _fullName = $"{_firstName} {_lastName}";

            //MessageBox.Show($"Your Fullname is {_fullName}", "Your Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            fullNameView.Text = _fullName;
            fullNameViewText.Text = _fullName;

        } 


    }
}
