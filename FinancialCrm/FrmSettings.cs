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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUserId.Text);
            string phone = mskPhone.Text;
            string email = txtUserEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var user = db.Users.Find(id);

            if (user != null)
            {
                if (!string.IsNullOrEmpty(phone))
                    user.Phone = phone;

                if (!string.IsNullOrEmpty(email))
                    user.Email = email;

                if (!string.IsNullOrEmpty(username))
                    user.Username = username;

                if (!string.IsNullOrEmpty(password))
                    user.Password = password;

                db.SaveChanges();

                MessageBox.Show("Bilgileriniz güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCategoriesForm_Click(object sender, EventArgs e)
        {
            FrmCategories form = new FrmCategories();
            form.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks form = new FrmBanks();
            form.Show();
            this.Hide();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBills form = new FrmBills();
            form.Show();
            this.Hide();
        }

        private void btnSpendingsForm_Click(object sender, EventArgs e)
        {
            FrmSpendings form = new FrmSpendings();
            form.Show();
            this.Hide();
        }

        private void btnBankProcessForm_Click(object sender, EventArgs e)
        {
            FrmBankProcess form = new FrmBankProcess();
            form.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard form = new FrmDashboard();
            form.Show();
            this.Hide();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings form = new FrmSettings();
            form.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmLogin form = new FrmLogin();
            form.Show();
            this.Hide();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            var user = db.Users.FirstOrDefault(x => x.UserId == 1);

            if (user != null)
            {
                txtUserId.Text = user.UserId.ToString();
                txtName.Text = user.Name;
                txtSurname.Text = user.Surname;
                mskPhone.Text = user.Phone;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
