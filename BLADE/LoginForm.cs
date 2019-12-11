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
        public event EventHandler LoginSuccess;
        public LoginForm()
        {
            InitializeComponent();
            this.KeyDown += EnterToLogin;
            this.txtPassword.KeyDown += EnterToLogin;
            this.txtUsername.KeyDown += EnterToLogin;
            this.checkboxRemember.Checked = false;
            lblIncorrect.Hide();
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
                if (LoginSuccess != null)
                    LoginSuccess(username, new EventArgs());

                if (checkboxRemember.Checked)
                {
                    Properties.Settings.Default.UserName = txtUsername.Text;
                    Properties.Settings.Default.Password = txtPassword.Text;
                    Properties.Settings.Default.RememberChecked = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reload();
                }

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
            Application.Exit();
        }
    }
}
