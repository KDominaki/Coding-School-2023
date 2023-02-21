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
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transLinesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionsGridView
            // 
            this.transactionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGridView.Location = new System.Drawing.Point(12, 12);
            this.transactionsGridView.Name = "transactionsGridView";
            this.transactionsGridView.RowTemplate.Height = 25;
            this.transactionsGridView.Size = new System.Drawing.Size(602, 223);
            this.transactionsGridView.TabIndex = 0;
            // 
            // transLinesGridView
            // 
            this.transLinesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transLinesGridView.Location = new System.Drawing.Point(12, 241);
            this.transLinesGridView.Name = "transLinesGridView";
            this.transLinesGridView.RowTemplate.Height = 25;
            this.transLinesGridView.Size = new System.Drawing.Size(602, 197);
            this.transLinesGridView.TabIndex = 1;
            // 
            // TransactionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transLinesGridView);
            this.Controls.Add(this.transactionsGridView);
            this.Name = "TransactionsView";
            this.Text = "TransactionsView";
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transLinesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView transactionsGridView;
        private DataGridView transLinesGridView;
    }
}