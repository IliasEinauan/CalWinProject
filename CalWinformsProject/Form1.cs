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
        //string userInput = string.Empty;
        //string deel1 = string.Empty;
        //string deel2 = string.Empty;
        //char teken;
        //double result = 0.0;

        /*if (TextBox.Text == "0" && TextBox.Text != null)  
            {  
                TextBox.Text = "1";  
            }  
            else  
            {  
                TextBox.Text = TextBox.Text + "1";
            }  */

        decimal num1;
        decimal num2;
        string operation;
        private void input(string a)
        {
            if (TextBox.Text == "0")
                TextBox.Text = a;
            else
                TextBox.Text += a;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Button25_Click(object sender, EventArgs e)//Divide Button
        {
            try
            {
                num1 = decimal.Parse(TextBox.Text);
                operation = ("/");
                TextBox.Text = "";
            }
            catch
            {

            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1);
            }
            catch{ }
            
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = decimal.Parse(TextBox.Text);
                operation = ("%");
                TextBox.Text = "";
            }
            catch
            {

            }

            //Math.DivRem(Convert.ToInt32(num1), Convert.ToInt32(num2), out int result);
           // TextBox.Text = Convert.ToString(result);

        }


        private void Button19_Click(object sender, EventArgs e)//0 Button
        {

            //userInput += "0";
            //this.TextBox.Text += userInput;
            input("0");

        }

        private void Button24_Click(object sender, EventArgs e)//1 Button
        {

            //userInput += "1";
            //this.TextBox.Text += userInput;
            input("1");
        }

        private void Button23_Click(object sender, EventArgs e)//2 Button
        {

            //userInput += "2";
            //this.TextBox.Text += userInput;
            input("2");
        }

        private void Button22_Click(object sender, EventArgs e)//3 Button
        {

            //userInput += "3";
            //this.TextBox.Text += userInput;
            input("3");
        }

        private void Button4_Click(object sender, EventArgs e)//4 Button
        {

            //userInput += "4";
            //this.TextBox.Text += userInput;
            input("4");
        }

        private void Button10_Click(object sender, EventArgs e) //5 Button
        {

            //userInput += "5";
            //this.TextBox.Text += userInput;
            input("5");
        }

        private void Button9_Click(object sender, EventArgs e) //6 Button
        {

            //userInput += "6";
            //this.TextBox.Text += userInput;
            input("6");
        }

        private void Button3_Click(object sender, EventArgs e) //7 Button
        {

            //userInput += "7";
            //this.TextBox.Text += userInput;
            input("7");
        }

        private void Button5_Click(object sender, EventArgs e) //8 Button
        {

            //userInput += "8";
            //this.TextBox.Text += userInput;
            input("8");
        }

        private void Button6_Click(object sender, EventArgs e) //9 button
        {

            //userInput += "9";
            //this.TextBox.Text += userInput;
            input("9");
        }

        private void Button2_Click(object sender, EventArgs e) //Clear button
        {
            //this.TextBox.Text = "";
            //this.userInput = string.Empty;
            //this.deel1 = string.Empty;
            //this.deel2 = string.Empty;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TextBox.Text = "";
        }

        private void Button7_Click(object sender, EventArgs e) //Mulitply Button
        {
            //TextBox.Text += '*';
            //this.TextBox.Text += userInput;
            try
            {
                num1 = decimal.Parse(TextBox.Text);
                operation = ("*");
                TextBox.Text = "";
            }
            catch
            {

            }
               
        }

        private void Button18_Click(object sender, EventArgs e)//Compute Button
        {
            num2 = decimal.Parse(TextBox.Text);
            switch (operation)
            {
                case "+":TextBox.Text = (num1 + num2).ToString();break;
                case "-":TextBox.Text = (num1 - num2).ToString();break;
                case "*": TextBox.Text = (num1 * num2).ToString();break;
                case "/": if (num2 != 0) {TextBox.Text = (num1 / num2).ToString(); break;}
                          else{TextBox.Text = "Nope"; TextBox.Text = "";  break; }
                case "^":TextBox.Text = (int.Parse(num1.ToString()) ^ int.Parse(num2.ToString())).ToString();break;
                case "%":TextBox.Text = (num1 % num2).ToString();break;
            }
            //deel2 = userInput;
            //double num1, num2;
            //double.TryParse(deel1, out num1);
            //double.TryParse(deel2, out num2);

            //if (teken == '+')
            //{
            //    result = num1 + num2;
            //    TextBox.Text = result.ToString();

            //}
            //else if (teken == '-')
            //{
            //    result = num1 - num2;
            //    TextBox.Text = result.ToString();
            //}
            //else if (teken == '*')
            //{
            //    result = num1 * num2;
            //    TextBox.Text = result.ToString();
            //}
            //else if (teken == '/')
            //{
            //    if (num2 != 0)
            //    {
            //        result = num1 / num2;
            //        TextBox.Text = result.ToString();
            //    }
            //    else
            //    {
            //        TextBox.Text = "Kan niet!";
            //    }
            //Maak een temp var aan waarin de uitkomst word in opgeslagen. Stel deze gelijk aan num1.



           

        }
        private void Button21_Click(object sender, EventArgs e)//Add Button
        {
            try
            {
                num1 = decimal.Parse(TextBox.Text);
                operation = ("+");
                TextBox.Text = "";
            }
            catch
            {

            }
        }

        private void Button17_Click(object sender, EventArgs e)//TBD Button
        {
            TextBox.Text += ',';
        }


        private void Button20_Click(object sender, EventArgs e)
        {
            try
            {
                decimal numswitch = Convert.ToDecimal(TextBox.Text);
            }
            catch {}
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {

            try
            {
                num1 = decimal.Parse(TextBox.Text);
                operation = ("-"); TextBox.Text = "";
            }
            catch { }
        }
    }
}
