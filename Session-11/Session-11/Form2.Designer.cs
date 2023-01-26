namespace Session_11 {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabEmployees = new DevExpress.XtraTab.XtraTabPage();
            this.grvEmployees = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeePost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvEmployeeSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnEmployeeUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnEmployeeDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabCustomers = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerTIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnCustomerDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnCustomerUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPets = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPetDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetBreed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetHealthStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colButtonUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPetFoods = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPetAnimalType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetFoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetFoodCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetFoodQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnPetFoodUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnPetFoodDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabTransactions = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabMonthlyLedger = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPetReport = new DevExpress.XtraTab.XtraTabPage();
            this.bsEmployees = new DevExpress.Xpo.XPBindingSource(this.components);
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPetReportAnimalType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetReportMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetReportYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetReportTotalSold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnPetReportUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnPetReportDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.xtraTabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPetFoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.xtraTabPetReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Location = new System.Drawing.Point(59, 80);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedTabPage = this.xtraTabEmployees;
            this.tabControlMain.Size = new System.Drawing.Size(861, 468);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabEmployees,
            this.xtraTabCustomers,
            this.xtraTabPets,
            this.xtraTabPetFoods,
            this.xtraTabTransactions,
            this.xtraTabMonthlyLedger,
            this.xtraTabPetReport});
            // 
            // xtraTabEmployees
            // 
            this.xtraTabEmployees.Controls.Add(this.grvEmployees);
            this.xtraTabEmployees.Name = "xtraTabEmployees";
            this.xtraTabEmployees.Size = new System.Drawing.Size(859, 443);
            this.xtraTabEmployees.Text = "Employees";
            // 
            // grvEmployees
            // 
            this.grvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvEmployees.Location = new System.Drawing.Point(0, 0);
            this.grvEmployees.MainView = this.gridView1;
            this.grvEmployees.Name = "grvEmployees";
            this.grvEmployees.Size = new System.Drawing.Size(859, 443);
            this.grvEmployees.TabIndex = 1;
            this.grvEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grvEmployees.Click += new System.EventHandler(this.grvEmployees_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeName,
            this.colEmployeeSurname,
            this.colEmployeePost,
            this.colvEmployeeSalary,
            this.colBtnEmployeeUpdate,
            this.colBtnEmployeeDelete});
            this.gridView1.GridControl = this.grvEmployees;
            this.gridView1.Name = "gridView1";
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.Caption = "Name";
            this.colEmployeeName.FieldName = "Name";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 0;
            // 
            // colEmployeeSurname
            // 
            this.colEmployeeSurname.Caption = "Surname";
            this.colEmployeeSurname.FieldName = "Surname";
            this.colEmployeeSurname.Name = "colEmployeeSurname";
            this.colEmployeeSurname.Visible = true;
            this.colEmployeeSurname.VisibleIndex = 1;
            // 
            // colEmployeePost
            // 
            this.colEmployeePost.Caption = "Employee Post";
            this.colEmployeePost.FieldName = "Post";
            this.colEmployeePost.Name = "colEmployeePost";
            this.colEmployeePost.Visible = true;
            this.colEmployeePost.VisibleIndex = 2;
            // 
            // colvEmployeeSalary
            // 
            this.colvEmployeeSalary.Caption = "Salary";
            this.colvEmployeeSalary.FieldName = "Salary";
            this.colvEmployeeSalary.Name = "colvEmployeeSalary";
            this.colvEmployeeSalary.Visible = true;
            this.colvEmployeeSalary.VisibleIndex = 3;
            // 
            // colBtnEmployeeUpdate
            // 
            this.colBtnEmployeeUpdate.Caption = "Update";
            this.colBtnEmployeeUpdate.Name = "colBtnEmployeeUpdate";
            this.colBtnEmployeeUpdate.Visible = true;
            this.colBtnEmployeeUpdate.VisibleIndex = 4;
            // 
            // colBtnEmployeeDelete
            // 
            this.colBtnEmployeeDelete.Caption = "Delete";
            this.colBtnEmployeeDelete.Name = "colBtnEmployeeDelete";
            this.colBtnEmployeeDelete.Visible = true;
            this.colBtnEmployeeDelete.VisibleIndex = 5;
            // 
            // xtraTabCustomers
            // 
            this.xtraTabCustomers.Controls.Add(this.gridControl1);
            this.xtraTabCustomers.Name = "xtraTabCustomers";
            this.xtraTabCustomers.Size = new System.Drawing.Size(859, 443);
            this.xtraTabCustomers.Text = "Customers";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(859, 443);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colCustomerSurname,
            this.colCustomerPhone,
            this.colCustomerTIN,
            this.colBtnCustomerDelete,
            this.colBtnCustomerUpdate});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            // 
            // colCustomerSurname
            // 
            this.colCustomerSurname.Caption = "Surname";
            this.colCustomerSurname.Name = "colCustomerSurname";
            this.colCustomerSurname.Visible = true;
            this.colCustomerSurname.VisibleIndex = 1;
            // 
            // colCustomerPhone
            // 
            this.colCustomerPhone.Caption = "Phone";
            this.colCustomerPhone.Name = "colCustomerPhone";
            this.colCustomerPhone.Visible = true;
            this.colCustomerPhone.VisibleIndex = 2;
            // 
            // colCustomerTIN
            // 
            this.colCustomerTIN.Caption = "TIN";
            this.colCustomerTIN.Name = "colCustomerTIN";
            this.colCustomerTIN.Visible = true;
            this.colCustomerTIN.VisibleIndex = 4;
            // 
            // colBtnCustomerDelete
            // 
            this.colBtnCustomerDelete.Caption = "Delete";
            this.colBtnCustomerDelete.Name = "colBtnCustomerDelete";
            this.colBtnCustomerDelete.Visible = true;
            this.colBtnCustomerDelete.VisibleIndex = 3;
            // 
            // colBtnCustomerUpdate
            // 
            this.colBtnCustomerUpdate.Caption = "Update";
            this.colBtnCustomerUpdate.Name = "colBtnCustomerUpdate";
            this.colBtnCustomerUpdate.Visible = true;
            this.colBtnCustomerUpdate.VisibleIndex = 5;
            // 
            // xtraTabPets
            // 
            this.xtraTabPets.Controls.Add(this.gridControl2);
            this.xtraTabPets.Name = "xtraTabPets";
            this.xtraTabPets.Size = new System.Drawing.Size(859, 443);
            this.xtraTabPets.Text = "Pets";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView3;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(859, 443);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPetDate,
            this.colPetType,
            this.colPetBreed,
            this.colPetHealthStatus,
            this.colPetCost,
            this.colPetPrice,
            this.colButtonUpdate,
            this.colBtnDelete});
            this.gridView3.GridControl = this.gridControl2;
            this.gridView3.Name = "gridView3";
            // 
            // colPetDate
            // 
            this.colPetDate.Caption = "Date";
            this.colPetDate.Name = "colPetDate";
            this.colPetDate.Visible = true;
            this.colPetDate.VisibleIndex = 0;
            // 
            // colPetType
            // 
            this.colPetType.Caption = "Type";
            this.colPetType.Name = "colPetType";
            this.colPetType.Visible = true;
            this.colPetType.VisibleIndex = 1;
            // 
            // colPetBreed
            // 
            this.colPetBreed.Caption = "Breed";
            this.colPetBreed.Name = "colPetBreed";
            this.colPetBreed.Visible = true;
            this.colPetBreed.VisibleIndex = 2;
            // 
            // colPetHealthStatus
            // 
            this.colPetHealthStatus.Caption = "Health Status";
            this.colPetHealthStatus.Name = "colPetHealthStatus";
            this.colPetHealthStatus.Visible = true;
            this.colPetHealthStatus.VisibleIndex = 3;
            // 
            // colPetCost
            // 
            this.colPetCost.Caption = "Cost";
            this.colPetCost.Name = "colPetCost";
            this.colPetCost.Visible = true;
            this.colPetCost.VisibleIndex = 4;
            // 
            // colPetPrice
            // 
            this.colPetPrice.Caption = "Price";
            this.colPetPrice.Name = "colPetPrice";
            this.colPetPrice.Visible = true;
            this.colPetPrice.VisibleIndex = 5;
            // 
            // colButtonUpdate
            // 
            this.colButtonUpdate.Caption = "Update";
            this.colButtonUpdate.Name = "colButtonUpdate";
            this.colButtonUpdate.Visible = true;
            this.colButtonUpdate.VisibleIndex = 6;
            // 
            // colBtnDelete
            // 
            this.colBtnDelete.Caption = "Delete";
            this.colBtnDelete.Name = "colBtnDelete";
            this.colBtnDelete.Visible = true;
            this.colBtnDelete.VisibleIndex = 7;
            // 
            // xtraTabPetFoods
            // 
            this.xtraTabPetFoods.Controls.Add(this.gridControl3);
            this.xtraTabPetFoods.Name = "xtraTabPetFoods";
            this.xtraTabPetFoods.Size = new System.Drawing.Size(859, 443);
            this.xtraTabPetFoods.Text = "Pet Food";
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.gridView4;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(859, 443);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPetAnimalType,
            this.colPetFoodPrice,
            this.colPetFoodCost,
            this.colPetFoodQty,
            this.colBtnPetFoodUpdate,
            this.colBtnPetFoodDelete});
            this.gridView4.GridControl = this.gridControl3;
            this.gridView4.Name = "gridView4";
            // 
            // colPetAnimalType
            // 
            this.colPetAnimalType.Caption = "Animal Type";
            this.colPetAnimalType.Name = "colPetAnimalType";
            this.colPetAnimalType.Visible = true;
            this.colPetAnimalType.VisibleIndex = 0;
            // 
            // colPetFoodPrice
            // 
            this.colPetFoodPrice.Caption = "Price";
            this.colPetFoodPrice.Name = "colPetFoodPrice";
            this.colPetFoodPrice.Visible = true;
            this.colPetFoodPrice.VisibleIndex = 1;
            // 
            // colPetFoodCost
            // 
            this.colPetFoodCost.Caption = "Cost";
            this.colPetFoodCost.Name = "colPetFoodCost";
            this.colPetFoodCost.Visible = true;
            this.colPetFoodCost.VisibleIndex = 2;
            // 
            // colPetFoodQty
            // 
            this.colPetFoodQty.Caption = "Quantity";
            this.colPetFoodQty.Name = "colPetFoodQty";
            this.colPetFoodQty.Visible = true;
            this.colPetFoodQty.VisibleIndex = 3;
            // 
            // colBtnPetFoodUpdate
            // 
            this.colBtnPetFoodUpdate.Caption = "Update";
            this.colBtnPetFoodUpdate.Name = "colBtnPetFoodUpdate";
            this.colBtnPetFoodUpdate.Visible = true;
            this.colBtnPetFoodUpdate.VisibleIndex = 4;
            // 
            // colBtnPetFoodDelete
            // 
            this.colBtnPetFoodDelete.Caption = "Delete";
            this.colBtnPetFoodDelete.Name = "colBtnPetFoodDelete";
            this.colBtnPetFoodDelete.Visible = true;
            this.colBtnPetFoodDelete.VisibleIndex = 5;
            // 
            // xtraTabTransactions
            // 
            this.xtraTabTransactions.Name = "xtraTabTransactions";
            this.xtraTabTransactions.Size = new System.Drawing.Size(859, 443);
            this.xtraTabTransactions.Text = "Transactions";
            // 
            // xtraTabMonthlyLedger
            // 
            this.xtraTabMonthlyLedger.Name = "xtraTabMonthlyLedger";
            this.xtraTabMonthlyLedger.Size = new System.Drawing.Size(859, 443);
            this.xtraTabMonthlyLedger.Text = "Monthly Ledger";
            // 
            // xtraTabPetReport
            // 
            this.xtraTabPetReport.Controls.Add(this.gridControl4);
            this.xtraTabPetReport.Name = "xtraTabPetReport";
            this.xtraTabPetReport.Size = new System.Drawing.Size(859, 443);
            this.xtraTabPetReport.Text = "Pet Report";
            // 
            // gridControl4
            // 
            this.gridControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl4.Location = new System.Drawing.Point(0, 0);
            this.gridControl4.MainView = this.gridView7;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(859, 443);
            this.gridControl4.TabIndex = 1;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView7});
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPetReportAnimalType,
            this.colPetReportMonth,
            this.colPetReportYear,
            this.colPetReportTotalSold,
            this.colBtnPetReportUpdate,
            this.colBtnPetReportDelete});
            this.gridView7.GridControl = this.gridControl4;
            this.gridView7.Name = "gridView7";
            // 
            // colPetReportAnimalType
            // 
            this.colPetReportAnimalType.Caption = "Animal Type";
            this.colPetReportAnimalType.Name = "colPetReportAnimalType";
            this.colPetReportAnimalType.Visible = true;
            this.colPetReportAnimalType.VisibleIndex = 0;
            // 
            // colPetReportMonth
            // 
            this.colPetReportMonth.Caption = "Month";
            this.colPetReportMonth.Name = "colPetReportMonth";
            this.colPetReportMonth.Visible = true;
            this.colPetReportMonth.VisibleIndex = 1;
            // 
            // colPetReportYear
            // 
            this.colPetReportYear.Caption = "Year";
            this.colPetReportYear.Name = "colPetReportYear";
            this.colPetReportYear.Visible = true;
            this.colPetReportYear.VisibleIndex = 2;
            // 
            // colPetReportTotalSold
            // 
            this.colPetReportTotalSold.Caption = "Total Sold";
            this.colPetReportTotalSold.Name = "colPetReportTotalSold";
            this.colPetReportTotalSold.Visible = true;
            this.colPetReportTotalSold.VisibleIndex = 3;
            // 
            // colBtnPetReportUpdate
            // 
            this.colBtnPetReportUpdate.Caption = "Update";
            this.colBtnPetReportUpdate.Name = "colBtnPetReportUpdate";
            this.colBtnPetReportUpdate.Visible = true;
            this.colBtnPetReportUpdate.VisibleIndex = 4;
            // 
            // colBtnPetReportDelete
            // 
            this.colBtnPetReportDelete.Caption = "Delete";
            this.colBtnPetReportDelete.Name = "colBtnPetReportDelete";
            this.colBtnPetReportDelete.Visible = true;
            this.colBtnPetReportDelete.VisibleIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 655);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.xtraTabEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPetFoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.xtraTabPetReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabEmployees;
        private DevExpress.XtraTab.XtraTabPage xtraTabCustomers;
        private DevExpress.XtraTab.XtraTabPage xtraTabPets;
        private DevExpress.XtraTab.XtraTabPage xtraTabPetFoods;
        private DevExpress.XtraTab.XtraTabPage xtraTabTransactions;
        private DevExpress.XtraTab.XtraTabPage xtraTabMonthlyLedger;
        private DevExpress.XtraTab.XtraTabPage xtraTabPetReport;
        private DevExpress.Xpo.XPBindingSource bsEmployees;
        private DevExpress.XtraGrid.GridControl grvEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeePost;
        private DevExpress.XtraGrid.Columns.GridColumn colvEmployeeSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colBtnEmployeeUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colBtnEmployeeDelete;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerTIN;
        private DevExpress.XtraGrid.Columns.GridColumn colBtnCustomerDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colBtnCustomerUpdate;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colPetDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPetType;
        private DevExpress.XtraGrid.Columns.GridColumn colPetBreed;
        private DevExpress.XtraGrid.Columns.GridColumn colPetHealthStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colPetCost;
        private DevExpress.XtraGrid.Columns.GridColumn colPetPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colButtonUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colBtnDelete;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colPetAnimalType;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodCost;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodQty;
        private DevExpress.XtraGrid.Columns.GridColumn colBtnPetFoodUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colBtnPetFoodDelete;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn colPetReportAnimalType;
        private DevExpress.XtraGrid.Columns.GridColumn colPetReportMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colPetReportYear;
        private DevExpress.XtraGrid.Columns.GridColumn colPetReportTotalSold;
        private DevExpress.XtraGrid.Columns.GridColumn colBtnPetReportUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colBtnPetReportDelete;
    }
}