namespace Session30.WF
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
            this.label1 = new System.Windows.Forms.Label();
            this.ManagerBtn = new System.Windows.Forms.Button();
            this.ChashierBtn = new System.Windows.Forms.Button();
            this.StuffBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(356, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "I am :";
            // 
            // ManagerBtn
            // 
            this.ManagerBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManagerBtn.Location = new System.Drawing.Point(101, 228);
            this.ManagerBtn.Name = "ManagerBtn";
            this.ManagerBtn.Size = new System.Drawing.Size(192, 65);
            this.ManagerBtn.TabIndex = 1;
            this.ManagerBtn.Text = "Manager";
            this.ManagerBtn.UseVisualStyleBackColor = true;
            this.ManagerBtn.Click += new System.EventHandler(this.ManagerBtn_Click);
            // 
            // ChashierBtn
            // 
            this.ChashierBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChashierBtn.Location = new System.Drawing.Point(314, 228);
            this.ChashierBtn.Name = "ChashierBtn";
            this.ChashierBtn.Size = new System.Drawing.Size(192, 65);
            this.ChashierBtn.TabIndex = 2;
            this.ChashierBtn.Text = "Cashier";
            this.ChashierBtn.UseVisualStyleBackColor = true;
            this.ChashierBtn.Click += new System.EventHandler(this.ChashierBtn_Click);
            // 
            // StuffBtn
            // 
            this.StuffBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StuffBtn.Location = new System.Drawing.Point(531, 228);
            this.StuffBtn.Name = "StuffBtn";
            this.StuffBtn.Size = new System.Drawing.Size(192, 65);
            this.StuffBtn.TabIndex = 3;
            this.StuffBtn.Text = "Stuff";
            this.StuffBtn.UseVisualStyleBackColor = true;
            this.StuffBtn.Click += new System.EventHandler(this.StuffBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StuffBtn);
            this.Controls.Add(this.ChashierBtn);
            this.Controls.Add(this.ManagerBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button ManagerBtn;
        private Button ChashierBtn;
        private Button StuffBtn;
    }
}