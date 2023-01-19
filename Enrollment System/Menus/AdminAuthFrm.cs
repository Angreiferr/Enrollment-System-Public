using System;
using System.Windows.Forms;
using Enrollment_System.Data;
using System.Drawing;


namespace Enrollment_System.Menus
{
    public partial class AdminAuthFrm : Form
    {
        public AdminAuthFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminManager adminManager = AdminManager.getInstance();
            String username = tbUsername.Text.ToString();
            String password = tbPassword.Text.ToString();
            for (int i = 0; i < adminManager.admins.Count; i++)
            {
                Data.Admin admin = adminManager.findByIndex(i);
                if (username.Equals(admin.Username) && password.Equals(admin.Password))
                {
                    this.Hide();
                    AdminFrm frm = new AdminFrm();
                    frm.ShowDialog();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Invalid Username or password!", "Invalid Credential", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AdminAuthFrm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if(tbUsername.Text == "Username")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Black;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if(tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
                tbPassword.ForeColor = Color.Silver;
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Username";
                tbUsername.ForeColor = Color.Silver;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Black;
            }
        }
    }
}
