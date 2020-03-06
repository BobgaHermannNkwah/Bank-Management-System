using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management_System
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }




        public void disable()
        {
            textBox1.Text = "";
            textBox1.Enabled = false;
            button1.Enabled  = false;
            button2.Enabled  = false;
            button3.Enabled  = false;
            Add.Enabled      = false;
            button5.Enabled  = false;
            button6.Enabled  = false;
            button7.Enabled  = false;
            button8.Enabled  = false;
            button9.Enabled  = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
        }

        public void enabled()
        {
            textBox1.Enabled = true;
            button1.Enabled  = true;
            button2.Enabled  = true;
            button3.Enabled  = true;
            Add.Enabled      = true;
            button5.Enabled  = true;
            button6.Enabled  = true;
            button7.Enabled  = true;
            button8.Enabled  = true;
            button9.Enabled  = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
        }

  private void button1_Click(object sender, EventArgs e)
        {
            disable();
            button4.BringToFront();
        }

        private void on_Click(object sender, EventArgs e)
        {
            enabled();
            button1.BringToFront();
        }


        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = 0; num2 = 0;
            textBox1.Text = "";
        }




        float num1, num2, ans;
        String sign;



        private void add_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            sign = "+";
            label1.Text = num1.ToString() + sign;
            textBox1.Clear();
            textBox1.Focus();
        }
        private void substract_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            sign = "-";
            label1.Text = num1.ToString() + sign;
            textBox1.Clear();
            textBox1.Focus();
        }

        private void multiply(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            sign = "*";
            label1.Text = num1.ToString() + sign;
            textBox1.Clear();
            textBox1.Focus();
        }
 private void divide(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            sign = "/";
            label1.Text = num1.ToString() + sign;
            textBox1.Clear();
            textBox1.Focus();
        }
        private void label(object sender, EventArgs e)
        {
            
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
                textBox1.Text = textBox1.Text + text[i];
            
        }

       

        private void equalTo_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch(sign)
            {
                case "+":
                    num2 = float.Parse(textBox1.Text);
                    ans = num1 + num2;
                    textBox1.Text = ans.ToString();
                    break;
                case "-":
                    num2 = float.Parse(textBox1.Text);
                    ans = num1 - num2;
                    textBox1.Text = ans.ToString();
                    break;
                case "*":
                    num2 = float.Parse(textBox1.Text);
                    ans = num1 * num2;
                    textBox1.Text = ans.ToString();
                    break;
                case "/":
                    num2 = float.Parse(textBox1.Text);
                    ans = num1 / num2;
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

       
    }
}
