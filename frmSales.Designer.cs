namespace BestShop
{
    partial class frmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTop = new System.Windows.Forms.Label();
            this.grbDealerOrCostumor = new System.Windows.Forms.GroupBox();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grbProduct = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.lblInventory = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.grbDataGrivView = new System.Windows.Forms.GroupBox();
            this.dgvAddedProducts = new System.Windows.Forms.DataGridView();
            this.grbCalculation = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtReturnAmount = new System.Windows.Forms.TextBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblReturnAmount = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grbDealerOrCostumor.SuspendLayout();
            this.grbProduct.SuspendLayout();
            this.grbDataGrivView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).BeginInit();
            this.grbCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 75);
            this.panel1.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(970, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 46);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Повернутися";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.lblTop.Location = new System.Drawing.Point(496, 10);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(117, 37);
            this.lblTop.TabIndex = 7;
            this.lblTop.Text = "Продаж";
            // 
            // grbDealerOrCostumor
            // 
            this.grbDealerOrCostumor.Controls.Add(this.dtpBillDate);
            this.grbDealerOrCostumor.Controls.Add(this.txtAddress);
            this.grbDealerOrCostumor.Controls.Add(this.txtName);
            this.grbDealerOrCostumor.Controls.Add(this.txtContact);
            this.grbDealerOrCostumor.Controls.Add(this.txtEmail);
            this.grbDealerOrCostumor.Controls.Add(this.txtSearch);
            this.grbDealerOrCostumor.Controls.Add(this.lblAddress);
            this.grbDealerOrCostumor.Controls.Add(this.lblBillDate);
            this.grbDealerOrCostumor.Controls.Add(this.lblContact);
            this.grbDealerOrCostumor.Controls.Add(this.lblEmail);
            this.grbDealerOrCostumor.Controls.Add(this.lblName);
            this.grbDealerOrCostumor.Controls.Add(this.lblSearch);
            this.grbDealerOrCostumor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbDealerOrCostumor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbDealerOrCostumor.Location = new System.Drawing.Point(12, 82);
            this.grbDealerOrCostumor.Name = "grbDealerOrCostumor";
            this.grbDealerOrCostumor.Size = new System.Drawing.Size(1093, 113);
            this.grbDealerOrCostumor.TabIndex = 9;
            this.grbDealerOrCostumor.TabStop = false;
            this.grbDealerOrCostumor.Text = "Інформація про постачальника";
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBillDate.Location = new System.Drawing.Point(940, 23);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(147, 25);
            this.dtpBillDate.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.Location = new System.Drawing.Point(646, 23);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(188, 73);
            this.txtAddress.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(87, 71);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(188, 25);
            this.txtName.TabIndex = 10;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContact.Location = new System.Drawing.Point(377, 71);
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(188, 25);
            this.txtContact.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.Location = new System.Drawing.Point(377, 23);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(188, 25);
            this.txtEmail.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(87, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 25);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddress.Location = new System.Drawing.Point(589, 26);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 17);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Адреса";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBillDate.Location = new System.Drawing.Point(848, 26);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(86, 17);
            this.lblBillDate.TabIndex = 4;
            this.lblBillDate.Text = "Дата рахунку";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContact.Location = new System.Drawing.Point(300, 74);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(54, 17);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Контакт";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.Location = new System.Drawing.Point(300, 26);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(40, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "EMail";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(16, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(30, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ім\'я";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearch.Location = new System.Drawing.Point(16, 26);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Пошук";
            // 
            // grbProduct
            // 
            this.grbProduct.Controls.Add(this.btnAdd);
            this.grbProduct.Controls.Add(this.txtQty);
            this.grbProduct.Controls.Add(this.txtNameProduct);
            this.grbProduct.Controls.Add(this.txtInventory);
            this.grbProduct.Controls.Add(this.lblQty);
            this.grbProduct.Controls.Add(this.txtSearchProduct);
            this.grbProduct.Controls.Add(this.lblInventory);
            this.grbProduct.Controls.Add(this.txtRate);
            this.grbProduct.Controls.Add(this.lblProductName);
            this.grbProduct.Controls.Add(this.lblRate);
            this.grbProduct.Controls.Add(this.lblSearchProduct);
            this.grbProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbProduct.Location = new System.Drawing.Point(12, 197);
            this.grbProduct.Name = "grbProduct";
            this.grbProduct.Size = new System.Drawing.Size(1093, 68);
            this.grbProduct.TabIndex = 10;
            this.grbProduct.TabStop = false;
            this.grbProduct.Text = "Інформація про товар";
            this.grbProduct.Enter += new System.EventHandler(this.grbProduct_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.Navy;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(946, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 45);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Додати";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQty.Location = new System.Drawing.Point(827, 27);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(90, 25);
            this.txtQty.TabIndex = 12;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameProduct.Location = new System.Drawing.Point(254, 27);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.ReadOnly = true;
            this.txtNameProduct.Size = new System.Drawing.Size(125, 25);
            this.txtNameProduct.TabIndex = 9;
            // 
            // txtInventory
            // 
            this.txtInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInventory.Location = new System.Drawing.Point(480, 28);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.ReadOnly = true;
            this.txtInventory.Size = new System.Drawing.Size(125, 25);
            this.txtInventory.TabIndex = 13;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQty.Location = new System.Drawing.Point(761, 30);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(60, 17);
            this.lblQty.TabIndex = 7;
            this.lblQty.Text = "Кількість";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchProduct.Location = new System.Drawing.Point(70, 27);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(125, 25);
            this.txtSearchProduct.TabIndex = 8;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInventory.Location = new System.Drawing.Point(405, 30);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(71, 17);
            this.lblInventory.TabIndex = 6;
            this.lblInventory.Text = "Статистика";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRate.Location = new System.Drawing.Point(664, 27);
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(90, 25);
            this.txtRate.TabIndex = 10;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductName.Location = new System.Drawing.Point(204, 30);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(44, 17);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Tag = "Назва";
            this.lblProductName.Text = "Назва";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRate.Location = new System.Drawing.Point(623, 30);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(35, 17);
            this.lblRate.TabIndex = 3;
            this.lblRate.Text = "Ціна";
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchProduct.Location = new System.Drawing.Point(16, 30);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(48, 17);
            this.lblSearchProduct.TabIndex = 2;
            this.lblSearchProduct.Text = "Пошук";
            // 
            // grbDataGrivView
            // 
            this.grbDataGrivView.Controls.Add(this.dgvAddedProducts);
            this.grbDataGrivView.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbDataGrivView.Location = new System.Drawing.Point(12, 271);
            this.grbDataGrivView.Name = "grbDataGrivView";
            this.grbDataGrivView.Size = new System.Drawing.Size(541, 361);
            this.grbDataGrivView.TabIndex = 11;
            this.grbDataGrivView.TabStop = false;
            this.grbDataGrivView.Text = "Доданий продукт";
            // 
            // dgvAddedProducts
            // 
            this.dgvAddedProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddedProducts.Location = new System.Drawing.Point(7, 25);
            this.dgvAddedProducts.Name = "dgvAddedProducts";
            this.dgvAddedProducts.Size = new System.Drawing.Size(528, 330);
            this.dgvAddedProducts.TabIndex = 0;
            // 
            // grbCalculation
            // 
            this.grbCalculation.Controls.Add(this.btnSave);
            this.grbCalculation.Controls.Add(this.txtReturnAmount);
            this.grbCalculation.Controls.Add(this.txtPaidAmount);
            this.grbCalculation.Controls.Add(this.txtGrandTotal);
            this.grbCalculation.Controls.Add(this.txtDiscount);
            this.grbCalculation.Controls.Add(this.txtSubTotal);
            this.grbCalculation.Controls.Add(this.lblReturnAmount);
            this.grbCalculation.Controls.Add(this.lblPaidAmount);
            this.grbCalculation.Controls.Add(this.lblGrandTotal);
            this.grbCalculation.Controls.Add(this.lblDiscount);
            this.grbCalculation.Controls.Add(this.lblSubTotal);
            this.grbCalculation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbCalculation.Location = new System.Drawing.Point(580, 271);
            this.grbCalculation.Name = "grbCalculation";
            this.grbCalculation.Size = new System.Drawing.Size(524, 361);
            this.grbCalculation.TabIndex = 12;
            this.grbCalculation.TabStop = false;
            this.grbCalculation.Text = "Деталі розрахунку";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.Navy;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(186, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(304, 45);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "ПРОДАЖ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtReturnAmount
            // 
            this.txtReturnAmount.BackColor = System.Drawing.Color.White;
            this.txtReturnAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtReturnAmount.ForeColor = System.Drawing.Color.DarkRed;
            this.txtReturnAmount.Location = new System.Drawing.Point(186, 219);
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.ReadOnly = true;
            this.txtReturnAmount.Size = new System.Drawing.Size(304, 39);
            this.txtReturnAmount.TabIndex = 14;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPaidAmount.Location = new System.Drawing.Point(186, 168);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(304, 25);
            this.txtPaidAmount.TabIndex = 13;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGrandTotal.Location = new System.Drawing.Point(186, 124);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(304, 25);
            this.txtGrandTotal.TabIndex = 12;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDiscount.Location = new System.Drawing.Point(186, 78);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(304, 25);
            this.txtDiscount.TabIndex = 10;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSubTotal.Location = new System.Drawing.Point(186, 34);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(304, 25);
            this.txtSubTotal.TabIndex = 9;
            this.txtSubTotal.Text = "0";
            // 
            // lblReturnAmount
            // 
            this.lblReturnAmount.AutoSize = true;
            this.lblReturnAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturnAmount.Location = new System.Drawing.Point(10, 232);
            this.lblReturnAmount.Name = "lblReturnAmount";
            this.lblReturnAmount.Size = new System.Drawing.Size(114, 17);
            this.lblReturnAmount.TabIndex = 8;
            this.lblReturnAmount.Text = "Сума повернення";
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPaidAmount.Location = new System.Drawing.Point(9, 173);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(97, 17);
            this.lblPaidAmount.TabIndex = 7;
            this.lblPaidAmount.Text = "Сплачена сума";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGrandTotal.Location = new System.Drawing.Point(10, 128);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(94, 17);
            this.lblGrandTotal.TabIndex = 6;
            this.lblGrandTotal.Text = "Загальна сума";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscount.Location = new System.Drawing.Point(9, 80);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(74, 17);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "Знижка (%)";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubTotal.Location = new System.Drawing.Point(9, 35);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(109, 17);
            this.lblSubTotal.TabIndex = 3;
            this.lblSubTotal.Text = "Сума без знижки";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1117, 638);
            this.Controls.Add(this.grbCalculation);
            this.Controls.Add(this.grbDataGrivView);
            this.Controls.Add(this.grbProduct);
            this.Controls.Add(this.grbDealerOrCostumor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSales";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbDealerOrCostumor.ResumeLayout(false);
            this.grbDealerOrCostumor.PerformLayout();
            this.grbProduct.ResumeLayout(false);
            this.grbProduct.PerformLayout();
            this.grbDataGrivView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).EndInit();
            this.grbCalculation.ResumeLayout(false);
            this.grbCalculation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.GroupBox grbDealerOrCostumor;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox grbProduct;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.GroupBox grbDataGrivView;
        private System.Windows.Forms.DataGridView dgvAddedProducts;
        private System.Windows.Forms.GroupBox grbCalculation;
        private System.Windows.Forms.TextBox txtReturnAmount;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblReturnAmount;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
    }
}