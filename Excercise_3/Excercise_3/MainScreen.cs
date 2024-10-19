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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            AccountInfo();
        }


        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountInfo()
        {
            UserName.Text = AccountDAO.Instance.GetSetAccUsername;
            PassWord.Text = AccountDAO.Instance.GetSetAccPassword;
            FullName.Text = AccountDAO.Instance.GetSetAccFullname;
            Email.Text = AccountDAO.Instance.GetSetAccEmail;
            BirthDay.Text = AccountDAO.Instance.GetSetAccBirthday;
        }
    }
}
