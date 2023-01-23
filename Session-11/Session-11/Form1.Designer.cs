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
            this.PetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetBreed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PetStat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PetPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPet)).BeginInit();
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
            this.grvCustomer.Location = new System.Drawing.Point(551, 41);
            this.grvCustomer.Name = "grvCustomer";
            this.grvCustomer.RowTemplate.Height = 25;
            this.grvCustomer.Size = new System.Drawing.Size(451, 56);
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
            this.PetBreed,
            this.AnimalT,
            this.PetStat,
            this.PetPrice,
            this.PetCost});
            this.grvPet.Location = new System.Drawing.Point(551, 138);
            this.grvPet.Name = "grvPet";
            this.grvPet.RowTemplate.Height = 25;
            this.grvPet.Size = new System.Drawing.Size(530, 73);
            this.grvPet.TabIndex = 3;
            // 
            // PetID
            // 
            this.PetID.HeaderText = "PetID";
            this.PetID.Name = "PetID";
            this.PetID.Visible = false;
            // 
            // PetBreed
            // 
            this.PetBreed.HeaderText = "Breed";
            this.PetBreed.Name = "PetBreed";
            // 
            // AnimalT
            // 
            this.AnimalT.HeaderText = "Type";
            this.AnimalT.Name = "AnimalT";
            this.AnimalT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AnimalT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pet Food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Transactions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Monthly Ledger";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 647);
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
        private DataGridViewTextBoxColumn PetID;
        private DataGridViewTextBoxColumn PetBreed;
        private DataGridViewComboBoxColumn AnimalT;
        private DataGridViewComboBoxColumn PetStat;
        private DataGridViewTextBoxColumn PetPrice;
        private DataGridViewTextBoxColumn PetCost;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}