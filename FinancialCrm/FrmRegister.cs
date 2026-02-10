using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkTermsOfUse.Checked)
            {
                MessageBox.Show("Kullanım koşullarını kabul etmelisiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingUser = db.Users
                .FirstOrDefault(x => x.UserName == txtUsername.Text);

            if (existingUser != null)
            {
                MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Users user = new Users();
            user.UserName = txtUsername.Text;
            user.Password = txtPassword.Text; 
            user.IsActive = true;

            db.Users.Add(user);
            db.SaveChanges();

            MessageBox.Show("Kayıt başarılı! Giriş yapabilirsiniz.", "Başarılı",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            int score = 0;
            string password = txtPassword.Text;

            if (password.Length >= 6) score += 25;
            if (password.Any(char.IsDigit)) score += 25;
            if (password.Any(char.IsUpper)) score += 25;
            if (password.Any(char.IsSymbol)) score += 25;

            progressPasswordStrenght.Value = score;

            if (score <= 25)
                lblPasswordStrenght.Text = "Şifre Gücü: Zayıf";
            else if (score <= 50)
                lblPasswordStrenght.Text = "Şifre Gücü: Orta";
            else if (score <= 75)
                lblPasswordStrenght.Text = "Şifre Gücü: İyi";
            else
                lblPasswordStrenght.Text = "Şifre Gücü: Güçlü";
        }

        bool isPasswordVisible = false;

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            txtPassword.UseSystemPasswordChar = !isPasswordVisible;
            txtConfirmPassword.UseSystemPasswordChar = !isPasswordVisible;
        }
    }
}
