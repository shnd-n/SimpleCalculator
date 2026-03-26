namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double resultNum = 0;
        string firstNum = "";
        string operation = "";
        bool plusMinus = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void numBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string num = btn.Text;


            firstNum += num;
            oper.Text += num;
            result.Text += num;

        }

        private void operBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string operText = btn.Text;

            if (firstNum == "" && operation != "")
            {
                oper.Text = oper.Text.Remove(oper.Text.Length - 1) + operText;
                operation = operText;
                return;
            }

            if (firstNum != "")
            {
                if (operation == "")
                {
                    resultNum = double.Parse(firstNum);
                }
                else
                {
                    switch (operation)
                    {
                        case "+": resultNum += double.Parse(firstNum); break;
                        case "-": resultNum -= double.Parse(firstNum); break;
                        case "*": resultNum *= double.Parse(firstNum); break;
                        case "/":
                            double temp = double.Parse(firstNum);
                            if (temp != 0) resultNum /= temp;
                            else MessageBox.Show("0으로 나눌 수 없습니다.");
                            break;
                    }
                }
            }

            operation = operText;
            oper.Text += operText;
            result.Text = "";
            firstNum = "";


        }

        private void equl_Click(object sender, EventArgs e)
        {
            oper.Text += "=";

            switch (operation)
            {
                case "+":
                    resultNum += double.Parse(firstNum);
                    break;
                case "-":
                    resultNum -= double.Parse(firstNum);
                    break;
                case "*":
                    resultNum *= double.Parse(firstNum);
                    break;
                case "/":
                    if (double.Parse(firstNum) != 0)
                    {
                        resultNum /= double.Parse(firstNum);
                    }
                    else
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다.");
                        resultNum = 0;
                    }
                    break;
            }

            oper.Text += resultNum.ToString();
            result.Text = resultNum.ToString();
            operLog.Items.Add(oper.Text);

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            resultNum = 0;
            firstNum = "";
            operation = "";
            oper.Text = "";
            result.Text = "";
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            oper.Text = oper.Text.Substring(0, oper.Text.Length - firstNum.Length);
            firstNum = "";
            result.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            oper.Text = oper.Text.Substring(0, oper.Text.Length - 1);
            firstNum = firstNum.Substring(0, firstNum.Length - 1);
            result.Text = result.Text.Substring(0, result.Text.Length - 1);
        }

        private void deleteLog_Click(object sender, EventArgs e)
        {
            if (operLog.SelectedIndex != -1)
            {
                operLog.Items.RemoveAt(operLog.SelectedIndex);
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!firstNum.Contains("."))
            {
                if (firstNum == "")
                {
                    firstNum = "0.";
                    result.Text = "0.";
                    oper.Text += "0.";
                }
                else
                {
                    firstNum += ".";
                    result.Text += ".";
                    oper.Text += ".";
                }
            }
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            if (plusMinus)
            {
                firstNum = firstNum.Substring(1);
                result.Text = result.Text.Substring(1);
                oper.Text = oper.Text.Substring(0, oper.Text.Length - firstNum.Length - 1) + firstNum;
                plusMinus = false;

            }
            else
            {
                firstNum = "-" + firstNum;
                result.Text = "-" + result.Text;
                oper.Text = oper.Text.Substring(0, oper.Text.Length - firstNum.Length + 1) + firstNum;
                plusMinus = true;
            }
        }

        private void sqr_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(firstNum))
            {
                double temp = double.Parse(firstNum);
                double squared = temp * temp;

                int removeLen = firstNum.Length;
                oper.Text = oper.Text.Substring(0, oper.Text.Length - removeLen);

                oper.Text += $"sqr({firstNum})";

                firstNum = squared.ToString("G");
                result.Text = firstNum;
            }
        }
    }
}
