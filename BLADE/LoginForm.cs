using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLADE
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            lblIncorrect.Hide();
        }

        private void txtPassword_TextChange(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE UserName = N'" + username + "' AND PassWord = N'" + password + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == null)
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (Login(username, password))
            {
                this.Hide();
            }
            else
            {
                lblIncorrect.Show();

                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignupForm frmSU = new SignupForm();
            frmSU.Show();
        }

        private void btnCloseWindows_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
