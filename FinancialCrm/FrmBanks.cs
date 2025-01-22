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
    public partial class FrmBanks : Form
    {

        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //Banka Bakiyeleri
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();
            var isBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

            lblIsBankBalance.Text = isBankBalance.ToString() + " ₺";
            lblVakifBankBalance.Text = vakifBankBalance.ToString() + " ₺";
            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";

            //Banka Hareketleri
            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " --> " + bankProcess1.Amount + " ₺ | " + bankProcess1.ProcessDate?.ToString("dd.MM.yyyy") ?? "Tarih Yok";
            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " --> " + bankProcess2.Amount + " ₺ | " + bankProcess2.ProcessDate?.ToString("dd.MM.yyyy") ?? "Tarih Yok";
            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " --> " + bankProcess3.Amount + " ₺ | " + bankProcess3.ProcessDate?.ToString("dd.MM.yyyy") ?? "Tarih Yok";
            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " --> " + bankProcess4.Amount + " ₺ | " + bankProcess4.ProcessDate?.ToString("dd.MM.yyyy") ?? "Tarih Yok";
            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " --> " + bankProcess5.Amount + " ₺ | " + bankProcess5.ProcessDate?.ToString("dd.MM.yyyy") ?? "Tarih Yok";
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
    }
}
