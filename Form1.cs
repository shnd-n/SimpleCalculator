namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int resultNum = 0;
        string firstNum = "";
        string operation = "";
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

            oper.Text += operText;
            result.Text = "";


            if (firstNum != "")
            {
                if (operation == "")
                {
                    resultNum = int.Parse(firstNum);
                }
                else
                {
                    switch (operation)
                    {
                        case "+": resultNum += int.Parse(firstNum); break;
                        case "-": resultNum -= int.Parse(firstNum); break;
                        case "*": resultNum *= int.Parse(firstNum); break;
                        case "/":
                            int temp = int.Parse(firstNum);
                            if (temp != 0) resultNum /= temp;
                            break;
                    }
                }
            }

            operation = operText;
            firstNum = "";


        }

        private void equl_Click(object sender, EventArgs e)
        {
            oper.Text += "=";

            switch (operation)
            {
                case "+":
                    resultNum += int.Parse(firstNum);
                    break;
                case "-":
                    resultNum -= int.Parse(firstNum);
                    break;
                case "*":
                    resultNum *= int.Parse(firstNum);
                    break;
                case "/":
                    if (int.Parse(firstNum) != 0)
                    {
                        resultNum /= int.Parse(firstNum);
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        resultNum = 0;
                    }
                    break;
            }

            oper.Text += resultNum.ToString();
            result.Text = resultNum.ToString();

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            resultNum = 0;
            firstNum = "";
            operation = "";
            oper.Text = "";
            result.Text = "";
        }
    }
}
