using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLADE
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
            lblFailed.Hide();
        }

        private void txtPassword_TextChange(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void txtConfirm_TextChange(object sender, EventArgs e)
        {
            txtConfirm.PasswordChar = '*';
            if (txtConfirm.Text == "")
            {
                txtConfirm.PasswordChar = '\0';
            }
        }

        public bool InsertAccount(string username, string password)
        {
            try
            {
                string query = string.Format("INSERT Users ( Username, Password )VALUES  ( N'{0}', N'{1}' )", username, password);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }

        void AddAccount(string username, string password)
        {
            if (InsertAccount(username, password))
            {
                this.Hide();
            }
            else
            {
                lblFailed.Text = "This username is existed.";
                lblFailed.Show();

                txtUsername.Clear();
                txtPassword.Clear();
                txtConfirm.Clear();
                txtUsername.Focus();

                txtPassword.PasswordChar = '\0';
                txtConfirm.PasswordChar = '\0';
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string cfmpassword = txtConfirm.Text;

            if (password == cfmpassword)
            {
                AddAccount(username, password);
            }
            else if (username.Length > 20)
            {
                lblFailed.Text = "The username is fewer than 20 characters.";
                lblFailed.Show();
            }
            else if (password.Length > 16)
            {
                lblFailed.Text = "The password is fewer than 16 characters.";
                lblFailed.Show();
            }
            else
            {
                lblFailed.Text = "The password and comfirm password must not be different.";
                lblFailed.Show();
            }
        }

        private void btnCloseWindows_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
