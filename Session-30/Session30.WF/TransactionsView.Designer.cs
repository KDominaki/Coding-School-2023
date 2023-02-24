namespace Session30.WF
{
    partial class TransactionsView
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
            this.transactionsGridView = new System.Windows.Forms.DataGridView();
            this.transLinesGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetValcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountValueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.payMethodTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.transIdTextBox1 = new System.Windows.Forms.TextBox();
            this.newCustomerBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.saveTransBtn = new System.Windows.Forms.Button();
            this.deleteTransBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.transIdTextBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.transLineIdTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.itemIdTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.totalValueTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.qntTextBox = new System.Windows.Forms.TextBox();
            this.okBtn2 = new System.Windows.Forms.Button();
            this.saveTransLineBtn = new System.Windows.Forms.Button();
            this.deleteTransLineBtn = new System.Windows.Forms.Button();
            this.viewItemBtn = new System.Windows.Forms.Button();
            this.errorLabel1 = new System.Windows.Forms.Label();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transLinesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionsGridView
            // 
            this.transactionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.EmployeeIdCol,
            this.CustomerIdCol,
            this.DateCol,
            this.PaymentCol,
            this.dataGridViewTextBoxColumn1});
            this.transactionsGridView.Location = new System.Drawing.Point(12, 12);
            this.transactionsGridView.Name = "transactionsGridView";
            this.transactionsGridView.RowTemplate.Height = 25;
            this.transactionsGridView.Size = new System.Drawing.Size(602, 223);
            this.transactionsGridView.TabIndex = 0;
            // 
            // transLinesGridView
            // 
            this.transLinesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transLinesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ItemIdCol,
            this.QuantityCol,
            this.NetValcol,
            this.DiscountValueCol,
            this.TotalValueCol});
            this.transLinesGridView.Location = new System.Drawing.Point(12, 241);
            this.transLinesGridView.Name = "transLinesGridView";
            this.transLinesGridView.RowTemplate.Height = 25;
            this.transLinesGridView.Size = new System.Drawing.Size(602, 197);
            this.transLinesGridView.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // ItemIdCol
            // 
            this.ItemIdCol.DataPropertyName = "ItemId";
            this.ItemIdCol.HeaderText = "Item Id";
            this.ItemIdCol.Name = "ItemIdCol";
            // 
            // QuantityCol
            // 
            this.QuantityCol.DataPropertyName = "Quantity";
            this.QuantityCol.HeaderText = "Quantity";
            this.QuantityCol.Name = "QuantityCol";
            // 
            // NetValcol
            // 
            this.NetValcol.DataPropertyName = "NetValue";
            this.NetValcol.HeaderText = "Net Value";
            this.NetValcol.Name = "NetValcol";
            // 
            // DiscountValueCol
            // 
            this.DiscountValueCol.DataPropertyName = "DiscountValue";
            this.DiscountValueCol.HeaderText = "Discount Value";
            this.DiscountValueCol.Name = "DiscountValueCol";
            // 
            // TotalValueCol
            // 
            this.TotalValueCol.DataPropertyName = "TotalValue";
            this.TotalValueCol.HeaderText = "Total Value";
            this.TotalValueCol.Name = "TotalValueCol";
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(664, 85);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(132, 23);
            this.cardNumberTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "EmployeeID";
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.Location = new System.Drawing.Point(664, 129);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(132, 23);
            this.employeeIdTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(924, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(924, 40);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(132, 23);
            this.dateTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(924, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Payment Method";
            // 
            // payMethodTextBox
            // 
            this.payMethodTextBox.Location = new System.Drawing.Point(924, 84);
            this.payMethodTextBox.Name = "payMethodTextBox";
            this.payMethodTextBox.Size = new System.Drawing.Size(132, 23);
            this.payMethodTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(923, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Value";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(924, 129);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(132, 23);
            this.totalPriceTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Transaction ID";
            // 
            // transIdTextBox1
            // 
            this.transIdTextBox1.Location = new System.Drawing.Point(664, 40);
            this.transIdTextBox1.Name = "transIdTextBox1";
            this.transIdTextBox1.Size = new System.Drawing.Size(132, 23);
            this.transIdTextBox1.TabIndex = 13;
            // 
            // newCustomerBtn
            // 
            this.newCustomerBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newCustomerBtn.Location = new System.Drawing.Point(802, 82);
            this.newCustomerBtn.Name = "newCustomerBtn";
            this.newCustomerBtn.Size = new System.Drawing.Size(72, 28);
            this.newCustomerBtn.TabIndex = 12;
            this.newCustomerBtn.Text = "New ";
            this.newCustomerBtn.UseVisualStyleBackColor = true;
            this.newCustomerBtn.Click += new System.EventHandler(this.newCustomerBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.okBtn.Location = new System.Drawing.Point(804, 36);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(49, 28);
            this.okBtn.TabIndex = 15;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // saveTransBtn
            // 
            this.saveTransBtn.Location = new System.Drawing.Point(730, 169);
            this.saveTransBtn.Name = "saveTransBtn";
            this.saveTransBtn.Size = new System.Drawing.Size(103, 44);
            this.saveTransBtn.TabIndex = 16;
            this.saveTransBtn.Text = "Save";
            this.saveTransBtn.UseVisualStyleBackColor = true;
            this.saveTransBtn.Click += new System.EventHandler(this.saveTransBtn_Click);
            // 
            // deleteTransBtn
            // 
            this.deleteTransBtn.Location = new System.Drawing.Point(852, 169);
            this.deleteTransBtn.Name = "deleteTransBtn";
            this.deleteTransBtn.Size = new System.Drawing.Size(103, 44);
            this.deleteTransBtn.TabIndex = 17;
            this.deleteTransBtn.Text = "Delete";
            this.deleteTransBtn.UseVisualStyleBackColor = true;
            this.deleteTransBtn.Click += new System.EventHandler(this.deleteTransBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(663, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Transaction ID";
            // 
            // transIdTextBox2
            // 
            this.transIdTextBox2.Location = new System.Drawing.Point(663, 305);
            this.transIdTextBox2.Name = "transIdTextBox2";
            this.transIdTextBox2.Size = new System.Drawing.Size(132, 23);
            this.transIdTextBox2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "TransactionLine ID";
            // 
            // transLineIdTextBox
            // 
            this.transLineIdTextBox.Location = new System.Drawing.Point(663, 258);
            this.transLineIdTextBox.Name = "transLineIdTextBox";
            this.transLineIdTextBox.Size = new System.Drawing.Size(132, 23);
            this.transLineIdTextBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(663, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Item ID";
            // 
            // itemIdTextBox
            // 
            this.itemIdTextBox.Location = new System.Drawing.Point(663, 359);
            this.itemIdTextBox.Name = "itemIdTextBox";
            this.itemIdTextBox.Size = new System.Drawing.Size(132, 23);
            this.itemIdTextBox.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(910, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Net Value";
            // 
            // totalValueTextBox
            // 
            this.totalValueTextBox.Location = new System.Drawing.Point(911, 303);
            this.totalValueTextBox.Name = "totalValueTextBox";
            this.totalValueTextBox.Size = new System.Drawing.Size(132, 23);
            this.totalValueTextBox.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(911, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Quantity";
            // 
            // qntTextBox
            // 
            this.qntTextBox.Location = new System.Drawing.Point(911, 258);
            this.qntTextBox.Name = "qntTextBox";
            this.qntTextBox.Size = new System.Drawing.Size(132, 23);
            this.qntTextBox.TabIndex = 24;
            // 
            // okBtn2
            // 
            this.okBtn2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.okBtn2.Location = new System.Drawing.Point(804, 253);
            this.okBtn2.Name = "okBtn2";
            this.okBtn2.Size = new System.Drawing.Size(49, 28);
            this.okBtn2.TabIndex = 28;
            this.okBtn2.Text = "OK";
            this.okBtn2.UseVisualStyleBackColor = true;
            this.okBtn2.Click += new System.EventHandler(this.okBtn2_Click);
            // 
            // saveTransLineBtn
            // 
            this.saveTransLineBtn.Location = new System.Drawing.Point(861, 347);
            this.saveTransLineBtn.Name = "saveTransLineBtn";
            this.saveTransLineBtn.Size = new System.Drawing.Size(103, 44);
            this.saveTransLineBtn.TabIndex = 29;
            this.saveTransLineBtn.Text = "Save";
            this.saveTransLineBtn.UseVisualStyleBackColor = true;
            this.saveTransLineBtn.Click += new System.EventHandler(this.saveTransLineBtn_Click);
            // 
            // deleteTransLineBtn
            // 
            this.deleteTransLineBtn.Location = new System.Drawing.Point(984, 347);
            this.deleteTransLineBtn.Name = "deleteTransLineBtn";
            this.deleteTransLineBtn.Size = new System.Drawing.Size(103, 44);
            this.deleteTransLineBtn.TabIndex = 30;
            this.deleteTransLineBtn.Text = "Delete";
            this.deleteTransLineBtn.UseVisualStyleBackColor = true;
            this.deleteTransLineBtn.Click += new System.EventHandler(this.deleteTransLineBtn_Click);
            // 
            // viewItemBtn
            // 
            this.viewItemBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewItemBtn.Location = new System.Drawing.Point(802, 303);
            this.viewItemBtn.Name = "viewItemBtn";
            this.viewItemBtn.Size = new System.Drawing.Size(72, 28);
            this.viewItemBtn.TabIndex = 31;
            this.viewItemBtn.Text = "View Items";
            this.viewItemBtn.UseVisualStyleBackColor = true;
            this.viewItemBtn.Click += new System.EventHandler(this.viewItemBtn_Click);
            // 
            // errorLabel1
            // 
            this.errorLabel1.AutoSize = true;
            this.errorLabel1.ForeColor = System.Drawing.Color.Red;
            this.errorLabel1.Location = new System.Drawing.Point(670, 9);
            this.errorLabel1.Name = "errorLabel1";
            this.errorLabel1.Size = new System.Drawing.Size(0, 15);
            this.errorLabel1.TabIndex = 32;
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.ForeColor = System.Drawing.Color.Red;
            this.errorLabel2.Location = new System.Drawing.Point(670, 223);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(0, 15);
            this.errorLabel2.TabIndex = 33;
            // 
            // IdCol
            // 
            this.IdCol.HeaderText = "Transaction Id";
            this.IdCol.Name = "IdCol";
            // 
            // EmployeeIdCol
            // 
            this.EmployeeIdCol.DataPropertyName = "EmployeeId";
            this.EmployeeIdCol.HeaderText = "Employee Id";
            this.EmployeeIdCol.Name = "EmployeeIdCol";
            // 
            // CustomerIdCol
            // 
            this.CustomerIdCol.DataPropertyName = "CustomerId";
            this.CustomerIdCol.HeaderText = "Customer Id";
            this.CustomerIdCol.Name = "CustomerIdCol";
            // 
            // DateCol
            // 
            this.DateCol.DataPropertyName = "Date";
            this.DateCol.HeaderText = "Date";
            this.DateCol.Name = "DateCol";
            // 
            // PaymentCol
            // 
            this.PaymentCol.DataPropertyName = "PaymentMethod";
            this.PaymentCol.HeaderText = "Payment Method";
            this.PaymentCol.Name = "PaymentCol";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TotalValue";
            this.dataGridViewTextBoxColumn1.HeaderText = "Total Value";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // TransactionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 450);
            this.Controls.Add(this.errorLabel2);
            this.Controls.Add(this.errorLabel1);
            this.Controls.Add(this.viewItemBtn);
            this.Controls.Add(this.deleteTransLineBtn);
            this.Controls.Add(this.saveTransLineBtn);
            this.Controls.Add(this.okBtn2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalValueTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.qntTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.itemIdTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.transLineIdTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.transIdTextBox2);
            this.Controls.Add(this.deleteTransBtn);
            this.Controls.Add(this.saveTransBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.transIdTextBox1);
            this.Controls.Add(this.newCustomerBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.payMethodTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardNumberTextBox);
            this.Controls.Add(this.transLinesGridView);
            this.Controls.Add(this.transactionsGridView);
            this.Name = "TransactionsView";
            this.Text = "TransactionsView";
            this.Load += new System.EventHandler(this.TransactionsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transLinesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView transactionsGridView;
        private DataGridView transLinesGridView;
        private TextBox cardNumberTextBox;
        private Label label1;
        private Label label2;
        private TextBox employeeIdTextBox;
        private Label label3;
        private TextBox dateTextBox;
        private Label label4;
        private TextBox payMethodTextBox;
        private Label label5;
        private TextBox totalPriceTextBox;
        private Label label6;
        private TextBox transIdTextBox1;
        private Button newCustomerBtn;
        private Button okBtn;
        private Button saveTransBtn;
        private Button deleteTransBtn;
        private Label label7;
        private TextBox transIdTextBox2;
        private Label label8;
        private TextBox transLineIdTextBox;
        private Label label9;
        private TextBox itemIdTextBox;
        private Label label10;
        private TextBox totalValueTextBox;
        private Label label11;
        private TextBox qntTextBox;
        private Button okBtn2;
        private Button saveTransLineBtn;
        private Button deleteTransLineBtn;
        private Button viewItemBtn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ItemIdCol;
        private DataGridViewTextBoxColumn QuantityCol;
        private DataGridViewTextBoxColumn NetValcol;
        private DataGridViewTextBoxColumn DiscountValueCol;
        private DataGridViewTextBoxColumn TotalValueCol;
        private Label errorLabel1;
        private Label errorLabel2;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn EmployeeIdCol;
        private DataGridViewTextBoxColumn CustomerIdCol;
        private DataGridViewTextBoxColumn DateCol;
        private DataGridViewTextBoxColumn PaymentCol;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}