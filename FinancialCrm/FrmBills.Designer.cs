namespace FinancialCrm
{
    partial class FrmBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBills));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtBillDate = new System.Windows.Forms.DateTimePicker();
            this.cmbBillCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemoveBill = new System.Windows.Forms.Button();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.btnBillList = new System.Windows.Forms.Button();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettingsForm = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.btnBankProcessForm = new System.Windows.Forms.Button();
            this.btnSpendingsForm = new System.Windows.Forms.Button();
            this.btnBillsForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategoriesForm = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "FATURALAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(188)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1539, 68);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(361, 408);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1163, 341);
            this.panel3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1163, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnUpdateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBill.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateBill.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateBill.Location = new System.Drawing.Point(889, 251);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(225, 53);
            this.btnUpdateBill.TabIndex = 8;
            this.btnUpdateBill.Text = "Fatura Güncelle";
            this.btnUpdateBill.UseVisualStyleBackColor = false;
            this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtBillDate);
            this.panel1.Controls.Add(this.cmbBillCategory);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnUpdateBill);
            this.panel1.Controls.Add(this.btnRemoveBill);
            this.panel1.Controls.Add(this.btnCreateBill);
            this.panel1.Controls.Add(this.btnBillList);
            this.panel1.Controls.Add(this.txtBillAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBillId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(361, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 328);
            this.panel1.TabIndex = 5;
            // 
            // dtBillDate
            // 
            this.dtBillDate.Font = new System.Drawing.Font("Corbel", 14F);
            this.dtBillDate.Location = new System.Drawing.Point(177, 186);
            this.dtBillDate.Name = "dtBillDate";
            this.dtBillDate.Size = new System.Drawing.Size(937, 42);
            this.dtBillDate.TabIndex = 4;
            // 
            // cmbBillCategory
            // 
            this.cmbBillCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbBillCategory.Font = new System.Drawing.Font("Corbel", 14F);
            this.cmbBillCategory.FormattingEnabled = true;
            this.cmbBillCategory.Location = new System.Drawing.Point(177, 77);
            this.cmbBillCategory.Name = "cmbBillCategory";
            this.cmbBillCategory.Size = new System.Drawing.Size(937, 43);
            this.cmbBillCategory.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(84, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tarih:";
            // 
            // btnRemoveBill
            // 
            this.btnRemoveBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnRemoveBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBill.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveBill.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveBill.Location = new System.Drawing.Point(652, 251);
            this.btnRemoveBill.Name = "btnRemoveBill";
            this.btnRemoveBill.Size = new System.Drawing.Size(225, 53);
            this.btnRemoveBill.TabIndex = 7;
            this.btnRemoveBill.Text = "Fatura Sil";
            this.btnRemoveBill.UseVisualStyleBackColor = false;
            this.btnRemoveBill.Click += new System.EventHandler(this.btnRemoveBill_Click);
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnCreateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBill.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateBill.ForeColor = System.Drawing.Color.Black;
            this.btnCreateBill.Location = new System.Drawing.Point(415, 251);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(225, 53);
            this.btnCreateBill.TabIndex = 6;
            this.btnCreateBill.Text = "Yeni Fatura";
            this.btnCreateBill.UseVisualStyleBackColor = false;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // btnBillList
            // 
            this.btnBillList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnBillList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillList.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnBillList.ForeColor = System.Drawing.Color.Black;
            this.btnBillList.Location = new System.Drawing.Point(177, 251);
            this.btnBillList.Name = "btnBillList";
            this.btnBillList.Size = new System.Drawing.Size(225, 53);
            this.btnBillList.TabIndex = 5;
            this.btnBillList.Text = "Fatura Listesi";
            this.btnBillList.UseVisualStyleBackColor = false;
            this.btnBillList.Click += new System.EventHandler(this.btnBillList_Click);
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBillAmount.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillAmount.Location = new System.Drawing.Point(177, 133);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(937, 42);
            this.txtBillAmount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(83, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fatura Adı:";
            // 
            // txtBillId
            // 
            this.txtBillId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBillId.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillId.Location = new System.Drawing.Point(177, 24);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(937, 42);
            this.txtBillId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fatura Id:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(-1, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 699);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.panel5.Controls.Add(this.lblUserFullName);
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Controls.Add(this.btnSettingsForm);
            this.panel5.Controls.Add(this.btnDashboardForm);
            this.panel5.Controls.Add(this.btnBankProcessForm);
            this.panel5.Controls.Add(this.btnSpendingsForm);
            this.panel5.Controls.Add(this.btnBillsForm);
            this.panel5.Controls.Add(this.btnBanksForm);
            this.panel5.Controls.Add(this.btnCategoriesForm);
            this.panel5.Location = new System.Drawing.Point(-1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(356, 699);
            this.panel5.TabIndex = 8;
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserFullName.ForeColor = System.Drawing.Color.Gray;
            this.lblUserFullName.Location = new System.Drawing.Point(103, 656);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(153, 29);
            this.lblUserFullName.TabIndex = 18;
            this.lblUserFullName.Text = "FinancialCRM";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(14, 574);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(330, 75);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "               Çıkış Yap";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettingsForm
            // 
            this.btnSettingsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsForm.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettingsForm.ForeColor = System.Drawing.Color.White;
            this.btnSettingsForm.Image = ((System.Drawing.Image)(resources.GetObject("btnSettingsForm.Image")));
            this.btnSettingsForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingsForm.Location = new System.Drawing.Point(14, 493);
            this.btnSettingsForm.Name = "btnSettingsForm";
            this.btnSettingsForm.Size = new System.Drawing.Size(330, 75);
            this.btnSettingsForm.TabIndex = 15;
            this.btnSettingsForm.Text = "               Ayarlar";
            this.btnSettingsForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettingsForm.UseVisualStyleBackColor = true;
            this.btnSettingsForm.Click += new System.EventHandler(this.btnSettingsForm_Click);
            // 
            // btnDashboardForm
            // 
            this.btnDashboardForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardForm.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboardForm.ForeColor = System.Drawing.Color.White;
            this.btnDashboardForm.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboardForm.Image")));
            this.btnDashboardForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboardForm.Location = new System.Drawing.Point(14, 412);
            this.btnDashboardForm.Name = "btnDashboardForm";
            this.btnDashboardForm.Size = new System.Drawing.Size(330, 75);
            this.btnDashboardForm.TabIndex = 14;
            this.btnDashboardForm.Text = "               Dashboard";
            this.btnDashboardForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboardForm.UseVisualStyleBackColor = true;
            this.btnDashboardForm.Click += new System.EventHandler(this.btnDashboardForm_Click);
            // 
            // btnBankProcessForm
            // 
            this.btnBankProcessForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProcessForm.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcessForm.ForeColor = System.Drawing.Color.White;
            this.btnBankProcessForm.Image = ((System.Drawing.Image)(resources.GetObject("btnBankProcessForm.Image")));
            this.btnBankProcessForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBankProcessForm.Location = new System.Drawing.Point(14, 331);
            this.btnBankProcessForm.Name = "btnBankProcessForm";
            this.btnBankProcessForm.Size = new System.Drawing.Size(330, 75);
            this.btnBankProcessForm.TabIndex = 13;
            this.btnBankProcessForm.Text = "               Banka Hareketleri";
            this.btnBankProcessForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBankProcessForm.UseVisualStyleBackColor = true;
            this.btnBankProcessForm.Click += new System.EventHandler(this.btnBankProcessForm_Click);
            // 
            // btnSpendingsForm
            // 
            this.btnSpendingsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingsForm.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingsForm.ForeColor = System.Drawing.Color.White;
            this.btnSpendingsForm.Image = ((System.Drawing.Image)(resources.GetObject("btnSpendingsForm.Image")));
            this.btnSpendingsForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpendingsForm.Location = new System.Drawing.Point(14, 250);
            this.btnSpendingsForm.Name = "btnSpendingsForm";
            this.btnSpendingsForm.Size = new System.Drawing.Size(330, 75);
            this.btnSpendingsForm.TabIndex = 12;
            this.btnSpendingsForm.Text = "               Harcamalar";
            this.btnSpendingsForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpendingsForm.UseVisualStyleBackColor = true;
            this.btnSpendingsForm.Click += new System.EventHandler(this.btnSpendingsForm_Click);
            // 
            // btnBillsForm
            // 
            this.btnBillsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillsForm.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillsForm.ForeColor = System.Drawing.Color.White;
            this.btnBillsForm.Image = ((System.Drawing.Image)(resources.GetObject("btnBillsForm.Image")));
            this.btnBillsForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillsForm.Location = new System.Drawing.Point(14, 169);
            this.btnBillsForm.Name = "btnBillsForm";
            this.btnBillsForm.Size = new System.Drawing.Size(330, 75);
            this.btnBillsForm.TabIndex = 11;
            this.btnBillsForm.Text = "               Faturalar";
            this.btnBillsForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBillsForm.UseVisualStyleBackColor = true;
            this.btnBillsForm.Click += new System.EventHandler(this.btnBillsForm_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Image = ((System.Drawing.Image)(resources.GetObject("btnBanksForm.Image")));
            this.btnBanksForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanksForm.Location = new System.Drawing.Point(14, 88);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(330, 75);
            this.btnBanksForm.TabIndex = 10;
            this.btnBanksForm.Text = "               Bankalar";
            this.btnBanksForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBanksForm.UseVisualStyleBackColor = true;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnCategoriesForm
            // 
            this.btnCategoriesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoriesForm.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoriesForm.ForeColor = System.Drawing.Color.White;
            this.btnCategoriesForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoriesForm.Image")));
            this.btnCategoriesForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoriesForm.Location = new System.Drawing.Point(14, 7);
            this.btnCategoriesForm.Name = "btnCategoriesForm";
            this.btnCategoriesForm.Size = new System.Drawing.Size(330, 75);
            this.btnCategoriesForm.TabIndex = 9;
            this.btnCategoriesForm.Text = "               Kategoriler";
            this.btnCategoriesForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategoriesForm.UseVisualStyleBackColor = true;
            this.btnCategoriesForm.Click += new System.EventHandler(this.btnCategoriesForm_Click);
            // 
            // FrmBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1536, 761);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faturalar Formu";
            this.Load += new System.EventHandler(this.FrmBills_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemoveBill;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Button btnBillList;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBillCategory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettingsForm;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Button btnBankProcessForm;
        private System.Windows.Forms.Button btnSpendingsForm;
        private System.Windows.Forms.Button btnBillsForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategoriesForm;
        private System.Windows.Forms.DateTimePicker dtBillDate;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}