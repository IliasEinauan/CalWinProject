using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalWinformsProject
{
    public partial class Form1 : Form
    {
        string userInput = string.Empty;
        string deel1 = string.Empty;
        string deel2 = string.Empty;
        char teken;
        double result = 0.0;

        /*if (TextBox.Text == "0" && TextBox.Text != null)  
            {  
                TextBox.Text = "1";  
            }  
            else  
            {  
                TextBox.Text = TextBox.Text + "1";


            
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "Kan niet!";
                }

            }


            }  */



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }

        private void Button16_Click(object sender, EventArgs e)
        {

        }

        private void Button25_Click(object sender, EventArgs e)//Divide Button
        {
            TextBox.Text += '/';
        }

        private void Button11_Click(object sender, EventArgs e)
        {

        }

        private void Button26_Click(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {

        }

        private void Button19_Click(object sender, EventArgs e)//0 Button
        {
            this.TextBox.Text = "";
            userInput += "0";
            this.TextBox.Text += userInput;
        }

        private void Button24_Click(object sender, EventArgs e)//1 Button
        {
            this.TextBox.Text = "";
            userInput += "1";
            this.TextBox.Text += userInput;
        }

        private void Button23_Click(object sender, EventArgs e)//2 Button
        {
            this.TextBox.Text = "";
            userInput += "2";
            this.TextBox.Text += userInput;
        }

        private void Button22_Click(object sender, EventArgs e)//3 Button
        {
            this.TextBox.Text = "";
            userInput += "3";
            this.TextBox.Text += userInput;
        }

        private void Button4_Click(object sender, EventArgs e)//4 Button
        {
            this.TextBox.Text = "";
            userInput += "4";
            this.TextBox.Text += userInput;
        }

        private void Button10_Click(object sender, EventArgs e) //5 Button
        {
            this.TextBox.Text = "";
            userInput += "5";
            this.TextBox.Text += userInput;
        }

        private void Button9_Click(object sender, EventArgs e) //6 Button
        {
            this.TextBox.Text = "";
            userInput += "6";
            this.TextBox.Text += userInput;
        }

        private void Button3_Click(object sender, EventArgs e) //7 Button
        {
            this.TextBox.Text = "";
            userInput += "7";
            this.TextBox.Text += userInput;
        }

        private void Button5_Click(object sender, EventArgs e) //8 Button
        {
            this.TextBox.Text = "";
            userInput += "8";
            this.TextBox.Text += userInput;
        }

        private void Button6_Click(object sender, EventArgs e) //9 button
        {
            this.TextBox.Text = "";
            userInput += "9";
            this.TextBox.Text += userInput;
        }

        private void Button2_Click(object sender, EventArgs e) //Clear button
        {
            this.TextBox.Text = "";
            this.userInput = string.Empty;
            this.deel1 = string.Empty;
            this.deel2 = string.Empty;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e) //Mulitply Button
        {
            TextBox.Text += '*';
        }

        private void Button18_Click(object sender, EventArgs e)//Compute Button
        {
            deel2 = userInput;
            double num1, num2;
            double.TryParse(deel1, out num1);
            double.TryParse(deel2, out num2);

            if (teken == '+')
            {
                result = num1 + num2;
                TextBox.Text = result.ToString();

            }
            else if (teken == '-')
            {
                result = num1 - num2;
                TextBox.Text = result.ToString();
            }
            else if (teken == '*')
            {
                result = num1 * num2;
                TextBox.Text = result.ToString();
            }
            else if (teken == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    TextBox.Text = result.ToString();
                }
                else
                {
                    TextBox.Text = "Kan niet!";
                }
                //Maak een temp var aan waarin de uitkomst word in opgeslagen. Stel deze gelijk aan num1.
            }
        }
        private void Button21_Click(object sender, EventArgs e)//Add Button
        {
            deel1 = userInput;
            teken = '+';
            userInput = string.Empty;
        }

        private void Button17_Click(object sender, EventArgs e)//TBD Button
        {
            TextBox.Text += ',';
        }

        private void TextBox_TextChanged(object sender, EventArgs e)//Reserved for calculations
        {

        }

        private void Button20_Click(object sender, EventArgs e)
        {

        }
    }
}
