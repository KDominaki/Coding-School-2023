namespace Session30.WF
{
    partial class CustomersView
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
            this.customersGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customersGridView
            // 
            this.customersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGridView.Location = new System.Drawing.Point(218, 113);
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.RowTemplate.Height = 25;
            this.customersGridView.Size = new System.Drawing.Size(352, 217);
            this.customersGridView.TabIndex = 0;
            // 
            // CustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customersGridView);
            this.Name = "CustomersView";
            this.Text = "CustomersView";
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView customersGridView;
    }
}