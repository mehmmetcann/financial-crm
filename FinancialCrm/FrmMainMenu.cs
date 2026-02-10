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
    public partial class FrmMainMenu : Form
    {
        
        public FrmMainMenu()
        {
            InitializeComponent();

           


            AddHoverEffect(btnCategoryForm, ColorTranslator.FromHtml("#6C5CE7"), ColorTranslator.FromHtml("#574BDA"));
            AddHoverEffect(btnBanksForm, ColorTranslator.FromHtml("#0984E3"), ColorTranslator.FromHtml("#0870C0"));
            AddHoverEffect(btnInvoiceForm, ColorTranslator.FromHtml("#00B894"), ColorTranslator.FromHtml("#009E7E"));
            AddHoverEffect(btnBillForm, ColorTranslator.FromHtml("#D63031"), ColorTranslator.FromHtml("#B82B2B"));
            AddHoverEffect(btnBankTransactions, ColorTranslator.FromHtml("#E17055"), ColorTranslator.FromHtml("#C85F49"));
            AddHoverEffect(btnDashboardForm, ColorTranslator.FromHtml("#2D3436"), ColorTranslator.FromHtml("#1E2224"));
            AddHoverEffect(btnSettingsForm, ColorTranslator.FromHtml("#636E72"), ColorTranslator.FromHtml("#4F585E"));
            AddHoverEffect(btnLogout, Color.Black, ColorTranslator.FromHtml("#333333"));
        }

        private void AddHoverEffect(Button btn, Color normalColor, Color hoverColor)
        {
            btn.BackColor = normalColor;

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = hoverColor;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = normalColor;
            };
        }


        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kategoriler formu henüz hazır değil.");
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnInvoiceForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Faturalar formu henüz hazır değil.");
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnBankTransactions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Banka hareketleri formu henüz hazır değil.");
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayarlar formu henüz hazır değil.");

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Close();
        }
    }
}
