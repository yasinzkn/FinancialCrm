using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        int count = 0;

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";

            var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.Description == "Gelen Havale").Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + " ₺";

            //Chart1 Kodları
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            //Chart2 Kodları

            var billData = db.Bills.GroupBy(x => x.BillTitle).Select(y => new
            {
                BillTitle = y.Key,
                TotalAmount = y.Sum(x => x.BillAmount)
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = SeriesChartType.Pie;
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.TotalAmount);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            var bills = db.Bills
                .Select(b => new { b.BillTitle, b.BillAmount })
                .ToList();

            int index = (count - 1) % bills.Count;

            var currentBill = bills[index];

            lblBillTitle.Text = currentBill.BillTitle;
            lblBillAmount.Text = currentBill.BillAmount.ToString() + " ₺";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmLogin form = new FrmLogin();
            form.Show();
            this.Hide();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings form = new FrmSettings();
            form.Show();
            this.Hide();
        }

        private void btnBankProcessForm_Click(object sender, EventArgs e)
        {
            FrmBankProcess form = new FrmBankProcess();
            form.Show();
            this.Hide();
        }

        private void btnExpensesForm_Click(object sender, EventArgs e)
        {
            FrmSpendings form = new FrmSpendings();
            form.Show();
            this.Hide();
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

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard form = new FrmDashboard();
            form.Show();
            this.Hide();
        }
    }
}
