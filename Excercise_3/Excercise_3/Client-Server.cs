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
    public partial class Client_Server : Form
    {
        public Client_Server()
        {
            InitializeComponent();
        }

        private void Client_Btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void Server_Btn_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }
    }
}
