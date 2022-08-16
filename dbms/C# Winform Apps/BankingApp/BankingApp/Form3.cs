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
    public partial class Form3 : Form
    {
        User user;
        Form2 form;
        public Form3(User in_user,Form2 in_form)
        {
            user = in_user;
            form = in_form;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Balance_text.Text = user.Balance.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            foreach (User it_user in Program.data.userList)
            {
                if (it_user.username == benefeciary.Text)
                {
                    System.Console.WriteLine(Double.Parse(amount.Text));
                    if (Double.Parse(amount.Text) > user.Balance)
                    {
                        MessageBox.Show("Not enough balance !");
                        return;
                    }
                    user.Balance -= Double.Parse(amount.Text);
                    it_user.Balance += Double.Parse(amount.Text);
                    Transaction trans =new Transaction(user.username, it_user.username, Double.Parse(amount.Text));
                    user.transactions.Push(trans);
                    it_user.transactions.Push(trans);
                    Balance_text.Text = user.Balance.ToString();
                    form.update();
                    break;
                    
                }
            }
            
        }

        private void Beneficiary_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
