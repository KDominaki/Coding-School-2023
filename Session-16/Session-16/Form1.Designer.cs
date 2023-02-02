namespace Session_16
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
            this.employeeGrid = new System.Windows.Forms.DataGridView();
            this.totalResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadBtn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.overAllTotalRes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddGridElem = new System.Windows.Forms.Button();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeGrid
            // 
            this.employeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmName,
            this.clmSurname});
            this.employeeGrid.Location = new System.Drawing.Point(166, 62);
            this.employeeGrid.Name = "employeeGrid";
            this.employeeGrid.RowTemplate.Height = 25;
            this.employeeGrid.Size = new System.Drawing.Size(440, 254);
            this.employeeGrid.TabIndex = 0;
            // 
            // totalResult
            // 
            this.totalResult.Location = new System.Drawing.Point(320, 350);
            this.totalResult.Name = "totalResult";
            this.totalResult.Size = new System.Drawing.Size(183, 23);
            this.totalResult.TabIndex = 1;
            this.totalResult.TextChanged += new System.EventHandler(this.totalResult_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Month Total";
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(119, 362);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 3;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(531, 362);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Trans";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // overAllTotalRes
            // 
            this.overAllTotalRes.Location = new System.Drawing.Point(318, 380);
            this.overAllTotalRes.Name = "overAllTotalRes";
            this.overAllTotalRes.Size = new System.Drawing.Size(185, 23);
            this.overAllTotalRes.TabIndex = 5;
            this.overAllTotalRes.TextChanged += new System.EventHandler(this.overAllTotalRes_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Over All Total";
            // 
            // btnAddGridElem
            // 
            this.btnAddGridElem.Location = new System.Drawing.Point(646, 173);
            this.btnAddGridElem.Name = "btnAddGridElem";
            this.btnAddGridElem.Size = new System.Drawing.Size(75, 23);
            this.btnAddGridElem.TabIndex = 7;
            this.btnAddGridElem.Text = "ADD";
            this.btnAddGridElem.UseVisualStyleBackColor = true;
            this.btnAddGridElem.Click += new System.EventHandler(this.btnAddGridElem_Click);
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "Name";
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            // 
            // clmSurname
            // 
            this.clmSurname.DataPropertyName = "Surname";
            this.clmSurname.HeaderText = "Surname";
            this.clmSurname.Name = "clmSurname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddGridElem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.overAllTotalRes);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalResult);
            this.Controls.Add(this.employeeGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView employeeGrid;
        private TextBox totalResult;
        private Label label1;
        private Button loadBtn;
        private Button btnAdd;
        private TextBox overAllTotalRes;
        private Label label2;
        private Button btnAddGridElem;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmSurname;
    }
}