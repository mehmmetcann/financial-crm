using FinancialCrm.DataAccess;
using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (FinancialCrmDbEntities db = new FinancialCrmDbEntities())
            {
                var user = db.Users
                    .FirstOrDefault(x => x.UserName == username && x.Password == password);

                if (user != null)
                {
                    FrmMainMenu frm = new FrmMainMenu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            frm.Show();
            this.Hide();
        }
    }
}
