using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    static class Program
    {
        public static DataHelper data = new DataHelper();
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(System.IO.File.Exists("data.json"))
                data.deserialize();
            Application.Run(new Form1());
            data.serialize();
        }
    }
}
