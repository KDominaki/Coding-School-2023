using Session30.EF.Repositories;
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
    public partial class TransactionsView : Form
    {
        private TransactionRepo _transactionRepo;
        private TransactionLineRepo _transactionLineRepo;
        private ItemRepo _itemRepo;
        private CustomerRepo _customerRepo;
        private EmployeeRepo _employeeRepo;
        public TransactionsView()
        {
            InitializeComponent();
        }

        private void TransactionsView_Load(object sender, EventArgs e)
        {
            _transactionLineRepo= new TransactionLineRepo();
            _transactionRepo = new TransactionRepo();
            _itemRepo= new ItemRepo();
            _customerRepo= new CustomerRepo();
            _employeeRepo= new EmployeeRepo();
            DataBinding();
        }




        //Methods
        public void DataBinding()
        {
            var trans = _transactionRepo.GetAll();
            transactionsGridView.DataSource= trans;
            var transLines = _transactionLineRepo.GetAll();
            transLinesGridView.DataSource= transLines;
        }

        public void GetTrans()
        {
            var transId = Convert.ToInt32(transIdTextBox1.Text);
            var trans = _transactionRepo.GetById(transId);
            if (trans != null)
            {
                totalPriceTextBox.Text = trans.TotalValue.ToString();
                dateTextBox.Text = trans.Date.ToString();
                payMethodTextBox.Text = trans.PaymentMethod.ToString();
            }
        }

        public void GetTransLine()
        {

        }
        public void AddTrans()
        {

        }

        public void AddTransLine()
        {

        }

        public void DeleteTransLine()
        {

        }

        public void DeleteTrans()
        {

        }

        //Buttons
        private void newCustomerBtn_Click(object sender, EventArgs e)
        {
            CustomersView customers = new CustomersView();
            customers.ShowDialog();
        }
    }
}
