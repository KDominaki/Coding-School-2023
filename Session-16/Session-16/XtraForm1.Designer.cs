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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.surnameColum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddTrans = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveJSON = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoadJSON = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(166, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDColumn,
            this.nameColumn,
            this.surnameColum});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // IDColumn
            // 
            this.IDColumn.Caption = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.Visible = true;
            this.IDColumn.VisibleIndex = 0;
            // 
            // nameColumn
            // 
            this.nameColumn.Caption = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Visible = true;
            this.nameColumn.VisibleIndex = 1;
            // 
            // surnameColum
            // 
            this.surnameColum.Caption = "Surname";
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
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 345);
            this.Controls.Add(this.btnLoadJSON);
            this.Controls.Add(this.btnSaveJSON);
            this.Controls.Add(this.btnAddTrans);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtOverAllTotal);
            this.Controls.Add(this.txtMonthlyTotal);
            this.Controls.Add(this.btnTotalLoad);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTotalLoad;
        private TextBox txtMonthlyTotal;
        private TextBox txtOverAllTotal;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IDColumn;
        private DevExpress.XtraGrid.Columns.GridColumn nameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn surnameColum;
        private DevExpress.XtraEditors.SimpleButton btnAddTrans;
        private DevExpress.XtraEditors.SimpleButton btnSaveJSON;
        private DevExpress.XtraEditors.SimpleButton btnLoadJSON;
    }
}