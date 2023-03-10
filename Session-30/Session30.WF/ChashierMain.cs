using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session30.WF
{
    public partial class ChashierMain : Form
    {
        public ChashierMain()
        {
            InitializeComponent();
        }

        private void CustomerViewBtn_Click(object sender, EventArgs e)
        {
            CustomersView customers = new CustomersView();
            customers.ShowDialog();
        }

        private void TransViewBtn_Click(object sender, EventArgs e)
        {
            TransactionsView transactions = new TransactionsView();
            transactions.ShowDialog();
        }
    }
}
