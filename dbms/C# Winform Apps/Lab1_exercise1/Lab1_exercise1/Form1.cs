using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_exercise1
{
    public partial class Form1 : Form
    {
        int prev_num = 0 ;
        char prev_op = '+';
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nine_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void six_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void five_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void four_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void three_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void two_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void one_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void add_Click(object sender, EventArgs e)
        {
            prev_num = int.Parse(display.Text);display.Clear();
            prev_op = '+';
        }

        private void divide_Click(object sender, EventArgs e)
        {
            prev_num = int.Parse(display.Text); display.Clear();
            prev_op = '/';
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            prev_num = int.Parse(display.Text); display.Clear();
            prev_op = '-';
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            prev_num = int.Parse(display.Text); display.Clear();
            prev_op = 'x';
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if(prev_op == '+')
            {
                display.Text = (prev_num + int.Parse(display.Text)).ToString();
            }
            if (prev_op == '-')
            {
                display.Text = (prev_num - int.Parse(display.Text)).ToString();
            }
            if (prev_op == '/')
            {
                if (int.Parse(display.Text) == 0)
                { MessageBox.Show("Can't divide by zero."); }
                else
                {
                    display.Text = (prev_num / int.Parse(display.Text)).ToString();
                }
            }
            if (prev_op == 'x')
            {
                display.Text = (prev_num * int.Parse(display.Text)).ToString();
            }
        }
    }
}
