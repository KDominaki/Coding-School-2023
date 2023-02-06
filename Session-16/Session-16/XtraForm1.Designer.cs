namespace Session_16
{
    partial class XtraForm1
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
            this.btnTotalLoad = new DevExpress.XtraEditors.SimpleButton();
            this.txtMonthlyTotal = new System.Windows.Forms.TextBox();
            this.txtOverAllTotal = new System.Windows.Forms.TextBox();
            this.gridCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.surnameColum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddTrans = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveJSON = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoadJSON = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTotalLoad
            // 
            this.btnTotalLoad.Location = new System.Drawing.Point(202, 262);
            this.btnTotalLoad.Name = "btnTotalLoad";
            this.btnTotalLoad.Size = new System.Drawing.Size(79, 23);
            this.btnTotalLoad.TabIndex = 0;
            this.btnTotalLoad.Text = "Load";
            this.btnTotalLoad.Click += new System.EventHandler(this.btnTotalLoad_Click);
            // 
            // txtMonthlyTotal
            // 
            this.txtMonthlyTotal.Location = new System.Drawing.Point(303, 252);
            this.txtMonthlyTotal.Name = "txtMonthlyTotal";
            this.txtMonthlyTotal.Size = new System.Drawing.Size(140, 21);
            this.txtMonthlyTotal.TabIndex = 1;
            this.txtMonthlyTotal.TextChanged += new System.EventHandler(this.txtMonthlyTotal_TextChanged);
            // 
            // txtOverAllTotal
            // 
            this.txtOverAllTotal.Location = new System.Drawing.Point(303, 279);
            this.txtOverAllTotal.Name = "txtOverAllTotal";
            this.txtOverAllTotal.Size = new System.Drawing.Size(140, 21);
            this.txtOverAllTotal.TabIndex = 2;
            this.txtOverAllTotal.TextChanged += new System.EventHandler(this.txtOverAllTotal_TextChanged);
            // 
            // gridCustomers
            // 
            this.gridCustomers.AllowDrop = true;
            this.gridCustomers.Location = new System.Drawing.Point(176, 12);
            this.gridCustomers.MainView = this.gridView1;
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.Size = new System.Drawing.Size(400, 204);
            this.gridCustomers.TabIndex = 3;
            this.gridCustomers.UseEmbeddedNavigator = true;
            this.gridCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridCustomers.Click += new System.EventHandler(this.gridCustomers_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDColumn,
            this.nameColumn,
            this.surnameColum});
            this.gridView1.GridControl = this.gridCustomers;
            this.gridView1.Name = "gridView1";
            // 
            // IDColumn
            // 
            this.IDColumn.Caption = "ID";
            this.IDColumn.FieldName = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.Visible = true;
            this.IDColumn.VisibleIndex = 0;
            // 
            // nameColumn
            // 
            this.nameColumn.Caption = "Name";
            this.nameColumn.FieldName = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Visible = true;
            this.nameColumn.VisibleIndex = 1;
            // 
            // surnameColum
            // 
            this.surnameColum.Caption = "Surname";
            this.surnameColum.FieldName = "Surname";
            this.surnameColum.Name = "surnameColum";
            this.surnameColum.Visible = true;
            this.surnameColum.VisibleIndex = 2;
            // 
            // btnAddTrans
            // 
            this.btnAddTrans.Location = new System.Drawing.Point(486, 255);
            this.btnAddTrans.Name = "btnAddTrans";
            this.btnAddTrans.Size = new System.Drawing.Size(80, 38);
            this.btnAddTrans.TabIndex = 4;
            this.btnAddTrans.Text = "Add Trans";
            this.btnAddTrans.Click += new System.EventHandler(this.btnAddTrans_Click);
            // 
            // btnSaveJSON
            // 
            this.btnSaveJSON.Location = new System.Drawing.Point(29, 51);
            this.btnSaveJSON.Name = "btnSaveJSON";
            this.btnSaveJSON.Size = new System.Drawing.Size(85, 47);
            this.btnSaveJSON.TabIndex = 5;
            this.btnSaveJSON.Text = "SAVE";
            this.btnSaveJSON.Click += new System.EventHandler(this.btnSaveJSON_Click);
            // 
            // btnLoadJSON
            // 
            this.btnLoadJSON.Location = new System.Drawing.Point(29, 119);
            this.btnLoadJSON.Name = "btnLoadJSON";
            this.btnLoadJSON.Size = new System.Drawing.Size(85, 47);
            this.btnLoadJSON.TabIndex = 6;
            this.btnLoadJSON.Text = "LOAD";
            this.btnLoadJSON.Click += new System.EventHandler(this.btnLoadJSON_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "name";
            this.textEdit1.Location = new System.Drawing.Point(614, 81);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(129, 20);
            this.textEdit1.TabIndex = 7;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "surname";
            this.textEdit2.Location = new System.Drawing.Point(614, 116);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(129, 20);
            this.textEdit2.TabIndex = 8;
            this.textEdit2.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(638, 152);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(80, 38);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Add Customer";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "Enter TotalPrice";
            this.textEdit3.Location = new System.Drawing.Point(588, 266);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(116, 20);
            this.textEdit3.TabIndex = 10;
            this.textEdit3.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 345);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.btnLoadJSON);
            this.Controls.Add(this.btnSaveJSON);
            this.Controls.Add(this.btnAddTrans);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.txtOverAllTotal);
            this.Controls.Add(this.txtMonthlyTotal);
            this.Controls.Add(this.btnTotalLoad);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTotalLoad;
        private TextBox txtMonthlyTotal;
        private TextBox txtOverAllTotal;
        private DevExpress.XtraGrid.GridControl gridCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IDColumn;
        private DevExpress.XtraGrid.Columns.GridColumn nameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn surnameColum;
        private DevExpress.XtraEditors.SimpleButton btnAddTrans;
        private DevExpress.XtraEditors.SimpleButton btnSaveJSON;
        private DevExpress.XtraEditors.SimpleButton btnLoadJSON;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
    }
}