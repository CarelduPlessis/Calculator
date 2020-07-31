using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double output = 0;
        string oprt = "";

        public Calculator()
        {
            InitializeComponent();
           
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        private void calTotalValue(object sender) {
            //int total = 0;
            Button b1 = (Button)sender;
            switch (oprt)
            {
                case "+":
                    output = output + Convert.ToInt32(b1.Text);
                    break;
                case "*":
                    output = output * Convert.ToInt32(b1.Text);
                    break;
                case "-":
                    output = output - Convert.ToInt32(b1.Text);
                    break;
                case "/":
                    output = output / Convert.ToDouble(b1.Text);
                    break;
                case "":
                    output = Convert.ToInt32(b1.Text);
                    break;

            }
            Display.Text = output.ToString();
            oprt = "";
        }
    

        private void Button1_Click(object sender, EventArgs e)
        {
            Display.Text += Button1.Text;
            calTotalValue(sender);
            /*
            switch(oprt)
            {
                case "+":
                    output = output + Convert.ToInt32(Button1.Text);
                    break;
                case "":
                    output = Convert.ToInt32(Button1.Text);
                    break;
                
            }*/

            //textBox1.Text = output.ToString();


            // var var1 = Convert.ToInt32(Button1.Text);
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            Display.Text += Button2.Text;
            calTotalValue(sender);
            /*
            switch (oprt)
            {
                case "+":
                    output = output + Convert.ToInt32(Button2.Text);
                    break;
                case "":
                    output = Convert.ToInt32(Button2.Text);
                    break;

            }*/
            //textBox1.Text = output.ToString();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Display.Text += Button3.Text;
            calTotalValue(sender);
            //var var1 = Convert.ToInt32(Button3.Text);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Display.Text += Button4.Text;
            calTotalValue(sender);
            //var var1 = Convert.ToInt32(Button4.Text);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Display.Text += Button5.Text;
            calTotalValue(sender);
            // var var1 = Convert.ToInt32(Button5.Text);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Display.Text += Button6.Text;
            calTotalValue(sender);
            //var var1 = Convert.ToInt32(Button6.Text);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Display.Text += Button7.Text;
            calTotalValue(sender);
            //var var1 = Convert.ToInt32(Button7.Text);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Display.Text += Button8.Text;
            calTotalValue(sender);
            //var var1 = Convert.ToInt32(Button8.Text);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Display.Text += Button9.Text;
            calTotalValue(sender);
            // var var1 = Convert.ToInt32(Button9.Text);
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            Display.Text += Button0.Text;
            calTotalValue(sender);
            //var var1 = Convert.ToInt32(Button0.Text);
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            Display.Text += ButtonPlus.Text;
            oprt = "+";
           // var var1 = ButtonPlus.Text;
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            Display.Text += ButtonMultiply.Text;
            oprt = "*";
            // var var1 = ButtonMultiply.Text;
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            Display.Text += ButtonMinus.Text;
            oprt = "-";
            //var var1 = ButtonMinus.Text;
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            Display.Text += ButtonDivide.Text;
            oprt = "/";
            //var var1 = ButtonDivide.Text;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Display.Clear();
        }

        private void ButtonBackSpace_Click(object sender, EventArgs e)
        {
            
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }       
    }
}
