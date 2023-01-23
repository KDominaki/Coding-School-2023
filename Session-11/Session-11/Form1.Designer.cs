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
            this.btnManage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grvCustomer = new System.Windows.Forms.DataGridView();
            this.CustomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvPet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grvPetFood = new System.Windows.Forms.DataGridView();
            this.grvEmployees = new System.Windows.Forms.DataGridView();
            this.grvTransaction = new System.Windows.Forms.DataGridView();
            this.grvMonthLedger = new System.Windows.Forms.DataGridView();
            this.grvPetReport = new System.Windows.Forms.DataGridView();
            this.ptFoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ptDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PetBreed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetStat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PetPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetFoodQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trEmplID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MLyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MLmonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MLincome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MLtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRmonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRanimType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRtotalSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonthLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(50, 324);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(229, 149);
            this.btnManage.TabIndex = 0;
            this.btnManage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Session_11.Properties.Resources.shoplogo2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(50, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 149);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // grvCustomer
            // 
            this.grvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomID,
            this.CustomName,
            this.CustomSurname,
            this.CustomPhone,
            this.CustomTin});
            this.grvCustomer.Location = new System.Drawing.Point(294, 360);
            this.grvCustomer.Name = "grvCustomer";
            this.grvCustomer.RowTemplate.Height = 25;
            this.grvCustomer.Size = new System.Drawing.Size(424, 56);
            this.grvCustomer.TabIndex = 2;
            this.grvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CustomID
            // 
            this.CustomID.HeaderText = "Customer ID";
            this.CustomID.Name = "CustomID";
            this.CustomID.Visible = false;
            // 
            // CustomName
            // 
            this.CustomName.HeaderText = "Name";
            this.CustomName.Name = "CustomName";
            // 
            // CustomSurname
            // 
            this.CustomSurname.HeaderText = "Surname";
            this.CustomSurname.Name = "CustomSurname";
            // 
            // CustomPhone
            // 
            this.CustomPhone.HeaderText = "Phone";
            this.CustomPhone.Name = "CustomPhone";
            // 
            // CustomTin
            // 
            this.CustomTin.HeaderText = "TIN";
            this.CustomTin.Name = "CustomTin";
            // 
            // grvPet
            // 
            this.grvPet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PetID,
            this.AnimalT,
            this.PetBreed,
            this.PetStat,
            this.PetPrice,
            this.PetCost});
            this.grvPet.Location = new System.Drawing.Point(294, 461);
            this.grvPet.Name = "grvPet";
            this.grvPet.RowTemplate.Height = 25;
            this.grvPet.Size = new System.Drawing.Size(503, 73);
            this.grvPet.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pet Food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 663);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(780, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Transactions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(862, 558);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Monthly Ledger";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(862, 663);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Pet Report";
            // 
            // grvPetFood
            // 
            this.grvPetFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvPetFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPetFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ptFoodId,
            this.AnimType,
            this.ptDescription,
            this.pfPrice,
            this.pfCost});
            this.grvPetFood.Location = new System.Drawing.Point(294, 576);
            this.grvPetFood.Name = "grvPetFood";
            this.grvPetFood.RowTemplate.Height = 25;
            this.grvPetFood.Size = new System.Drawing.Size(424, 56);
            this.grvPetFood.TabIndex = 11;
            // 
            // grvEmployees
            // 
            this.grvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.EmpName,
            this.EmpSurname,
            this.EmpType,
            this.dataGridViewTextBoxColumn10});
            this.grvEmployees.Location = new System.Drawing.Point(294, 681);
            this.grvEmployees.Name = "grvEmployees";
            this.grvEmployees.RowTemplate.Height = 25;
            this.grvEmployees.Size = new System.Drawing.Size(424, 56);
            this.grvEmployees.TabIndex = 12;
            // 
            // grvTransaction
            // 
            this.grvTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trDate,
            this.dataGridViewTextBoxColumn2,
            this.PetFoodQty,
            this.pFoodPrice,
            this.TotalP,
            this.TransacID,
            this.trEmplID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn11});
            this.grvTransaction.Location = new System.Drawing.Point(780, 360);
            this.grvTransaction.Name = "grvTransaction";
            this.grvTransaction.RowTemplate.Height = 25;
            this.grvTransaction.Size = new System.Drawing.Size(552, 56);
            this.grvTransaction.TabIndex = 13;
            // 
            // grvMonthLedger
            // 
            this.grvMonthLedger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvMonthLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvMonthLedger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MLyear,
            this.MLmonth,
            this.MLincome,
            this.Expenses,
            this.MLtotal});
            this.grvMonthLedger.Location = new System.Drawing.Point(862, 576);
            this.grvMonthLedger.Name = "grvMonthLedger";
            this.grvMonthLedger.RowTemplate.Height = 25;
            this.grvMonthLedger.Size = new System.Drawing.Size(424, 56);
            this.grvMonthLedger.TabIndex = 14;
            // 
            // grvPetReport
            // 
            this.grvPetReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvPetReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPetReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRyear,
            this.PRmonth,
            this.PRanimType,
            this.PRtotalSold});
            this.grvPetReport.Location = new System.Drawing.Point(862, 681);
            this.grvPetReport.Name = "grvPetReport";
            this.grvPetReport.RowTemplate.Height = 25;
            this.grvPetReport.Size = new System.Drawing.Size(424, 56);
            this.grvPetReport.TabIndex = 15;
            // 
            // ptFoodId
            // 
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
            // ptDescription
            // 
            this.ptDescription.HeaderText = "Description";
            this.ptDescription.Name = "ptDescription";
            // 
            // pfPrice
            // 
            this.pfPrice.HeaderText = "Price";
            this.pfPrice.Name = "pfPrice";
            // 
            // pfCost
            // 
            this.pfCost.HeaderText = "Cost";
            this.pfCost.Name = "pfCost";
            // 
            // PetID
            // 
            this.PetID.HeaderText = "PetID";
            this.PetID.Name = "PetID";
            this.PetID.Visible = false;
            // 
            // AnimalT
            // 
            this.AnimalT.HeaderText = "Type";
            this.AnimalT.Name = "AnimalT";
            this.AnimalT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AnimalT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PetBreed
            // 
            this.PetBreed.HeaderText = "Breed";
            this.PetBreed.Name = "PetBreed";
            // 
            // PetStat
            // 
            this.PetStat.HeaderText = "Health Status";
            this.PetStat.Name = "PetStat";
            this.PetStat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PetStat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PetPrice
            // 
            this.PetPrice.HeaderText = "Price";
            this.PetPrice.Name = "PetPrice";
            // 
            // PetCost
            // 
            this.PetCost.HeaderText = "Cost";
            this.PetCost.Name = "PetCost";
            // 
            // EmpID
            // 
            this.EmpID.HeaderText = "Employee ID";
            this.EmpID.Name = "EmpID";
            this.EmpID.Visible = false;
            // 
            // EmpName
            // 
            this.EmpName.HeaderText = "Name";
            this.EmpName.Name = "EmpName";
            // 
            // EmpSurname
            // 
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
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "TIN";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // trDate
            // 
            this.trDate.HeaderText = "Date";
            this.trDate.Name = "trDate";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "PetPrice";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // PetFoodQty
            // 
            this.PetFoodQty.HeaderText = "Pet-food Quantity";
            this.PetFoodQty.Name = "PetFoodQty";
            // 
            // pFoodPrice
            // 
            this.pFoodPrice.HeaderText = "Pet-food Price";
            this.pFoodPrice.Name = "pFoodPrice";
            // 
            // TotalP
            // 
            this.TotalP.HeaderText = "Total Price";
            this.TotalP.Name = "TotalP";
            // 
            // TransacID
            // 
            this.TransacID.HeaderText = "Transaction ID";
            this.TransacID.Name = "TransacID";
            this.TransacID.Visible = false;
            // 
            // trEmplID
            // 
            this.trEmplID.HeaderText = "EmployeeID";
            this.trEmplID.Name = "trEmplID";
            this.trEmplID.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Pet ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Pet Food ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Customer ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // MLyear
            // 
            this.MLyear.HeaderText = "Year";
            this.MLyear.Name = "MLyear";
            // 
            // MLmonth
            // 
            this.MLmonth.HeaderText = "Month";
            this.MLmonth.Name = "MLmonth";
            // 
            // MLincome
            // 
            this.MLincome.HeaderText = "Income";
            this.MLincome.Name = "MLincome";
            // 
            // Expenses
            // 
            this.Expenses.HeaderText = "Expenses";
            this.Expenses.Name = "Expenses";
            // 
            // MLtotal
            // 
            this.MLtotal.HeaderText = "Total";
            this.MLtotal.Name = "MLtotal";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 787);
            this.Controls.Add(this.grvPetReport);
            this.Controls.Add(this.grvMonthLedger);
            this.Controls.Add(this.grvTransaction);
            this.Controls.Add(this.grvEmployees);
            this.Controls.Add(this.grvPetFood);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            ((System.ComponentModel.ISupportInitialize)(this.grvMonthLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnManage;
        private Button button2;
        private DataGridView grvCustomer;
        private DataGridViewTextBoxColumn CustomID;
        private DataGridViewTextBoxColumn CustomName;
        private DataGridViewTextBoxColumn CustomSurname;
        private DataGridViewTextBoxColumn CustomPhone;
        private DataGridViewTextBoxColumn CustomTin;
        private DataGridView grvPet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView grvPetFood;
        private DataGridView grvEmployees;
        private DataGridView grvTransaction;
        private DataGridView grvMonthLedger;
        private DataGridView grvPetReport;
        private DataGridViewTextBoxColumn PetID;
        private DataGridViewComboBoxColumn AnimalT;
        private DataGridViewTextBoxColumn PetBreed;
        private DataGridViewComboBoxColumn PetStat;
        private DataGridViewTextBoxColumn PetPrice;
        private DataGridViewTextBoxColumn PetCost;
        private DataGridViewTextBoxColumn ptFoodId;
        private DataGridViewComboBoxColumn AnimType;
        private DataGridViewTextBoxColumn ptDescription;
        private DataGridViewTextBoxColumn pfPrice;
        private DataGridViewTextBoxColumn pfCost;
        private DataGridViewTextBoxColumn EmpID;
        private DataGridViewTextBoxColumn EmpName;
        private DataGridViewTextBoxColumn EmpSurname;
        private DataGridViewComboBoxColumn EmpType;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
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
        private DataGridViewTextBoxColumn MLyear;
        private DataGridViewTextBoxColumn MLmonth;
        private DataGridViewTextBoxColumn MLincome;
        private DataGridViewTextBoxColumn Expenses;
        private DataGridViewTextBoxColumn MLtotal;
        private DataGridViewTextBoxColumn PRyear;
        private DataGridViewTextBoxColumn PRmonth;
        private DataGridViewTextBoxColumn PRanimType;
        private DataGridViewTextBoxColumn PRtotalSold;
    }
}