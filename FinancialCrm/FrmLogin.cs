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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var user = db.Users.Where(x => x.Username == username & x.Password == password).FirstOrDefault();

            if (user != null)
            {
                MessageBox.Show("Giriş başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmBanks form = new FrmBanks();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lnkPasswordRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRefreshPassword form = new FrmRefreshPassword();
            form.Show();
            this.Hide();
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
