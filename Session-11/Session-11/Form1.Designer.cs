namespace Session_11 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnTransact = new System.Windows.Forms.Button();
            this.grvCustomer = new System.Windows.Forms.DataGridView();
            this.CustomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvPet = new System.Windows.Forms.DataGridView();
            this.PetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayBought = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PetBreed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvPetFood = new System.Windows.Forms.DataGridView();
            this.ptFoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pfPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvEmployees = new System.Windows.Forms.DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EmpSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cusDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grvTransaction = new System.Windows.Forms.DataGridView();
            this.colTransDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetFoodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransPetFoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransPetFoodQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engagePopulateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bsTransact = new System.Windows.Forms.BindingSource(this.components);
            this.grvPetReport = new System.Windows.Forms.DataGridView();
            this.PRyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRmonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRanimType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRtotalSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.bsPet = new System.Windows.Forms.BindingSource(this.components);
            this.bsPetFood = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
            this.btnPets = new System.Windows.Forms.Button();
            this.btnPetFood = new System.Windows.Forms.Button();
            this.btnPetReport = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.grvMonthly = new System.Windows.Forms.DataGridView();
            this.pad = new System.Windows.Forms.TabControl();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.btnDeleteEmployees = new System.Windows.Forms.Button();
            this.btnAddEmployees = new System.Windows.Forms.Button();
            this.tabPetFood = new System.Windows.Forms.TabPage();
            this.btnDeletePetFood = new System.Windows.Forms.Button();
            this.btnAddPetFood = new System.Windows.Forms.Button();
            this.tabPet = new System.Windows.Forms.TabPage();
            this.btnDeletePet = new System.Windows.Forms.Button();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.btnDeleteCustomers = new System.Windows.Forms.Button();
            this.btnAddCustomers = new System.Windows.Forms.Button();
            this.tabPetReport = new System.Windows.Forms.TabPage();
            this.btnAddPetReport = new System.Windows.Forms.Button();
            this.btnDeletePetReport = new System.Windows.Forms.Button();
            this.tabMonthLedg = new System.Windows.Forms.TabPage();
            this.tabTransactions = new System.Windows.Forms.TabPage();
            this.btnDeleteTransactions = new System.Windows.Forms.Button();
            this.btnAddTransactions = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.bsTransactCustomers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engagePopulateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonthly)).BeginInit();
            this.pad.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            this.tabPetFood.SuspendLayout();
            this.tabPet.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tabPetReport.SuspendLayout();
            this.tabMonthLedg.SuspendLayout();
            this.tabTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManage
            // 
            this.btnManage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManage.AutoSize = true;
            this.btnManage.BackgroundImage = global::Session_11.Properties.Resources.translogoo;
            this.btnManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManage.Location = new System.Drawing.Point(417, 70);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(114, 88);
            this.btnManage.TabIndex = 0;
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click_1);
            // 
            // btnTransact
            // 
            this.btnTransact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTransact.AutoSize = true;
            this.btnTransact.BackgroundImage = global::Session_11.Properties.Resources.shoplogo;
            this.btnTransact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTransact.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransact.Location = new System.Drawing.Point(1141, 70);
            this.btnTransact.Name = "btnTransact";
            this.btnTransact.Size = new System.Drawing.Size(122, 88);
            this.btnTransact.TabIndex = 1;
            this.btnTransact.UseVisualStyleBackColor = true;
            this.btnTransact.Click += new System.EventHandler(this.button2_Click);
            // 
            // grvCustomer
            // 
            this.grvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomID,
            this.CustomName,
            this.CustomSurname,
            this.CustomPhone,
            this.CustomTin});
            this.grvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvCustomer.Location = new System.Drawing.Point(0, 0);
            this.grvCustomer.Name = "grvCustomer";
            this.grvCustomer.RowTemplate.Height = 25;
            this.grvCustomer.Size = new System.Drawing.Size(1160, 318);
            this.grvCustomer.TabIndex = 2;
            this.grvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CustomID
            // 
            this.CustomID.DataPropertyName = "ID";
            this.CustomID.HeaderText = "Customer ID";
            this.CustomID.Name = "CustomID";
            this.CustomID.Visible = false;
            // 
            // CustomName
            // 
            this.CustomName.DataPropertyName = "Name";
            this.CustomName.HeaderText = "Name";
            this.CustomName.Name = "CustomName";
            // 
            // CustomSurname
            // 
            this.CustomSurname.DataPropertyName = "SurName";
            this.CustomSurname.HeaderText = "Surname";
            this.CustomSurname.Name = "CustomSurname";
            // 
            // CustomPhone
            // 
            this.CustomPhone.DataPropertyName = "Phone";
            this.CustomPhone.HeaderText = "Phone";
            this.CustomPhone.Name = "CustomPhone";
            // 
            // CustomTin
            // 
            this.CustomTin.DataPropertyName = "TIN";
            this.CustomTin.HeaderText = "TIN";
            this.CustomTin.Name = "CustomTin";
            // 
            // grvPet
            // 
            this.grvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PetID,
            this.DayBought,
            this.AnimalT,
            this.PetBreed,
            this.PetStat,
            this.PetPrice,
            this.PetCost});
            this.grvPet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvPet.Location = new System.Drawing.Point(0, 0);
            this.grvPet.Name = "grvPet";
            this.grvPet.RowTemplate.Height = 25;
            this.grvPet.Size = new System.Drawing.Size(1160, 318);
            this.grvPet.TabIndex = 3;
            this.grvPet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPet_CellContentClick);
            // 
            // PetID
            // 
            this.PetID.DataPropertyName = "ID";
            this.PetID.HeaderText = "PetID";
            this.PetID.Name = "PetID";
            this.PetID.Visible = false;
            // 
            // DayBought
            // 
            this.DayBought.DataPropertyName = "Bought";
            this.DayBought.HeaderText = "Purchase Date";
            this.DayBought.Name = "DayBought";
            // 
            // AnimalT
            // 
            this.AnimalT.DataPropertyName = "AnimalType";
            this.AnimalT.HeaderText = "Type";
            this.AnimalT.Name = "AnimalT";
            this.AnimalT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AnimalT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PetBreed
            // 
            this.PetBreed.DataPropertyName = "Breed";
            this.PetBreed.HeaderText = "Breed";
            this.PetBreed.Name = "PetBreed";
            // 
            // PetStat
            // 
            this.PetStat.DataPropertyName = "Petstatus";
            this.PetStat.HeaderText = "Health Status";
            this.PetStat.Name = "PetStat";
            this.PetStat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PetPrice
            // 
            this.PetPrice.DataPropertyName = "Price";
            this.PetPrice.HeaderText = "Price";
            this.PetPrice.Name = "PetPrice";
            // 
            // PetCost
            // 
            this.PetCost.DataPropertyName = "Cost";
            this.PetCost.HeaderText = "Cost";
            this.PetCost.Name = "PetCost";
            // 
            // grvPetFood
            // 
            this.grvPetFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvPetFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPetFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ptFoodId,
            this.AnimType,
            this.pfPrice,
            this.pfQty,
            this.colQty});
            this.grvPetFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvPetFood.Location = new System.Drawing.Point(3, 3);
            this.grvPetFood.Name = "grvPetFood";
            this.grvPetFood.RowTemplate.Height = 25;
            this.grvPetFood.Size = new System.Drawing.Size(1154, 312);
            this.grvPetFood.TabIndex = 11;
            // 
            // ptFoodId
            // 
            this.ptFoodId.DataPropertyName = "ID";
            this.ptFoodId.HeaderText = "Pet Food ID";
            this.ptFoodId.Name = "ptFoodId";
            this.ptFoodId.Visible = false;
            // 
            // AnimType
            // 
            this.AnimType.DataPropertyName = "AnimalType";
            this.AnimType.HeaderText = "Animal Type";
            this.AnimType.Name = "AnimType";
            this.AnimType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AnimType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pfPrice
            // 
            this.pfPrice.DataPropertyName = "Price";
            this.pfPrice.HeaderText = "Price";
            this.pfPrice.Name = "pfPrice";
            // 
            // pfQty
            // 
            this.pfQty.DataPropertyName = "Cost";
            this.pfQty.HeaderText = "Cost";
            this.pfQty.Name = "pfQty";
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "Quantity";
            this.colQty.Name = "colQty";
            // 
            // grvEmployees
            // 
            this.grvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.EmpName,
            this.EmpSurname,
            this.EmpType,
            this.EmpSalary,
            this.cusUpdate,
            this.cusDelete});
            this.grvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvEmployees.Location = new System.Drawing.Point(3, 3);
            this.grvEmployees.Name = "grvEmployees";
            this.grvEmployees.RowTemplate.Height = 25;
            this.grvEmployees.Size = new System.Drawing.Size(1154, 312);
            this.grvEmployees.TabIndex = 12;
            this.grvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvEmployees_CellContentClick);
            // 
            // EmpID
            // 
            this.EmpID.DataPropertyName = "ID";
            this.EmpID.HeaderText = "Employee ID";
            this.EmpID.Name = "EmpID";
            this.EmpID.Visible = false;
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "Name";
            this.EmpName.HeaderText = "Name";
            this.EmpName.Name = "EmpName";
            // 
            // EmpSurname
            // 
            this.EmpSurname.DataPropertyName = "Surname";
            this.EmpSurname.HeaderText = "Surname";
            this.EmpSurname.Name = "EmpSurname";
            // 
            // EmpType
            // 
            this.EmpType.DataPropertyName = "EmpType";
            this.EmpType.HeaderText = "Employee Post";
            this.EmpType.Name = "EmpType";
            this.EmpType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EmpSalary
            // 
            this.EmpSalary.DataPropertyName = "SalaryPerMonth";
            this.EmpSalary.HeaderText = "Salary";
            this.EmpSalary.Name = "EmpSalary";
            // 
            // cusUpdate
            // 
            this.cusUpdate.HeaderText = "Update";
            this.cusUpdate.Name = "cusUpdate";
            this.cusUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cusUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cusUpdate.Text = "Update";
            this.cusUpdate.ToolTipText = "Update";
            this.cusUpdate.UseColumnTextForButtonValue = true;
            // 
            // cusDelete
            // 
            this.cusDelete.HeaderText = "Delete";
            this.cusDelete.Name = "cusDelete";
            this.cusDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cusDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cusDelete.Text = "Delete";
            this.cusDelete.ToolTipText = "Delete";
            this.cusDelete.UseColumnTextForButtonValue = true;
            // 
            // grvTransaction
            // 
            this.grvTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransDate,
            this.ID,
            this.CustomerID,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.PetFoodID,
            this.colTransPetFoodPrice,
            this.colTransPetFoodQty,
            this.colTransTotalPrice});
            this.grvTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvTransaction.Location = new System.Drawing.Point(0, 0);
            this.grvTransaction.Name = "grvTransaction";
            this.grvTransaction.RowTemplate.Height = 25;
            this.grvTransaction.Size = new System.Drawing.Size(1160, 318);
            this.grvTransaction.TabIndex = 13;
            this.grvTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTransaction_CellContentClick);
            // 
            // colTransDate
            // 
            this.colTransDate.DataPropertyName = "Date";
            this.colTransDate.HeaderText = "Date";
            this.colTransDate.Name = "colTransDate";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Customer ID ";
            this.CustomerID.Name = "CustomerID";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Employee ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PetID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pet ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PetPrice";
            this.dataGridViewTextBoxColumn7.HeaderText = "Pet Price";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // PetFoodID
            // 
            this.PetFoodID.DataPropertyName = "PetFoodID";
            this.PetFoodID.HeaderText = "Pet food ID";
            this.PetFoodID.Name = "PetFoodID";
            // 
            // colTransPetFoodPrice
            // 
            this.colTransPetFoodPrice.DataPropertyName = "PetFoodPrice";
            this.colTransPetFoodPrice.HeaderText = "Pet Food Price";
            this.colTransPetFoodPrice.Name = "colTransPetFoodPrice";
            // 
            // colTransPetFoodQty
            // 
            this.colTransPetFoodQty.DataPropertyName = "PetFoodQty";
            this.colTransPetFoodQty.HeaderText = "Pet Food Quantity";
            this.colTransPetFoodQty.Name = "colTransPetFoodQty";
            // 
            // colTransTotalPrice
            // 
            this.colTransTotalPrice.DataPropertyName = "TotalPrice";
            this.colTransTotalPrice.HeaderText = "Total Price";
            this.colTransTotalPrice.Name = "colTransTotalPrice";
            // 
            // engagePopulateBindingSource
            // 
            this.engagePopulateBindingSource.DataSource = typeof(ClassLibrary1.PopulateClasses.EngagePopulate);
            // 
            // bsTransact
            // 
            this.bsTransact.DataSource = typeof(ClassLibrary1.PopulateClasses.EngagePopulate);
            this.bsTransact.CurrentChanged += new System.EventHandler(this.bsTransact_CurrentChanged);
            // 
            // grvPetReport
            // 
            this.grvPetReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvPetReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPetReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRyear,
            this.PRmonth,
            this.PRanimType,
            this.PRtotalSold});
            this.grvPetReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvPetReport.Location = new System.Drawing.Point(0, 0);
            this.grvPetReport.Name = "grvPetReport";
            this.grvPetReport.RowTemplate.Height = 25;
            this.grvPetReport.Size = new System.Drawing.Size(1160, 318);
            this.grvPetReport.TabIndex = 15;
            // 
            // PRyear
            // 
            this.PRyear.HeaderText = "Year";
            this.PRyear.Name = "PRyear";
            // 
            // PRmonth
            // 
            this.PRmonth.HeaderText = "Month";
            this.PRmonth.Name = "PRmonth";
            // 
            // PRanimType
            // 
            this.PRanimType.HeaderText = "Animal Type";
            this.PRanimType.Name = "PRanimType";
            // 
            // PRtotalSold
            // 
            this.PRtotalSold.HeaderText = "Total Sold";
            this.PRtotalSold.Name = "PRtotalSold";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(421, 525);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(119, 53);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(546, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 53);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bsEmployees
            // 
            this.bsEmployees.CurrentChanged += new System.EventHandler(this.bsEmployees_CurrentChanged);
            // 
            // btnPets
            // 
            this.btnPets.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPets.AutoSize = true;
            this.btnPets.BackgroundImage = global::Session_11.Properties.Resources.dg_shadow_removebg_preview;
            this.btnPets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPets.FlatAppearance.BorderSize = 0;
            this.btnPets.Location = new System.Drawing.Point(657, 70);
            this.btnPets.Name = "btnPets";
            this.btnPets.Size = new System.Drawing.Size(115, 88);
            this.btnPets.TabIndex = 18;
            this.btnPets.Text = "\r\n";
            this.btnPets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPets.UseVisualStyleBackColor = true;
            this.btnPets.Click += new System.EventHandler(this.btnPets_Click);
            // 
            // btnPetFood
            // 
            this.btnPetFood.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPetFood.AutoSize = true;
            this.btnPetFood.BackgroundImage = global::Session_11.Properties.Resources.dogbowl_removebg_preview;
            this.btnPetFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPetFood.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPetFood.Location = new System.Drawing.Point(537, 70);
            this.btnPetFood.Name = "btnPetFood";
            this.btnPetFood.Size = new System.Drawing.Size(114, 88);
            this.btnPetFood.TabIndex = 19;
            this.btnPetFood.UseVisualStyleBackColor = true;
            this.btnPetFood.Click += new System.EventHandler(this.btnPetFood_Click);
            // 
            // btnPetReport
            // 
            this.btnPetReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPetReport.AutoSize = true;
            this.btnPetReport.BackgroundImage = global::Session_11.Properties.Resources.PetReport_thumbnail;
            this.btnPetReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPetReport.FlatAppearance.BorderSize = 0;
            this.btnPetReport.Location = new System.Drawing.Point(899, 70);
            this.btnPetReport.Name = "btnPetReport";
            this.btnPetReport.Size = new System.Drawing.Size(115, 88);
            this.btnPetReport.TabIndex = 20;
            this.btnPetReport.Text = "\r\n";
            this.btnPetReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPetReport.UseVisualStyleBackColor = true;
            this.btnPetReport.Click += new System.EventHandler(this.btnPetReport_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCustomers.AutoSize = true;
            this.btnCustomers.BackgroundImage = global::Session_11.Properties.Resources.customer_thumbnail;
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.Location = new System.Drawing.Point(778, 70);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(115, 88);
            this.btnCustomers.TabIndex = 22;
            this.btnCustomers.Text = "\r\n";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnMonthly
            // 
            this.btnMonthly.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMonthly.AutoSize = true;
            this.btnMonthly.BackgroundImage = global::Session_11.Properties.Resources.calendar2_thumbnail;
            this.btnMonthly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonthly.FlatAppearance.BorderSize = 0;
            this.btnMonthly.Location = new System.Drawing.Point(1020, 70);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(115, 88);
            this.btnMonthly.TabIndex = 23;
            this.btnMonthly.Text = "\r\n";
            this.btnMonthly.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMonthly.UseVisualStyleBackColor = true;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // grvMonthly
            // 
            this.grvMonthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvMonthly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvMonthly.Location = new System.Drawing.Point(0, 0);
            this.grvMonthly.Name = "grvMonthly";
            this.grvMonthly.RowTemplate.Height = 25;
            this.grvMonthly.Size = new System.Drawing.Size(1160, 318);
            this.grvMonthly.TabIndex = 25;
            this.grvMonthly.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvMonthly_CellContentClick);
            // 
            // pad
            // 
            this.pad.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.pad.Controls.Add(this.tabEmployees);
            this.pad.Controls.Add(this.tabPetFood);
            this.pad.Controls.Add(this.tabPet);
            this.pad.Controls.Add(this.tabCustomers);
            this.pad.Controls.Add(this.tabPetReport);
            this.pad.Controls.Add(this.tabMonthLedg);
            this.pad.Controls.Add(this.tabTransactions);
            this.pad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pad.Location = new System.Drawing.Point(417, 162);
            this.pad.Name = "pad";
            this.pad.SelectedIndex = 0;
            this.pad.Size = new System.Drawing.Size(1168, 364);
            this.pad.TabIndex = 26;
            // 
            // tabEmployees
            // 
            this.tabEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabEmployees.Controls.Add(this.btnDeleteEmployees);
            this.tabEmployees.Controls.Add(this.btnAddEmployees);
            this.tabEmployees.Controls.Add(this.grvEmployees);
            this.tabEmployees.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabEmployees.Location = new System.Drawing.Point(4, 42);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(1160, 318);
            this.tabEmployees.TabIndex = 0;
            this.tabEmployees.Text = "Employees";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployees
            // 
            this.btnDeleteEmployees.Location = new System.Drawing.Point(1027, 248);
            this.btnDeleteEmployees.Name = "btnDeleteEmployees";
            this.btnDeleteEmployees.Size = new System.Drawing.Size(119, 53);
            this.btnDeleteEmployees.TabIndex = 17;
            this.btnDeleteEmployees.Text = "Delete";
            this.btnDeleteEmployees.UseVisualStyleBackColor = true;
            this.btnDeleteEmployees.Click += new System.EventHandler(this.btnDeleteEmployees_Click);
            // 
            // btnAddEmployees
            // 
            this.btnAddEmployees.Location = new System.Drawing.Point(902, 248);
            this.btnAddEmployees.Name = "btnAddEmployees";
            this.btnAddEmployees.Size = new System.Drawing.Size(119, 53);
            this.btnAddEmployees.TabIndex = 16;
            this.btnAddEmployees.Text = "Add";
            this.btnAddEmployees.UseVisualStyleBackColor = true;
            this.btnAddEmployees.Click += new System.EventHandler(this.btnAddEmployees_Click);
            // 
            // tabPetFood
            // 
            this.tabPetFood.Controls.Add(this.btnDeletePetFood);
            this.tabPetFood.Controls.Add(this.btnAddPetFood);
            this.tabPetFood.Controls.Add(this.grvPetFood);
            this.tabPetFood.Location = new System.Drawing.Point(4, 42);
            this.tabPetFood.Name = "tabPetFood";
            this.tabPetFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabPetFood.Size = new System.Drawing.Size(1160, 318);
            this.tabPetFood.TabIndex = 1;
            this.tabPetFood.Text = "Pet Food";
            this.tabPetFood.UseVisualStyleBackColor = true;
            // 
            // btnDeletePetFood
            // 
            this.btnDeletePetFood.Location = new System.Drawing.Point(1021, 245);
            this.btnDeletePetFood.Name = "btnDeletePetFood";
            this.btnDeletePetFood.Size = new System.Drawing.Size(119, 53);
            this.btnDeletePetFood.TabIndex = 15;
            this.btnDeletePetFood.Text = "Delete";
            this.btnDeletePetFood.UseVisualStyleBackColor = true;
            this.btnDeletePetFood.Click += new System.EventHandler(this.btnDeletePetFood_Click);
            // 
            // btnAddPetFood
            // 
            this.btnAddPetFood.Location = new System.Drawing.Point(896, 245);
            this.btnAddPetFood.Name = "btnAddPetFood";
            this.btnAddPetFood.Size = new System.Drawing.Size(119, 53);
            this.btnAddPetFood.TabIndex = 14;
            this.btnAddPetFood.Text = "Add";
            this.btnAddPetFood.UseVisualStyleBackColor = true;
            this.btnAddPetFood.Click += new System.EventHandler(this.btnAddPetFood_Click);
            // 
            // tabPet
            // 
            this.tabPet.Controls.Add(this.btnDeletePet);
            this.tabPet.Controls.Add(this.btnAddPet);
            this.tabPet.Controls.Add(this.grvPet);
            this.tabPet.Location = new System.Drawing.Point(4, 42);
            this.tabPet.Name = "tabPet";
            this.tabPet.Size = new System.Drawing.Size(1160, 318);
            this.tabPet.TabIndex = 2;
            this.tabPet.Text = "Pet";
            this.tabPet.UseVisualStyleBackColor = true;
            // 
            // btnDeletePet
            // 
            this.btnDeletePet.Location = new System.Drawing.Point(1029, 251);
            this.btnDeletePet.Name = "btnDeletePet";
            this.btnDeletePet.Size = new System.Drawing.Size(119, 53);
            this.btnDeletePet.TabIndex = 5;
            this.btnDeletePet.Text = "Delete";
            this.btnDeletePet.UseVisualStyleBackColor = true;
            this.btnDeletePet.Click += new System.EventHandler(this.btnDeletePet_Click);
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(901, 251);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(119, 53);
            this.btnAddPet.TabIndex = 4;
            this.btnAddPet.Text = "Add";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.btnDeleteCustomers);
            this.tabCustomers.Controls.Add(this.btnAddCustomers);
            this.tabCustomers.Controls.Add(this.grvCustomer);
            this.tabCustomers.Location = new System.Drawing.Point(4, 42);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Size = new System.Drawing.Size(1160, 318);
            this.tabCustomers.TabIndex = 3;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomers
            // 
            this.btnDeleteCustomers.Location = new System.Drawing.Point(1027, 251);
            this.btnDeleteCustomers.Name = "btnDeleteCustomers";
            this.btnDeleteCustomers.Size = new System.Drawing.Size(119, 53);
            this.btnDeleteCustomers.TabIndex = 17;
            this.btnDeleteCustomers.Text = "Delete";
            this.btnDeleteCustomers.UseVisualStyleBackColor = true;
            this.btnDeleteCustomers.Click += new System.EventHandler(this.btnDeleteCustomers_Click);
            // 
            // btnAddCustomers
            // 
            this.btnAddCustomers.Location = new System.Drawing.Point(902, 251);
            this.btnAddCustomers.Name = "btnAddCustomers";
            this.btnAddCustomers.Size = new System.Drawing.Size(119, 53);
            this.btnAddCustomers.TabIndex = 16;
            this.btnAddCustomers.Text = "Add";
            this.btnAddCustomers.UseVisualStyleBackColor = true;
            this.btnAddCustomers.Click += new System.EventHandler(this.btnAddCustomers_Click);
            // 
            // tabPetReport
            // 
            this.tabPetReport.Controls.Add(this.btnAddPetReport);
            this.tabPetReport.Controls.Add(this.btnDeletePetReport);
            this.tabPetReport.Controls.Add(this.grvPetReport);
            this.tabPetReport.Location = new System.Drawing.Point(4, 42);
            this.tabPetReport.Name = "tabPetReport";
            this.tabPetReport.Size = new System.Drawing.Size(1160, 318);
            this.tabPetReport.TabIndex = 4;
            this.tabPetReport.Text = "Pet Report";
            this.tabPetReport.UseVisualStyleBackColor = true;
            // 
            // btnAddPetReport
            // 
            this.btnAddPetReport.Location = new System.Drawing.Point(903, 251);
            this.btnAddPetReport.Name = "btnAddPetReport";
            this.btnAddPetReport.Size = new System.Drawing.Size(119, 53);
            this.btnAddPetReport.TabIndex = 20;
            this.btnAddPetReport.Text = "Add";
            this.btnAddPetReport.UseVisualStyleBackColor = true;
            this.btnAddPetReport.Click += new System.EventHandler(this.btnAddPetReport_Click);
            // 
            // btnDeletePetReport
            // 
            this.btnDeletePetReport.Location = new System.Drawing.Point(1028, 251);
            this.btnDeletePetReport.Name = "btnDeletePetReport";
            this.btnDeletePetReport.Size = new System.Drawing.Size(119, 53);
            this.btnDeletePetReport.TabIndex = 19;
            this.btnDeletePetReport.Text = "Delete";
            this.btnDeletePetReport.UseVisualStyleBackColor = true;
            this.btnDeletePetReport.Click += new System.EventHandler(this.btnDeletePetReport_Click);
            // 
            // tabMonthLedg
            // 
            this.tabMonthLedg.Controls.Add(this.grvMonthly);
            this.tabMonthLedg.Location = new System.Drawing.Point(4, 42);
            this.tabMonthLedg.Name = "tabMonthLedg";
            this.tabMonthLedg.Size = new System.Drawing.Size(1160, 318);
            this.tabMonthLedg.TabIndex = 5;
            this.tabMonthLedg.Text = "Monthly Ledger";
            this.tabMonthLedg.UseVisualStyleBackColor = true;
            // 
            // tabTransactions
            // 
            this.tabTransactions.Controls.Add(this.btnDeleteTransactions);
            this.tabTransactions.Controls.Add(this.btnAddTransactions);
            this.tabTransactions.Controls.Add(this.grvTransaction);
            this.tabTransactions.Location = new System.Drawing.Point(4, 42);
            this.tabTransactions.Name = "tabTransactions";
            this.tabTransactions.Size = new System.Drawing.Size(1160, 318);
            this.tabTransactions.TabIndex = 6;
            this.tabTransactions.Text = "Transactions";
            this.tabTransactions.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTransactions
            // 
            this.btnDeleteTransactions.Location = new System.Drawing.Point(1030, 251);
            this.btnDeleteTransactions.Name = "btnDeleteTransactions";
            this.btnDeleteTransactions.Size = new System.Drawing.Size(119, 53);
            this.btnDeleteTransactions.TabIndex = 17;
            this.btnDeleteTransactions.Text = "Delete";
            this.btnDeleteTransactions.UseVisualStyleBackColor = true;
            this.btnDeleteTransactions.Click += new System.EventHandler(this.btnDeleteTransactions_Click);
            // 
            // btnAddTransactions
            // 
            this.btnAddTransactions.Location = new System.Drawing.Point(905, 251);
            this.btnAddTransactions.Name = "btnAddTransactions";
            this.btnAddTransactions.Size = new System.Drawing.Size(119, 53);
            this.btnAddTransactions.TabIndex = 16;
            this.btnAddTransactions.Text = "Add";
            this.btnAddTransactions.UseVisualStyleBackColor = true;
            this.btnAddTransactions.Click += new System.EventHandler(this.btnAddTransactions_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(671, 525);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 53);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1881, 855);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pad);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnPetReport);
            this.Controls.Add(this.btnPetFood);
            this.Controls.Add(this.btnPets);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTransact);
            this.Controls.Add(this.btnManage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engagePopulateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonthly)).EndInit();
            this.pad.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            this.tabPetFood.ResumeLayout(false);
            this.tabPet.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.tabPetReport.ResumeLayout(false);
            this.tabMonthLedg.ResumeLayout(false);
            this.tabTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnManage;
        private Button btnTransact;
        private DataGridView grvCustomer;
        private DataGridView grvPet;
        private DataGridView grvPetFood;
        private DataGridView grvEmployees;
        private DataGridView grvTransaction;
        private DataGridView grvPetReport;
        private DataGridViewTextBoxColumn PRyear;
        private DataGridViewTextBoxColumn PRmonth;
        private DataGridViewTextBoxColumn PRanimType;
        private DataGridViewTextBoxColumn PRtotalSold;
        private BindingSource bsCustomer;
        private DataGridViewTextBoxColumn CustomID;
        private DataGridViewTextBoxColumn CustomName;
        private DataGridViewTextBoxColumn CustomSurname;
        private DataGridViewTextBoxColumn CustomPhone;
        private DataGridViewTextBoxColumn CustomTin;
        private BindingSource bsPet;
        private BindingSource bsPetFood;
        private BindingSource bsTransact;
        private Button btnLoad;
        private Button btnSave;
        private BindingSource bsEmployees;
        private DataGridViewTextBoxColumn QtyLeft;
        private DataGridViewTextBoxColumn trDate;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn PetFoodQty;
        private DataGridViewTextBoxColumn pFoodPrice;
        private DataGridViewTextBoxColumn TotalP;
        private DataGridViewTextBoxColumn TransacID;
        private DataGridViewTextBoxColumn trEmplID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private Button btnPets;
        private Button btnPetFood;
        private DataGridViewTextBoxColumn ptFoodId;
        private DataGridViewComboBoxColumn AnimType;
        private DataGridViewTextBoxColumn pfPrice;
        private DataGridViewTextBoxColumn pfQty;
        private DataGridViewTextBoxColumn colQty;
        private Button btnPetReport;
        private Button btnCustomers;
        private Button btnMonthly;
        private DataGridView grvMonthly;
        private DataGridViewTextBoxColumn EmpID;
        private DataGridViewTextBoxColumn EmpName;
        private DataGridViewTextBoxColumn EmpSurname;
        private DataGridViewComboBoxColumn EmpType;
        private DataGridViewTextBoxColumn EmpSalary;
        private DataGridViewButtonColumn cusUpdate;
        private DataGridViewButtonColumn cusDelete;
        private DataGridViewTextBoxColumn PetID;
        private DataGridViewTextBoxColumn DayBought;
        private DataGridViewComboBoxColumn AnimalT;
        private DataGridViewTextBoxColumn PetBreed;
        private DataGridViewTextBoxColumn PetStat;
        private DataGridViewTextBoxColumn PetPrice;
        private DataGridViewTextBoxColumn PetCost;
        private TabControl pad;
        private TabPage tabEmployees;
        private TabPage tabPetFood;
        private TabPage tabPet;
        private TabPage tabCustomers;
        private TabPage tabPetReport;
        private TabPage tabMonthLedg;
        private TabPage tabTransactions;
        private Button btnDeletePet;
        private Button btnAddPet;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn monYear;
        private DataGridViewTextBoxColumn monMonth;
        private Button btnDeleteEmployees;
        private Button btnAddEmployees;
        private Button btnDeletePetFood;
        private Button btnAddPetFood;
        private Button btnDeleteCustomers;
        private Button btnAddCustomers;
        private Button btnDeletePetReport;
        private Button btnDeleteTransactions;
        private Button btnAddTransactions;
        private Button btnAddPetReport;
        private BindingSource bsTransactCustomers;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private BindingSource engagePopulateBindingSource;
        private DataGridViewTextBoxColumn colTransDate;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn PetFoodID;
        private DataGridViewTextBoxColumn colTransPetFoodPrice;
        private DataGridViewTextBoxColumn colTransPetFoodQty;
        private DataGridViewTextBoxColumn colTransTotalPrice;
    }
}