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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
            lblFailed.Hide();
            this.KeyDown += ChangePasswordForm_KeyDown;
            txtUsername.KeyDown += ChangePasswordForm_KeyDown;
            txtPassword.KeyDown += ChangePasswordForm_KeyDown;
            txtNewPassword.KeyDown += ChangePasswordForm_KeyDown;
            txtConfirm.KeyDown += ChangePasswordForm_KeyDown;
        }

        private void txtPassword_TextChange(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void txtNewPassword_TextChange(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '*';
            if (txtNewPassword.Text == "")
            {
                txtNewPassword.PasswordChar = '\0';
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

        public bool ResetPassword(string username, string password, string newpass)
        {
            string query = string.Format("update users set password = N'{0}' where UserName = N'{1}' and PassWord = N'{2}'", newpass, username, password);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        private void ChangeFailed()
        {
            txtPassword.Clear();
            txtNewPassword.Clear();
            txtConfirm.Clear();
            txtUsername.Focus();

            txtPassword.PasswordChar = txtNewPassword.PasswordChar = txtConfirm.PasswordChar = '\0';
        }

        void ResetPass(string username, string password, string newpass)
        {
            if (ResetPassword(username, password, newpass))
            {
                lblFailed.ForeColor = Color.Green;
                lblFailed.Text = "Update password successfully.";
                lblFailed.Show();
            }
            else
            {
                lblFailed.ForeColor = Color.Red;
                lblFailed.Text = "Update password failed.";
                lblFailed.Show();

                ChangeFailed();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string newpass = txtNewPassword.Text;
            string cfmnewpass = txtConfirm.Text;

            if (newpass != cfmnewpass)
            {
                lblFailed.ForeColor = Color.Red;
                lblFailed.Text = "New password and confirm must be same.";
                lblFailed.Show();

                ChangeFailed();
            }
            else if (password == newpass)
            {
                lblFailed.ForeColor = Color.Red;
                lblFailed.Text = "Change to the same thing? Are you serious?";
                lblFailed.Show();

                ChangeFailed();
            }
            else
            {
                ResetPass(username, password, newpass);
            }
        }
        
        private void ChangePasswordForm_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                btnChange.PerformClick();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
