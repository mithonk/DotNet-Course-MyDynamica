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

            try
            {
                Int32 num1 = 0;
                Int32 num2 = 0;

                numberValidation(ref num1, ref num2);
                MessageBox.Show("Mithursan");
                //Int32 num1 = Convert.ToInt32(txtNum1.Text);
                //Int32 num2 = Convert.ToInt32(txtNum2.Text);

                int result = Calculate(num1, num2, "+");

                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                //throw;
            }




        }

        private void numberValidation(ref int num1, ref int num2)
        {
            if (String.IsNullOrEmpty(txtNum1.Text))
            {
                MessageBox.Show("Enter Number1", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum1.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtNum2.Text))
            {
                MessageBox.Show("Enter Number2", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum2.Focus();
                return;
            }


            Boolean isNumber1 = Int32.TryParse(txtNum1.Text, out num1);
            if (!isNumber1)
            {
                MessageBox.Show("Enter Correct Number1", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum1.Focus();
                return;
            }
            Boolean isNumber2 = Int32.TryParse(txtNum2.Text, out num2);
            if (!isNumber2)
            {
                MessageBox.Show("Enter Correct Number2", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum2.Focus();
                return;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            /*
            Int32 num1 = Convert.ToInt32(txtNum1.Text);
            Int32 num2 = Convert.ToInt32(txtNum2.Text);
            Int32 result = num1 - num2;

            txtResult.Text = result.ToString();
            */
            try
            {
                Int32 num1 = 0;
                Int32 num2 = 0;

                if (String.IsNullOrEmpty(txtNum1.Text))
                {
                    MessageBox.Show("Enter Number1", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNum1.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(txtNum2.Text))
                {
                    MessageBox.Show("Enter Number2", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNum2.Focus();
                    return;
                }


                Boolean isNumber1 = Int32.TryParse(txtNum1.Text, out num1);
                if (!isNumber1)
                {
                    MessageBox.Show("Enter Correct Number1", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNum1.Focus();
                    return;
                }
                Boolean isNumber2 = Int32.TryParse(txtNum2.Text, out num2);
                if (!isNumber2)
                {
                    MessageBox.Show("Enter Correct Number2", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNum2.Focus();
                    return;
                }
                //Int32 num1 = Convert.ToInt32(txtNum1.Text);
                //Int32 num2 = Convert.ToInt32(txtNum2.Text);

                int result = Calculate(num1, num2, "-");

                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                //throw;
            }
        }


        private void btnMulti_Click(object sender, EventArgs e)
        {
            /*
            Int32 num1 = Convert.ToInt32(txtNum1.Text);
            Int32 num2 = Convert.ToInt32(txtNum2.Text);
            Int32 result = num1 * num2;

            txtResult.Text = result.ToString();
            */

            try
            {
                Int32 num1 = 0;
                Int32 num2 = 0;

                if (String.IsNullOrEmpty(txtNum1.Text))
                {
                    MessageBox.Show("Enter Number1", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNum1.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(txtNum2.Text))
                {
                    MessageBox.Show("Enter Number2", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNum2.Focus();
                    return;
                }


                Boolean isNumber1 = Int32.TryParse(txtNum1.Text, out num1);
                if (!isNumber1)
                {
                    MessageBox.Show("Enter Correct Number1", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNum1.Focus();
                    return;
                }
                Boolean isNumber2 = Int32.TryParse(txtNum2.Text, out num2);
                if (!isNumber2)
                {
                    MessageBox.Show("Enter Correct Number2", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNum2.Focus();
                    return;
                }
                //Int32 num1 = Convert.ToInt32(txtNum1.Text);
                //Int32 num2 = Convert.ToInt32(txtNum2.Text);

                int result = Calculate(num1, num2, "*");

                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                //throw;
            }
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            /*
            Int32 num1 = Convert.ToInt32(txtNum1.Text);
            Int32 num2 = Convert.ToInt32(txtNum2.Text);
            Int32 result = num1 / num2;

            txtResult.Text = result.ToString();
            */

            try
            {
                Int32 num1 = 0;
                Int32 num2 = 0;

                if (String.IsNullOrEmpty(txtNum1.Text))
                {
                    MessageBox.Show("Enter Number1", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNum1.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(txtNum2.Text))
                {
                    MessageBox.Show("Enter Number2", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNum2.Focus();
                    return;
                }


                Boolean isNumber1 = Int32.TryParse(txtNum1.Text, out num1);
                if (!isNumber1)
                {
                    MessageBox.Show("Enter Correct Number1", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNum1.Focus();
                    return;
                }
                Boolean isNumber2 = Int32.TryParse(txtNum2.Text, out num2);
                if (!isNumber2)
                {
                    MessageBox.Show("Enter Correct Number2", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNum2.Focus();
                    return;
                }
                //Int32 num1 = Convert.ToInt32(txtNum1.Text);
                //Int32 num2 = Convert.ToInt32(txtNum2.Text);

                int result = Calculate(num1, num2, "/");

                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                //throw;
            }

        }
    }
}
    