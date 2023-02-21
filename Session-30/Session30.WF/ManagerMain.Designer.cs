namespace Session30.WF
{
    partial class ManagerMain
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
            this.CustomerViewBtn = new System.Windows.Forms.Button();
            this.ItemViewBtn = new System.Windows.Forms.Button();
            this.TransViewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerViewBtn
            // 
            this.CustomerViewBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerViewBtn.Location = new System.Drawing.Point(258, 119);
            this.CustomerViewBtn.Name = "CustomerViewBtn";
            this.CustomerViewBtn.Size = new System.Drawing.Size(179, 55);
            this.CustomerViewBtn.TabIndex = 0;
            this.CustomerViewBtn.Text = "View Cutomers";
            this.CustomerViewBtn.UseVisualStyleBackColor = true;
            this.CustomerViewBtn.Click += new System.EventHandler(this.CustomerViewBtn_Click);
            // 
            // ItemViewBtn
            // 
            this.ItemViewBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemViewBtn.Location = new System.Drawing.Point(258, 210);
            this.ItemViewBtn.Name = "ItemViewBtn";
            this.ItemViewBtn.Size = new System.Drawing.Size(179, 55);
            this.ItemViewBtn.TabIndex = 1;
            this.ItemViewBtn.Text = "View Items";
            this.ItemViewBtn.UseVisualStyleBackColor = true;
            this.ItemViewBtn.Click += new System.EventHandler(this.ItemViewBtn_Click);
            // 
            // TransViewBtn
            // 
            this.TransViewBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransViewBtn.Location = new System.Drawing.Point(258, 306);
            this.TransViewBtn.Name = "TransViewBtn";
            this.TransViewBtn.Size = new System.Drawing.Size(179, 55);
            this.TransViewBtn.TabIndex = 2;
            this.TransViewBtn.Text = "View Transactions";
            this.TransViewBtn.UseVisualStyleBackColor = true;
            this.TransViewBtn.Click += new System.EventHandler(this.TransViewBtn_Click);
            // 
            // ManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.TransViewBtn);
            this.Controls.Add(this.ItemViewBtn);
            this.Controls.Add(this.CustomerViewBtn);
            this.Name = "ManagerMain";
            this.Text = "ManagerMain";
            this.ResumeLayout(false);

        }

        #endregion

        private Button CustomerViewBtn;
        private Button ItemViewBtn;
        private Button TransViewBtn;
    }
}