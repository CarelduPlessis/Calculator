using System;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Calculator : Form
    {
        double output = 0;
        string oprt = "";
        bool IsText = false;


        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        string num1 = "";
        string num2 = "";
        private void calTotalValue(object sender)
        {

            Button b1 = (Button)sender;
            string[] oprt1 = { "+", "-", "/", "X" };

            for (int i = 0; i < oprt1.Length; i++)
            {
                if (oprt1[i] == b1.Text)
                {
                    IsText = true;
                }
            }

            if (IsText != true)
            {
                num1 = num1 + b1.Text;
            }
            else
            {
                num2 = num2 + b1.Text;
            }

            int numericCheck = 0;

            bool result = int.TryParse(num2, out numericCheck);

            for (int i = 0; i < oprt1.Length; i++)
            {
                if (result)
                {
                    switch (oprt)
                    {
                        case "+":
                            output = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                            break;
                        case "X":
                            output = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                            break;
                        case "-":
                            output = Convert.ToDouble(num1) - Convert.ToDouble(num2);
                            break;
                        case "/":

                            if (Convert.ToInt32(num2) == 0)
                            {
                                MessageBox.Show("can't divide by zero");
                                i = oprt1.Length; // stop the loop
                                
                                //break; // 'break' doesn't stop the loop
                            }
                            else
                            {
                                output = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                            }


                            break;
                        case "":
                            output = Convert.ToDouble(b1.Text);
                            break;

                    }

                }
                else if (IsText)
                {
                    num2 = num2.Replace(oprt, "");
                }
            }

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Display.Text += Button1.Text;
            calTotalValue(sender);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Display.Text += Button2.Text;
            calTotalValue(sender);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Display.Text += Button3.Text;
            calTotalValue(sender);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Display.Text += Button4.Text;
            calTotalValue(sender);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Display.Text += Button5.Text;
            calTotalValue(sender);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Display.Text += Button6.Text;
            calTotalValue(sender);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Display.Text += Button7.Text;
            calTotalValue(sender);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Display.Text += Button8.Text;
            calTotalValue(sender);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Display.Text += Button9.Text;
            calTotalValue(sender);
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            Display.Text += Button0.Text;
            calTotalValue(sender);
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            Display.Text += ButtonPlus.Text;
            oprt = "+";
            calTotalValue(sender);
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            Display.Text += ButtonMultiply.Text;
            oprt = "X";
            calTotalValue(sender);
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            Display.Text += ButtonMinus.Text;
            oprt = "-";
            calTotalValue(sender);
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            Display.Text += ButtonDivide.Text;
            oprt = "/";
            calTotalValue(sender);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Display.Clear();
            num1 = "";
            num2 = "";
            IsText = false;
        }

        private void ButtonBackSpace_Click(object sender, EventArgs e)
        {
            if (0 <= Display.Text.Length - 1)
            {
                Display.Text = Display.Text.Remove(Display.Text.Length - 1);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            num1 = "";
            num2 = "";
            IsText = false;
            Display.Text = output.ToString();
        }
    }
}
