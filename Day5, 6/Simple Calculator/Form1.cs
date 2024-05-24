namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region User Define Function
        private static int sum(int num1, int num2)
        {
            return num1 + num2;
        }

        private static int sub(int num1, int num2)
        {
            return num1 - num2;
        }

        private static int multi(int num1, int num2)
        {
            return num1 * num2;
        }

        private static int divi(int num1, int num2)
        {
            return num1 / num2;
        }
        private static int Calculate(int num1, int num2, String Opertaor)
        {
            int result = 0;
            /*
            if (Opertaor == "+")
            {
                result = sum(num1, num2);
            } else if (Opertaor == "-")
            {
                result = sub(num1, num2);
            } else if (Opertaor == "*")
            {
                result = multi(num1, num2);
            } else
            {
                result = divi(num1, num2);
            }
            */

            switch (Opertaor)
            {
                case "+":
                    result = sum(num1, num2);
                    break;
                case "-":
                    result = sub(num1, num2);
                    break;
                case "*":
                    result = multi(num1, num2);
                    break;
                case "/":
                    result = divi(num1, num2);
                    break;
            }
            return result;
        }
        #endregion

        private void btnPlus_Click(object sender, EventArgs e)
        {
            /*
            Int32 num1 = Convert.ToInt32(txtNum1.Text);
            Int32 num2 = Convert.ToInt32(txtNum2.Text);
            Int32 result = num1 + num2;

            txtResult.Text = result.ToString();
            */

            Int32 num1 = Convert.ToInt32(txtNum1.Text);
            Int32 num2 = Convert.ToInt32(txtNum2.Text);
            int result = Calculate(num1, num2, "+");

            txtResult.Text = result.ToString();


        }


        private void btnMinus_Click(object sender, EventArgs e)
        {
            /*
            Int32 num1 = Convert.ToInt32(txtNum1.Text);
            Int32 num2 = Convert.ToInt32(txtNum2.Text);
            Int32 result = num1 - num2;

            txtResult.Text = result.ToString();
            */

            Int32 num1 = Convert.ToInt32(txtNum1.Text);
            Int32 num2 = Convert.ToInt32(txtNum2.Text);

            int result = Calculate(num1, num2, "-");

            txtResult.Text = result.ToString();
        }


        private void btnMulti_Click(object sender, EventArgs e)
        {
            /*
            Int32 num1 = Convert.ToInt32(txtNum1.Text);
            Int32 num2 = Convert.ToInt32(txtNum2.Text);
            Int32 result = num1 * num2;

            txtResult.Text = result.ToString();
            */

            Int32 num1 = Convert.ToInt32(txtNum1.Text);
            Int32 num2 = Convert.ToInt32(txtNum2.Text);

            int result = Calculate(num1, num2, "*");

            txtResult.Text = result.ToString();
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            /*
            Int32 num1 = Convert.ToInt32(txtNum1.Text);
            Int32 num2 = Convert.ToInt32(txtNum2.Text);
            Int32 result = num1 / num2;

            txtResult.Text = result.ToString();
            */

            Int32 num1 = Convert.ToInt32(txtNum1.Text);
            Int32 num2 = Convert.ToInt32(txtNum2.Text);

            int result = Calculate(num1, num2, "/");

            txtResult.Text = result.ToString();
        }

    }
}
