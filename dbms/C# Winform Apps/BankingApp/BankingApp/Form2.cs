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
    
    public partial class Form2 : Form
    {
        Form1 form;
        User user;
        public Form2(User in_user,Form1 in_form)
        {
            form = in_form;
            user = in_user;
            InitializeComponent();
        }
        public void update()
        {
            Name_text.Text = user.username;
            Balance_text.Text = user.Balance.ToString();
            Last_Access_text.Text = user.LastAccess;
            transaction_text.Text = user.getTransactions();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Name_text.Text = user.username;
            Balance_text.Text = user.Balance.ToString();
            Last_Access_text.Text = user.LastAccess;
            transaction_text.Text = user.getTransactions();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            user.LastAccess = user.getLastAcess();
            form.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form_trans = new Form3(user,this);
            form_trans.ShowDialog();
        }
    }
}
