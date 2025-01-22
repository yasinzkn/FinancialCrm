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
    public partial class FrmBills : Form
    {
        public FrmBills()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBills_Load(object sender, EventArgs e)
        {
            var billTitle = db.Bills.Select(x => x.BillTitle).Distinct().ToList();
            cmbBillCategory.Items.Clear();
            cmbBillCategory.DisplayMember = "BillTitle";
            cmbBillCategory.ValueMember = "BillTitle";
            cmbBillCategory.DataSource = billTitle;

            var values = db.Bills.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fatura No");
            dt.Columns.Add("Fatura Adı");
            dt.Columns.Add("Tutar");
            dt.Columns.Add("Tarih");

            foreach (var bill in values)
            {
                var row = dt.NewRow();
                row["Fatura No"] = bill.BillId;
                row["Fatura Adı"] = bill.BillTitle;
                row["Tutar"] = bill.BillAmount;
                row["Tarih"] = bill.BillPeriod.Value.ToString("dd.MM.yyyy");
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fatura No");
            dt.Columns.Add("Fatura Adı");
            dt.Columns.Add("Tutar");
            dt.Columns.Add("Tarih");

            foreach (var bill in values)
            {
                var row = dt.NewRow();
                row["Fatura No"] = bill.BillId;
                row["Fatura Adı"] = bill.BillTitle;
                row["Tutar"] = bill.BillAmount;
                row["Tarih"] = bill.BillPeriod.Value.ToString("dd.MM.yyyy");
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = cmbBillCategory.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string date = dtBillDate.Text;

            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = DateTime.Parse(date);
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme başarılı bir şekilde eklendi", "Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fatura No");
            dt.Columns.Add("Fatura Adı");
            dt.Columns.Add("Tutar");
            dt.Columns.Add("Tarih");

            foreach (var bill in values)
            {
                var row = dt.NewRow();
                row["Fatura No"] = bill.BillId;
                row["Fatura Adı"] = bill.BillTitle;
                row["Tutar"] = bill.BillAmount;
                row["Tarih"] = bill.BillPeriod.Value.ToString("dd.MM.yyyy");
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme başarılı bir şekilde silindi", "Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fatura No");
            dt.Columns.Add("Fatura Adı");
            dt.Columns.Add("Tutar");
            dt.Columns.Add("Tarih");

            foreach (var bill in values)
            {
                var row = dt.NewRow();
                row["Fatura No"] = bill.BillId;
                row["Fatura Adı"] = bill.BillTitle;
                row["Tutar"] = bill.BillAmount;
                row["Tarih"] = bill.BillPeriod.Value.ToString("dd.MM.yyyy");
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            string title = cmbBillCategory.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string date = dtBillDate.Text;

            var values = db.Bills.Find(id);

            values.BillTitle = title;
            values.BillAmount = amount;
            values.BillPeriod = DateTime.Parse(date);
            db.SaveChanges();
            MessageBox.Show("Ödeme başarılı bir şekilde güncellendi", "Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Bills.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fatura No");
            dt.Columns.Add("Fatura Adı");
            dt.Columns.Add("Tutar");
            dt.Columns.Add("Tarih");

            foreach (var bill in values2)
            {
                var row = dt.NewRow();
                row["Fatura No"] = bill.BillId;
                row["Fatura Adı"] = bill.BillTitle;
                row["Tutar"] = bill.BillAmount;
                row["Tarih"] = bill.BillPeriod.Value.ToString("dd.MM.yyyy");
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            txtBillId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            cmbBillCategory.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtBillAmount.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            dtBillDate.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
        }
    }
}
