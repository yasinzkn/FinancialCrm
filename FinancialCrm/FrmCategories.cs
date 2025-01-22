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
    public partial class FrmCategories : Form
    {

        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Kategori Id");
            dt.Columns.Add("Kategori Adı");

            foreach (var category in values)
            {
                var row = dt.NewRow();
                row["Kategori Id"] = category.CategoryId;
                row["Kategori Adı"] = category.CategoryName;
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void btnCreateSpending_Click(object sender, EventArgs e)
        {
            var categoryTitle = txtCategoryTitle.Text;

            Categories categories = new Categories();
            categories.CategoryName = categoryTitle;

            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori başarılı bir şekilde eklendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Kategori Id");
            dt.Columns.Add("Kategori Adı");

            foreach (var category in values)
            {
                var row = dt.NewRow();
                row["Kategori Id"] = category.CategoryId;
                row["Kategori Adı"] = category.CategoryName;
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void btnSpendingList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Kategori Id");
            dt.Columns.Add("Kategori Adı");

            foreach (var category in values)
            {
                var row = dt.NewRow();
                row["Kategori Id"] = category.CategoryId;
                row["Kategori Adı"] = category.CategoryName;
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void btnRemoveSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kategori başarılı bir şekilde silindi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Kategori Id");
            dt.Columns.Add("Kategori Adı");

            foreach (var category in values)
            {
                var row = dt.NewRow();
                row["Kategori Id"] = category.CategoryId;
                row["Kategori Adı"] = category.CategoryName;
                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void btnUpdateSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var categories = txtCategoryTitle.Text;

            var values = db.Categories.Find(id);
            values.CategoryName = categories;
            db.SaveChanges();
            MessageBox.Show("Kategori başarılı bir şekilde güncellendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Categories.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Kategori Id");
            dt.Columns.Add("Kategori Adı");

            foreach (var category in values2)
            {
                var row = dt.NewRow();
                row["Kategori Id"] = category.CategoryId;
                row["Kategori Adı"] = category.CategoryName;
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

            txtCategoryId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtCategoryTitle.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
        }
    }
}
