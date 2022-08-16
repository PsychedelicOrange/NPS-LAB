using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{

    public partial class Form1 : Form
    {
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
            foreach (User it_user in Program.data.userList)
            {
                if (it_user.username == Username_text.Text)
                {
                    if (it_user.checkPassword(Password_text.Text))
                    {
                        
                        form2 = new Form2(it_user ,this);
                        form2.Show();
                        this.Hide();
                        it_user.setLastAcess( DateTime.Now.ToString());
                        //login succesfull
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Incorect Password for username!");
                        Password_text.Clear();
                        return;
                    }
                }
                
            }
            // if username not found in data.json , we make a new account
            Program.data.userList.Add(new User(Username_text.Text, Password_text.Text));
            MessageBox.Show("Registered new user !");
            //signup succesfull
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (User it_user in Program.data.userList)
            {
                if (it_user.username == Username_text.Text)
                {
                    it_user.setPassword(Password_text.Text);
                    return;
                    //back to login
                }
            }
            MessageBox.Show("Please enter valid username !");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.data.serialize();
        }
    }

}