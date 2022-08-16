using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace BankingApp
{
    public class DataHelper
    {
        public List<User> userList = new List<User>();
        public void serialize()
        {
            string data = JsonConvert.SerializeObject(userList);
            System.Console.WriteLine(data);
            System.IO.File.WriteAllText("data.json", data);
        }
        public void deserialize()
        {
            string data = System.IO.File.ReadAllText("data.json");
            userList = JsonConvert.DeserializeObject<List<User>>(data);
        }
    }
    public struct Transaction
    {
        public string beneficiary;
        public string benefactor;
        public double amount;
        public Transaction(String in_benefactor, String in_beneficiary,double in_amount)
        {
            beneficiary = in_beneficiary;
            benefactor = in_benefactor;
            amount = in_amount;
        }
    }
    public class User
    {
        public string username;
        public string password;
        public double Balance;
        public string LastAccess;
        private string newerLastAccess;
        public Stack<Transaction> transactions;
        public User(string user, string pass)
        {
            username = user;
            password = pass;
            transactions = new Stack<Transaction>();
        }
        public bool checkPassword(string pass)
        {
            if (pass == password)
            {
                return true;
            }
            else { return false; }
        }
        public void setPassword(string pass)
        {
            password = pass;
        }
        public string getTransactions()
        {
            string transs = null;
            int count = 5;
            foreach( Transaction temp in transactions)
            {
                if(count-- == 0)
                {
                    break;
                }
                transs += "\n" + "User :"+temp.benefactor + "   Transfered Amount : " + temp.amount + "     Towards :" + temp.beneficiary ;
                //temp.ToString();
            }
            return transs;
        }
        public void setLastAcess(string temp)
        {
            newerLastAccess = temp;
        }
        public string getLastAcess()
        {
            return newerLastAccess;
        }
    }
}
