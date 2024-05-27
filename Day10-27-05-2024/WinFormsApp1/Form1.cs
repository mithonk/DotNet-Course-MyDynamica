namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form2 f=new Form2(fname.Text);
            f.ShowDialog();
        }
    }
}
