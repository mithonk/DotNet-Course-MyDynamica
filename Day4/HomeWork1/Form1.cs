namespace HomeWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            num1 = Convert.ToInt32(no1.Text);
            num2 = Convert.ToInt32(no2.Text);
            viewResults.Text = (num1 + num2).ToString();
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            num1 = Convert.ToInt32(no1.Text);
            num2 = Convert.ToInt32(no2.Text);
            viewResults.Text = (num1 - num2).ToString();
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            num1 = Convert.ToInt32(no1.Text);
            num2 = Convert.ToInt32(no2.Text);
            viewResults.Text = (num1 * num2).ToString();
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            num1 = Convert.ToInt32(no1.Text);
            num2 = Convert.ToInt32(no2.Text);
            viewResults.Text = (num1 / num2).ToString();
        }
    }
}
