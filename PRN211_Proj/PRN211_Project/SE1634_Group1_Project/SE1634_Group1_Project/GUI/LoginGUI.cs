using Microsoft.VisualBasic.ApplicationServices;
using SE1634_Group1_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SE1634_Group1_Project.GUI
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            AccountDAO accountDAO = new AccountDAO();
            Account user = accountDAO.GetUser(UserNameValue.Text, PasswordValue.Text);
            if (user != null)
            {
                MessageBox.Show("login success");
                Global.UserName = user.UserName;
                Global.Role = user.Role;
                Global.UserId = user.UserId;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("login fail");
            }
        }
    }
}
