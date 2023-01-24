namespace Session_11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnManage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grvCustomer = new System.Windows.Forms.DataGridView();
            this.CustomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvPet = new System.Windows.Forms.DataGridView();
            this.PetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PetBreed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grvPetFood = new System.Windows.Forms.DataGridView();
            this.grvEmployees = new System.Windows.Forms.DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EmpSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvTransaction = new System.Windows.Forms.DataGridView();
            this.colTransDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransCustomerSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransPet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransPetFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransPetFoodQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransPetFoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvPetReport = new System.Windows.Forms.DataGridView();
            this.PRyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRmonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRanimType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRtotalSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.bsPet = new System.Windows.Forms.BindingSource(this.components);
            this.bsPetFood = new System.Windows.Forms.BindingSource(this.components);
            this.bsTransact = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
            this.btnPets = new System.Windows.Forms.Button();
<<<<<<< HEAD
=======
            this.ptFoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pfPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
>>>>>>> 648d4bb196f8c900fb9f976e9912dc95f7f08bee
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManage
            // 
            this.btnManage.BackgroundImage = global::Session_11.Properties.Resources.translogoo;
            this.btnManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManage.Location = new System.Drawing.Point(150, 116);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(161, 105);
            this.btnManage.TabIndex = 0;
            this.btnManage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Session_11.Properties.Resources.shoplogo;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(695, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 105);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grvCustomer
            // 
            this.grvCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomID,
            this.CustomName,
            this.CustomSurname,
            this.CustomPhone,
            this.CustomTin});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvCustomer.Location = new System.Drawing.Point(12, 452);
            this.grvCustomer.Name = "grvCustomer";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvCustomer.RowTemplate.Height = 25;
            this.grvCustomer.Size = new System.Drawing.Size(500, 134);
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
            this.grvPet.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvPet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PetID,
            this.AnimalT,
            this.PetBreed,
            this.PetStat,
            this.PetPrice,
            this.PetCost});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvPet.DefaultCellStyle = dataGridViewCellStyle5;
            this.grvPet.Location = new System.Drawing.Point(1327, 240);
            this.grvPet.Name = "grvPet";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvPet.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grvPet.RowTemplate.Height = 25;
            this.grvPet.Size = new System.Drawing.Size(542, 157);
            this.grvPet.TabIndex = 3;
            this.grvPet.Visible = false;
            // 
            // PetID
            // 
            this.PetID.DataPropertyName = "ID";
            this.PetID.HeaderText = "PetID";
            this.PetID.Name = "PetID";
            this.PetID.Visible = false;
            // 
            // AnimalT
            // 
            this.AnimalT.DisplayStyleForCurrentCellOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1327, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1327, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pet Food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 644);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Transactions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1327, 644);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Pet Report";
            // 
            // grvPetFood
            // 
            this.grvPetFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grvPetFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvPetFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grvPetFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPetFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ptFoodId,
            this.AnimType,
            this.pfPrice,
            this.pfQty,
            this.colQty});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvPetFood.DefaultCellStyle = dataGridViewCellStyle8;
            this.grvPetFood.Location = new System.Drawing.Point(1327, 452);
            this.grvPetFood.Name = "grvPetFood";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvPetFood.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grvPetFood.RowTemplate.Height = 25;
            this.grvPetFood.Size = new System.Drawing.Size(542, 134);
            this.grvPetFood.TabIndex = 11;
            // 
            // grvEmployees
            // 
            this.grvEmployees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.EmpName,
            this.EmpSurname,
            this.EmpType,
            this.EmpSalary});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvEmployees.DefaultCellStyle = dataGridViewCellStyle11;
            this.grvEmployees.Location = new System.Drawing.Point(12, 258);
            this.grvEmployees.Name = "grvEmployees";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grvEmployees.RowTemplate.Height = 25;
            this.grvEmployees.Size = new System.Drawing.Size(500, 134);
            this.grvEmployees.TabIndex = 12;
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
            // grvTransaction
            // 
            this.grvTransaction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grvTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransDate,
            this.colTransCustomerName,
            this.colTransCustomerSurname,
            this.colTransEmployee,
            this.colTransPet,
            this.dataGridViewTextBoxColumn4,
            this.colTransPetFood,
            this.colTransPetFoodQty,
            this.colTransPetFoodPrice,
            this.colTransTotalPrice});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvTransaction.DefaultCellStyle = dataGridViewCellStyle14;
            this.grvTransaction.Location = new System.Drawing.Point(12, 662);
            this.grvTransaction.Name = "grvTransaction";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvTransaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grvTransaction.RowTemplate.Height = 25;
            this.grvTransaction.Size = new System.Drawing.Size(964, 134);
            this.grvTransaction.TabIndex = 13;
            // 
            // colTransDate
            // 
            this.colTransDate.HeaderText = "Date";
            this.colTransDate.Name = "colTransDate";
            // 
            // colTransCustomerName
            // 
            this.colTransCustomerName.HeaderText = "Customer Name";
            this.colTransCustomerName.Name = "colTransCustomerName";
            // 
            // colTransCustomerSurname
            // 
            this.colTransCustomerSurname.HeaderText = "Customer Surname";
            this.colTransCustomerSurname.Name = "colTransCustomerSurname";
            // 
            // colTransEmployee
            // 
            this.colTransEmployee.HeaderText = "Employee Surname";
            this.colTransEmployee.Name = "colTransEmployee";
            // 
            // colTransPet
            // 
            this.colTransPet.HeaderText = "Pet";
            this.colTransPet.Name = "colTransPet";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // colTransPetFood
            // 
            this.colTransPetFood.HeaderText = "Pet Food";
            this.colTransPetFood.Name = "colTransPetFood";
            // 
            // colTransPetFoodQty
            // 
            this.colTransPetFoodQty.HeaderText = "Pet Food Quantity";
            this.colTransPetFoodQty.Name = "colTransPetFoodQty";
            // 
            // colTransPetFoodPrice
            // 
            this.colTransPetFoodPrice.HeaderText = "Pet Food Price";
            this.colTransPetFoodPrice.Name = "colTransPetFoodPrice";
            // 
            // colTransTotalPrice
            // 
            this.colTransTotalPrice.HeaderText = "TotalPrice";
            this.colTransTotalPrice.Name = "colTransTotalPrice";
            // 
            // grvPetReport
            // 
            this.grvPetReport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grvPetReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvPetReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grvPetReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPetReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRyear,
            this.PRmonth,
            this.PRanimType,
            this.PRtotalSold});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvPetReport.DefaultCellStyle = dataGridViewCellStyle17;
            this.grvPetReport.Location = new System.Drawing.Point(1327, 662);
            this.grvPetReport.Name = "grvPetReport";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvPetReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grvPetReport.RowTemplate.Height = 25;
            this.grvPetReport.Size = new System.Drawing.Size(542, 134);
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
            this.btnLoad.Location = new System.Drawing.Point(12, 806);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 41);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1552, 802);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 41);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPets
            // 
            this.btnPets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPets.FlatAppearance.BorderSize = 0;
            this.btnPets.Location = new System.Drawing.Point(928, 97);
            this.btnPets.Name = "btnPets";
            this.btnPets.Size = new System.Drawing.Size(161, 105);
            this.btnPets.TabIndex = 18;
            this.btnPets.Text = "\r\n";
            this.btnPets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPets.UseVisualStyleBackColor = true;
            this.btnPets.Click += new System.EventHandler(this.btnPets_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1881, 855);
            this.Controls.Add(this.btnPets);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grvPetReport);
            this.Controls.Add(this.grvTransaction);
            this.Controls.Add(this.grvEmployees);
            this.Controls.Add(this.grvPetFood);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvPet);
            this.Controls.Add(this.grvCustomer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnManage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnManage;
        private Button button2;
        private DataGridView grvCustomer;
        private DataGridView grvPet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
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
        private DataGridViewTextBoxColumn EmpID;
        private DataGridViewTextBoxColumn EmpName;
        private DataGridViewTextBoxColumn EmpSurname;
        private DataGridViewComboBoxColumn EmpType;
        private DataGridViewTextBoxColumn EmpSalary;
        private DataGridViewTextBoxColumn PetID;
        private DataGridViewComboBoxColumn AnimalT;
        private DataGridViewTextBoxColumn PetBreed;
        private DataGridViewTextBoxColumn PetStat;
        private DataGridViewTextBoxColumn PetPrice;
        private DataGridViewTextBoxColumn PetCost;
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
        private DataGridViewTextBoxColumn colTransDate;
        private DataGridViewTextBoxColumn colTransCustomerName;
        private DataGridViewTextBoxColumn colTransCustomerSurname;
        private DataGridViewTextBoxColumn colTransEmployee;
        private DataGridViewTextBoxColumn colTransPet;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn colTransPetFood;
        private DataGridViewTextBoxColumn colTransPetFoodQty;
        private DataGridViewTextBoxColumn colTransPetFoodPrice;
        private DataGridViewTextBoxColumn colTransTotalPrice;
        private DataGridViewTextBoxColumn ptFoodId;
        private DataGridViewComboBoxColumn AnimType;
        private DataGridViewTextBoxColumn pfPrice;
        private DataGridViewTextBoxColumn pfQty;
        private DataGridViewTextBoxColumn colQty;
    }
}