namespace FinancialCrm
{
    partial class FrmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tblMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettingsForm = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.btnBankTransactions = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnInvoiceForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.tblMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.tblMenu);
            this.panelContainer.Controls.Add(this.lblMainTitle);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1184, 661);
            this.panelContainer.TabIndex = 0;
    //        this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // tblMenu
            // 
            this.tblMenu.ColumnCount = 2;
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMenu.Controls.Add(this.btnLogout, 1, 3);
            this.tblMenu.Controls.Add(this.btnSettingsForm, 0, 3);
            this.tblMenu.Controls.Add(this.btnDashboardForm, 1, 2);
            this.tblMenu.Controls.Add(this.btnBankTransactions, 0, 2);
            this.tblMenu.Controls.Add(this.btnBillForm, 1, 1);
            this.tblMenu.Controls.Add(this.btnInvoiceForm, 0, 1);
            this.tblMenu.Controls.Add(this.btnBanksForm, 1, 0);
            this.tblMenu.Controls.Add(this.btnCategoryForm, 0, 0);
            this.tblMenu.Location = new System.Drawing.Point(290, 140);
            this.tblMenu.Name = "tblMenu";
            this.tblMenu.RowCount = 4;
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMenu.Size = new System.Drawing.Size(620, 460);
            this.tblMenu.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(325, 360);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(280, 85);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Çıkış Yap";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettingsForm
            // 
            this.btnSettingsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnSettingsForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettingsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettingsForm.FlatAppearance.BorderSize = 0;
            this.btnSettingsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettingsForm.ForeColor = System.Drawing.Color.White;
            this.btnSettingsForm.Location = new System.Drawing.Point(15, 360);
            this.btnSettingsForm.Margin = new System.Windows.Forms.Padding(15);
            this.btnSettingsForm.Name = "btnSettingsForm";
            this.btnSettingsForm.Size = new System.Drawing.Size(280, 85);
            this.btnSettingsForm.TabIndex = 7;
            this.btnSettingsForm.Text = "Ayarlar";
            this.btnSettingsForm.UseVisualStyleBackColor = false;
            this.btnSettingsForm.Click += new System.EventHandler(this.btnSettingsForm_Click);
            // 
            // btnDashboardForm
            // 
            this.btnDashboardForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnDashboardForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboardForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDashboardForm.FlatAppearance.BorderSize = 0;
            this.btnDashboardForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboardForm.ForeColor = System.Drawing.Color.White;
            this.btnDashboardForm.Location = new System.Drawing.Point(325, 245);
            this.btnDashboardForm.Margin = new System.Windows.Forms.Padding(15);
            this.btnDashboardForm.Name = "btnDashboardForm";
            this.btnDashboardForm.Size = new System.Drawing.Size(280, 85);
            this.btnDashboardForm.TabIndex = 6;
            this.btnDashboardForm.Text = "Dashboard";
            this.btnDashboardForm.UseVisualStyleBackColor = false;
            this.btnDashboardForm.Click += new System.EventHandler(this.btnDashboardForm_Click);
            // 
            // btnBankTransactions
            // 
            this.btnBankTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.btnBankTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBankTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBankTransactions.FlatAppearance.BorderSize = 0;
            this.btnBankTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankTransactions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankTransactions.ForeColor = System.Drawing.Color.White;
            this.btnBankTransactions.Location = new System.Drawing.Point(15, 245);
            this.btnBankTransactions.Margin = new System.Windows.Forms.Padding(15);
            this.btnBankTransactions.Name = "btnBankTransactions";
            this.btnBankTransactions.Size = new System.Drawing.Size(280, 85);
            this.btnBankTransactions.TabIndex = 5;
            this.btnBankTransactions.Text = "Banka Hareketleri";
            this.btnBankTransactions.UseVisualStyleBackColor = false;
            this.btnBankTransactions.Click += new System.EventHandler(this.btnBankTransactions_Click);
            // 
            // btnBillForm
            // 
            this.btnBillForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnBillForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBillForm.FlatAppearance.BorderSize = 0;
            this.btnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillForm.ForeColor = System.Drawing.Color.White;
            this.btnBillForm.Location = new System.Drawing.Point(325, 130);
            this.btnBillForm.Margin = new System.Windows.Forms.Padding(15);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(280, 85);
            this.btnBillForm.TabIndex = 4;
            this.btnBillForm.Text = "Giderler";
            this.btnBillForm.UseVisualStyleBackColor = false;
            this.btnBillForm.Click += new System.EventHandler(this.btnBillForm_Click);
            // 
            // btnInvoiceForm
            // 
            this.btnInvoiceForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnInvoiceForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoiceForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInvoiceForm.FlatAppearance.BorderSize = 0;
            this.btnInvoiceForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInvoiceForm.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceForm.Location = new System.Drawing.Point(15, 130);
            this.btnInvoiceForm.Margin = new System.Windows.Forms.Padding(15);
            this.btnInvoiceForm.Name = "btnInvoiceForm";
            this.btnInvoiceForm.Size = new System.Drawing.Size(280, 85);
            this.btnInvoiceForm.TabIndex = 3;
            this.btnInvoiceForm.Text = "Faturalar";
            this.btnInvoiceForm.UseVisualStyleBackColor = false;
            this.btnInvoiceForm.Click += new System.EventHandler(this.btnInvoiceForm_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnBanksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanksForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBanksForm.FlatAppearance.BorderSize = 0;
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(325, 15);
            this.btnBanksForm.Margin = new System.Windows.Forms.Padding(15);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(280, 85);
            this.btnBanksForm.TabIndex = 2;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnCategoryForm
            // 
            this.btnCategoryForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnCategoryForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCategoryForm.FlatAppearance.BorderSize = 0;
            this.btnCategoryForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryForm.ForeColor = System.Drawing.Color.White;
            this.btnCategoryForm.Location = new System.Drawing.Point(15, 15);
            this.btnCategoryForm.Margin = new System.Windows.Forms.Padding(15);
            this.btnCategoryForm.Name = "btnCategoryForm";
            this.btnCategoryForm.Size = new System.Drawing.Size(280, 85);
            this.btnCategoryForm.TabIndex = 1;
            this.btnCategoryForm.Text = "Kategoriler";
            this.btnCategoryForm.UseVisualStyleBackColor = false;
            this.btnCategoryForm.Click += new System.EventHandler(this.btnCategoryForm_Click);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblMainTitle.Location = new System.Drawing.Point(370, 30);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(381, 40);
            this.lblMainTitle.TabIndex = 4;
            this.lblMainTitle.Text = "Financial CRM - Ana Menü";
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMainMenu";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.tblMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TableLayoutPanel tblMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettingsForm;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Button btnBankTransactions;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button btnInvoiceForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategoryForm;
        private System.Windows.Forms.Label lblMainTitle;
    }
}