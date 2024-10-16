using Excercise_3.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise_3
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();

            LoadUserAccount();
        }

        void LoadUserAccount()
        {

            string query = "Select * from dbo.UserAccount";
            DataProvider provider = new DataProvider();
            DgvAccounts.DataSource = provider.ExecuQuery(query);
        }

       
    }
}
