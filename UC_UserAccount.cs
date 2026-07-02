using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class UC_UserAccount : UserControl
    {
        private Form1 mainForm;
        public UC_UserAccount(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void UC_UserAccount_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please enter your username");
                return;
            }
            mainForm.SetCurrentUser(userName);

        }
    }
}
