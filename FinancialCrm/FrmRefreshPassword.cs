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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinancialCrm
{
    public partial class FrmRefreshPassword : Form
    {
        public FrmRefreshPassword()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnRefreshPassword_Click(object sender, EventArgs e)
        {
            string email = txtUserEmail.Text;
            string password = txtPassword.Text;
            string passwordAgain = txtPasswordAgain.Text;

            var user = db.Users.Where(x => x.Email == email).FirstOrDefault();

            if (user != null)
            {
                if (password == passwordAgain)
                {
                    user.Password = password;

                    db.SaveChanges();

                    MessageBox.Show("Bilgileriniz güncellendi, giriş ekranına dönebilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil.","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı, lütfen bilgileri kontrol edip tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin form = new FrmLogin();
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtPasswordAgain.UseSystemPasswordChar = false;
            }
            else
            {
                txtPasswordAgain.UseSystemPasswordChar = true;
            }
        }
    }
}
