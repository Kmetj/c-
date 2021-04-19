using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == ConfigurationManager.AppSettings.Get("LoginName") && PassTextBox.Text == ConfigurationManager.AppSettings.Get("LoginPass"))
            {
                this.Hide();
                MainPage main = new MainPage();
                main.Show();
            }
            else 
            {
                MessageBox.Show("Incorrect login");            }
        }
    }
}
