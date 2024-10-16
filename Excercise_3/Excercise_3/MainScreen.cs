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
        }


        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
