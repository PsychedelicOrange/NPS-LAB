using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool not_complete = false;
            // check and fill variables
            string name = null;
            if (maskedTextBox1.Text != null)
                name = maskedTextBox1.Text;
            else
            {
                MessageBox.Show("Please enter Name !");
                not_complete = true;
            }
            string regNum = null;
            if (maskedTextBox2.Text != null)
                regNum = maskedTextBox2.Text;
            else
            {
                MessageBox.Show("Please enter regNum !");
                not_complete = true;
            }
            string gender = null;
            if (radioButton1.Checked)
                gender = "Male";
            else if (radioButton2.Checked)
                gender = "Female";
            else if (radioButton3.Checked)
                gender = "Other";
            else
            {
                MessageBox.Show("Please select Gender !");
                not_complete = true;
            }
            string branch = null;
            if (comboBox1.Text != null)
                branch = comboBox1.Text;
            else
            {
                MessageBox.Show("Please select Branch !");
                not_complete = true;
            }
            string mess_fac = null;
            if (checkBox1.Checked)
                mess_fac = "true";
            else
                mess_fac = "false";
            string hostel_fac = null;
            if (checkBox2.Checked)
                hostel_fac = "true";
            else
                hostel_fac = "false";
            string date = monthCalendar1.SelectionRange.Start.ToShortDateString();
            
            if (!not_complete)
            {
                // concat message in a string to avoid many parameters in constructor call
                string message = "Name : " + name +
                    "\nRegistration number : " + regNum +
                    "\nGender : " + gender +
                    "\nBranch : " + branch +
                    "\nMess Facility :" + mess_fac +
                    "\nHostel Facility : " + hostel_fac +
                    "\nBirthday : " + date;
                Form2 confirm = new Form2(message,this);
                confirm.Show();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
