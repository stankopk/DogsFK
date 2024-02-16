using DogsFK.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogsFK.View
{
    public partial class LoginView : Form
    {
        LoginController contorller = new LoginController();
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var validUser = contorller.IsLogin(username, password);
            if(validUser)
            {
                MainView m = new MainView();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }
    }
}
