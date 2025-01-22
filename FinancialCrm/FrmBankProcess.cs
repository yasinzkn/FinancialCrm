using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmBankProcess : Form
    {
        public FrmBankProcess()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBankProcess_Load(object sender, EventArgs e)
        {
            var bankTitle = db.Banks.ToList();
            cmbBanksName.Items.Clear();
            cmbBanksName.DisplayMember = "BankTitle";
            cmbBanksName.ValueMember = "BankId";
            cmbBanksName.DataSource = bankTitle;

            var bankProcessTypes = db.BankProcesses.Select(x => x.ProcessType).Distinct().ToList();
            cmbBankProcessType.Items.Clear();
            cmbBankProcessType.DisplayMember = "ProcessType";
            cmbBankProcessType.ValueMember = "BankProcessId";
            cmbBankProcessType.DataSource = bankProcessTypes;


            var bankProcesses = db.BankProcesses.OrderByDescending(x => x.BankProcessId).ToList();

            dataGridView1.DataSource = bankProcesses.Select(x => new
            {
                BankProcessId = x.BankProcessId,
                ProcessType = x.ProcessType,
                Description = x.Description,
                Amount = x.Amount,
                ProcessDate = x.ProcessDate,
                BankName = x.Banks.BankTitle
            }).ToList();

            dataGridView1.Columns["BankProcessId"].HeaderText = "İşlem Id";
            dataGridView1.Columns["ProcessType"].HeaderText = "İşlem Türü";
            dataGridView1.Columns["Description"].HeaderText = "Açıklama";
            dataGridView1.Columns["Amount"].HeaderText = "Tutar";
            dataGridView1.Columns["ProcessDate"].HeaderText = "İşlem Tarihi";
            dataGridView1.Columns["BankName"].HeaderText = "Banka Adı";
        }

        private void btnBankProcessList_Click(object sender, EventArgs e)
        {
            var bankProcesses = db.BankProcesses.OrderByDescending(x => x.BankProcessId).ToList();

            dataGridView1.DataSource = bankProcesses.Select(x => new
            {
                BankProcessId = x.BankProcessId,
                ProcessType = x.ProcessType,
                Description = x.Description,
                Amount = x.Amount,
                ProcessDate = x.ProcessDate,
                BankName = x.Banks.BankTitle
            }).ToList();

            dataGridView1.Columns["BankProcessId"].HeaderText = "İşlem Id";
            dataGridView1.Columns["ProcessType"].HeaderText = "İşlem Türü";
            dataGridView1.Columns["Description"].HeaderText = "Açıklama";
            dataGridView1.Columns["Amount"].HeaderText = "Tutar";
            dataGridView1.Columns["ProcessDate"].HeaderText = "İşlem Tarihi";
            dataGridView1.Columns["BankName"].HeaderText = "Banka Adı";
        }

        private void btnCreateBankProcess_Click(object sender, EventArgs e)
        {
            string type = cmbBankProcessType.Text;
            string date = dtBankProcessDate.Text;
            string description = txtBankProcessTitle.Text;
            decimal amount = decimal.Parse(txtBankProcessAmount.Text);
            string banks = cmbBanksName.Text;

            BankProcesses bankProcesses = new BankProcesses();
            bankProcesses.ProcessType = type;
            bankProcesses.ProcessDate = DateTime.Parse(date);
            bankProcesses.Description = description;
            bankProcesses.Amount = amount;

            var banksEntity = db.Banks.FirstOrDefault(x => x.BankTitle == banks);
            if (banksEntity != null)
            {
                bankProcesses.BankId = banksEntity.BankId;
            }
            db.BankProcesses.Add(bankProcesses);
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde eklendi", "İşlemler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var bankProcessesList = db.BankProcesses.OrderByDescending(x => x.BankProcessId).ToList();

            dataGridView1.DataSource = bankProcessesList.Select(x => new
            {
                bankProcessId = x.BankProcessId,
                ProcessType = x.ProcessType,
                Description = x.Description,
                Amount = x.Amount,
                ProcessDate = x.ProcessDate,
                BankName = x.Banks.BankTitle
            }).ToList();

            dataGridView1.Columns["BankProcessId"].HeaderText = "İşlem Id";
            dataGridView1.Columns["ProcessType"].HeaderText = "İşlem Türü";
            dataGridView1.Columns["Description"].HeaderText = "Açıklama";
            dataGridView1.Columns["Amount"].HeaderText = "Tutar";
            dataGridView1.Columns["ProcessDate"].HeaderText = "İşlem Tarihi";
            dataGridView1.Columns["BankName"].HeaderText = "Banka Adı";
        }

        private void btnRemoveBankProcess_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBankProcessId.Text);
            var removeValue = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde silindi", "İşlemler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var bankProcessesList = db.BankProcesses.OrderByDescending(x => x.BankProcessId).ToList();

            dataGridView1.DataSource = bankProcessesList.Select(x => new
            {
                bankProcessId = x.BankProcessId,
                ProcessType = x.ProcessType,
                Description = x.Description,
                Amount = x.Amount,
                ProcessDate = x.ProcessDate,
                BankName = x.Banks.BankTitle
            }).ToList();

            dataGridView1.Columns["BankProcessId"].HeaderText = "İşlem Id";
            dataGridView1.Columns["ProcessType"].HeaderText = "İşlem Türü";
            dataGridView1.Columns["Description"].HeaderText = "Açıklama";
            dataGridView1.Columns["Amount"].HeaderText = "Tutar";
            dataGridView1.Columns["ProcessDate"].HeaderText = "İşlem Tarihi";
            dataGridView1.Columns["BankName"].HeaderText = "Banka Adı";
        }

        private void btnUpdateBankProcess_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBankProcessId.Text);
            string type = cmbBankProcessType.Text;
            string date = dtBankProcessDate.Value.ToString("dd.MM.yyyy");
            string description = txtBankProcessTitle.Text;
            decimal amount = decimal.Parse(txtBankProcessAmount.Text);
            string banks = cmbBanksName.Text;

            var values = db.BankProcesses.Find(id);
            if (values != null)
            {
                values.ProcessType = type;
                values.ProcessDate = DateTime.Parse(date);
                values.Description = description;
                values.Amount = amount;

                var banksEntity = db.Banks.FirstOrDefault(x => x.BankTitle == banks);
                if (banksEntity != null)
                {
                    values.BankId = banksEntity.BankId;
                }
                else
                {
                    MessageBox.Show("İşlem bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.SaveChanges();
                MessageBox.Show("İşlem başarılı bir şekilde güncellendi", "İşlemler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("İşleme ait kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var bankProcessesList = db.BankProcesses.OrderByDescending(x => x.BankProcessId).ToList();

            dataGridView1.DataSource = bankProcessesList.Select(x => new
            {
                bankProcessId = x.BankProcessId,
                ProcessType = x.ProcessType,
                Description = x.Description,
                Amount = x.Amount,
                ProcessDate = x.ProcessDate,
                BankName = x.Banks.BankTitle
            }).ToList();

            dataGridView1.Columns["BankProcessId"].HeaderText = "İşlem Id";
            dataGridView1.Columns["ProcessType"].HeaderText = "İşlem Türü";
            dataGridView1.Columns["Description"].HeaderText = "Açıklama";
            dataGridView1.Columns["Amount"].HeaderText = "Tutar";
            dataGridView1.Columns["ProcessDate"].HeaderText = "İşlem Tarihi";
            dataGridView1.Columns["BankName"].HeaderText = "Banka Adı";
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

            txtBankProcessId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            cmbBankProcessType.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            dtBankProcessDate.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            txtBankProcessTitle.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            txtBankProcessAmount.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            cmbBanksName.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }
    }
}
