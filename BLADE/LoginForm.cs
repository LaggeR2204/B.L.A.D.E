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
        public int loginState = 2;
        public string _username;
        public LoginForm()
        {
            InitializeComponent();
            this.KeyDown += EnterToLogin;
            this.txtPassword.KeyDown += EnterToLogin;
            this.txtUsername.KeyDown += EnterToLogin;
            this.checkboxRemember.KeyDown += EnterToLogin;
            this.checkboxRemember.Checked = false;
            lblIncorrect.Hide();
            this.Icon = Properties.Resources.BLADE64;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Properties.Settings.Default.UserName;
            txtPassword.Text = Properties.Settings.Default.Password;

            if (Properties.Settings.Default.RememberChecked)
            {
                checkboxRemember.Checked = true;
            }
            else
            {
                checkboxRemember.Checked = false;
            }

            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void txtPassword_TextChange(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
            }
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

            if (Login(username, password))
            {
                loginState = 0;
                _username = username;
                if (checkboxRemember.Checked)
                {
                    Properties.Settings.Default.UserName = txtUsername.Text;
                    Properties.Settings.Default.Password = txtPassword.Text;
                    Properties.Settings.Default.RememberChecked = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.UserName = null;
                    Properties.Settings.Default.Password = null;
                    Properties.Settings.Default.RememberChecked = false;
                    Properties.Settings.Default.Save();
                }

                this.Close();
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
        private void EnterToLogin(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignupForm frmSU = new SignupForm();
            frmSU.Show();
        }

        private void btnCloseWindows_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnWithoutLogin_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserName = null;
            Properties.Settings.Default.Password = null;
            Properties.Settings.Default.RememberChecked = false;
            _username = "Guess";
            loginState = 1;
            this.Close();
        }

        private void txtPassword_OnIconRightClick(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                return;
            }
            else
            {
                if (txtPassword.PasswordChar == '*')
                {
                    txtPassword.PasswordChar = '\0';
                }
                else
                {
                    txtPassword.PasswordChar = '*';
                }
            }
        }
    }
}
