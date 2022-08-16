using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_exercise2
{

    public partial class Form1 : Form
    {
        List<User> userList = new List<User>();
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
            foreach (User user in userList)
            {
                if (user.username == Username_text.Text)
                {
                    if (user.checkPassword(Password_text.Text))
                    {
                        //login succesfull
                        form2 = new Form2(user);
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorect Password for username!");
                        Password_text.Clear();
                    }
                }
                else
                {
                    userList.Add(new User(Username_text.Text, Password_text.Text));
                    //signup + login succesfull
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (User user in userList)
            {
                if (user.username == Username_text.Text)
                {
                    user.setPassword(Password_text.Text);
                    //back to login
                }
                else
                {
                    MessageBox.Show("Please enter valid username !");
                    // back to login
                }
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }

}