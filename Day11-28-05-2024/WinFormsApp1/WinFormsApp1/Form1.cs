namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewForm2_Click(object sender, EventArgs e)
        {
             Form2 f = new Form2(this);
            f.ShowDialog();
            //form1Fname.Text = f.fname;
        }
    }
}
