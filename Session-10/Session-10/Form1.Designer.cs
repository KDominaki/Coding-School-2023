namespace Session_10
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colRNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.colGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.colCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRNum,
            this.colName,
            this.colSurname});
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(730, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colRNum
            // 
            this.colRNum.DataPropertyName = "RegistrationNumber";
            this.colRNum.HeaderText = "RegistrationNumber";
            this.colRNum.Name = "colRNum";
            this.colRNum.Width = 150;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colSurname
            // 
            this.colSurname.DataPropertyName = "Surname";
            this.colSurname.HeaderText = "Surname";
            this.colSurname.Name = "colSurname";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSub,
            this.colCode});
            this.dataGridView2.Location = new System.Drawing.Point(1, 158);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(730, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // colSub
            // 
            this.colSub.DataPropertyName = "Subject";
            this.colSub.HeaderText = "Subject";
            this.colSub.Name = "colSub";
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGrade,
            this.colStudentID});
            this.dataGridView3.Location = new System.Drawing.Point(1, 314);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(730, 150);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // colGrade
            // 
            this.colGrade.DataPropertyName = "GradeNum";
            this.colGrade.HeaderText = "Grade";
            this.colGrade.Name = "colGrade";
            // 
            // colStudentID
            // 
            this.colStudentID.HeaderText = "Student ID";
            this.colStudentID.Name = "colStudentID";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCourseID,
            this.colProfID,
            this.colCal});
            this.dataGridView4.Location = new System.Drawing.Point(1, 470);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(730, 150);
            this.dataGridView4.TabIndex = 3;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(773, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 50);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(773, 258);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(139, 50);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // colCourseID
            // 
            this.colCourseID.HeaderText = "CourseID";
            this.colCourseID.Name = "colCourseID";
            // 
            // colProfID
            // 
            this.colProfID.HeaderText = "ProffesorID";
            this.colProfID.Name = "colProfID";
            // 
            // colCal
            // 
            this.colCal.DataPropertyName = "Callender";
            this.colCal.HeaderText = "Callendar";
            this.colCal.Name = "colCal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 653);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private Button btnSave;
        private Button btnLoad;
        private DataGridViewTextBoxColumn colSub;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colGrade;
        private DataGridViewTextBoxColumn colStudentID;
        private DataGridViewTextBoxColumn colRNum;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSurname;
        private DataGridViewTextBoxColumn colCourseID;
        private DataGridViewTextBoxColumn colProfID;
        private DataGridViewTextBoxColumn colCal;
    }
}