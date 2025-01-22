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
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            var categories = db.Categories.ToList();
            cmbSpendingCategory.Items.Clear();
            cmbSpendingCategory.DisplayMember = "CategoryName";
            cmbSpendingCategory.ValueMember = "CategoryId";
            cmbSpendingCategory.DataSource = categories;

            var values = db.Spendings.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Harcama No");
            dt.Columns.Add("Harcama Adı");
            dt.Columns.Add("Tutar");
            dt.Columns.Add("Tarih");
            dt.Columns.Add("Kategori");

            foreach (var spending in values)
            {
                var row = dt.NewRow();
                row["Harcama No"] = spending.SpendingId;
                row["Harcama Adı"] = spending.SpendingTitle;
                row["Tutar"] = spending.SpendingAmount;
                row["Tarih"] = spending.SpendingDate.Value.ToString("dd.MM.yyyy");
                row["Kategori"] = spending.Categories != null ? spending.Categories.CategoryName : "Bilinmiyor";
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void btnSpendingList_Click(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Harcama No");
            dt.Columns.Add("Harcama Adı");
            dt.Columns.Add("Tutar");
            dt.Columns.Add("Tarih");
            dt.Columns.Add("Kategori");

            foreach (var spending in values)
            {
                var row = dt.NewRow();
                row["Harcama No"] = spending.SpendingId;
                row["Harcama Adı"] = spending.SpendingTitle;
                row["Tutar"] = spending.SpendingAmount;
                row["Tarih"] = spending.SpendingDate.Value.ToString("dd.MM.yyyy");
                row["Kategori"] = spending.Categories != null ? spending.Categories.CategoryName : "Bilinmiyor";
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void btnCreateSpending_Click(object sender, EventArgs e)
        {
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            string date = dtSpendingDate.Text;
            string category = cmbSpendingCategory.Text;

            Spendings spendings = new Spendings();
            spendings.SpendingTitle = title;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = DateTime.Parse(date);

            var categoryEntity = db.Categories.FirstOrDefault(x => x.CategoryName == category);
            if (categoryEntity != null)
            {
                spendings.CategoryId = categoryEntity.CategoryId;
            }
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Harcama başarılı bir şekilde eklendi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dt = new DataTable();
            dt.Columns.Add("Harcama No");
            dt.Columns.Add("Harcama Adı");
            dt.Columns.Add("Tutar");
            dt.Columns.Add("Tarih");
            dt.Columns.Add("Kategori");

            var values = db.Spendings.ToList();
            foreach (var spending in values)
            {
                var row = dt.NewRow();
                row["Harcama No"] = spending.SpendingId;
                row["Harcama Adı"] = spending.SpendingTitle;
                row["Tutar"] = spending.SpendingAmount;
                row["Tarih"] = spending.SpendingDate.Value.ToString("dd.MM.yyyy");
                row["Kategori"] = spending.Categories != null ? spending.Categories.CategoryName : "Bilinmiyor";
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void btnRemoveSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Harcama başarılı bir şekilde silindi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dt = new DataTable();
            dt.Columns.Add("Harcama No");
            dt.Columns.Add("Harcama Adı");
            dt.Columns.Add("Tutar");
            dt.Columns.Add("Tarih");
            dt.Columns.Add("Kategori");

            var values = db.Spendings.ToList();
            foreach (var spending in values)
            {
                var row = dt.NewRow();
                row["Harcama No"] = spending.SpendingId;
                row["Harcama Adı"] = spending.SpendingTitle;
                row["Tutar"] = spending.SpendingAmount;
                row["Tarih"] = spending.SpendingDate.Value.ToString("dd.MM.yyyy");
                row["Kategori"] = spending.Categories != null ? spending.Categories.CategoryName : "Bilinmiyor";
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void btnUpdateSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            string date = dtSpendingDate.Text;
            string category = cmbSpendingCategory.Text;

            var values = db.Spendings.Find(id);

            if (values != null)
            {
                values.SpendingTitle = title;
                values.SpendingAmount = amount;
                values.SpendingDate = DateTime.Parse(date);

                var categoryEntity = db.Categories.FirstOrDefault(x => x.CategoryName == category);
                if (categoryEntity != null)
                {
                    values.CategoryId = categoryEntity.CategoryId;
                }
                else
                {
                    MessageBox.Show("Kategori bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.SaveChanges();

                MessageBox.Show("Harcama başarılı bir şekilde güncellendi", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Harcamaya ait kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Harcama No");
            dt.Columns.Add("Harcama Adı");
            dt.Columns.Add("Tutar");
            dt.Columns.Add("Tarih");
            dt.Columns.Add("Kategori");

            var values2 = db.Spendings.ToList();
            foreach (var spending in values2)
            {
                var row = dt.NewRow();
                row["Harcama No"] = spending.SpendingId;
                row["Harcama Adı"] = spending.SpendingTitle;
                row["Tutar"] = spending.SpendingAmount;
                row["Tarih"] = spending.SpendingDate.Value.ToString("dd.MM.yyyy");
                row["Kategori"] = spending.Categories != null ? spending.Categories.CategoryName : "Bilinmiyor";
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

            txtSpendingId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtSpendingTitle.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtSpendingAmount.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            dtSpendingDate.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            cmbSpendingCategory.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
        }
    }
}