using System;
using System.Windows.Forms;

namespace Sorting_Algorithm
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("admin") && maskedTxtPassword.Text.Equals("password"))
            {
                var sorts = new Sorts();
                this.Hide();
                sorts.Show();

            }
            else if (txtUsername.Text.Equals("") || maskedTxtPassword.Text.Equals("password"))
            {
                MessageBox.Show("Please enter a username and password.");
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
                txtUsername.Text = "";
                maskedTxtPassword.Text = "";
            }
        }
    }
}
