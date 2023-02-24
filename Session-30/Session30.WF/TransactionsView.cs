﻿using Session30.EF.Repositories;
using Session30.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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
            transactionsGridView.AutoGenerateColumns = false;
            transLinesGridView.AutoGenerateColumns = false;

            var trans = _transactionRepo.GetAll();
            transactionsGridView.DataSource= trans;
            var transLines = _transactionLineRepo.GetAll();
            transLinesGridView.AutoGenerateColumns = false;
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
                cardNumberTextBox.Text = "Do not change this value";
                employeeIdTextBox.Text = "Do not change this value";
            }
        }

        public void GetTransLine()
        {
            var transLineId = Convert.ToInt32(transLineIdTextBox.Text);
            var transLine = _transactionLineRepo.GetById(transLineId);
            if (transLine != null)
            {
                totalValueTextBox.Text = transLine.NetValue.ToString();
                qntTextBox.Text = transLine.Quantity.ToString();
                itemIdTextBox.Text = "Do not change this value";
                transIdTextBox2.Text = "Do not change this value";
            }
        }
        public void AddTrans()
        {
            var newTrans = new Transaction()
            {
                EmployeeId = Convert.ToInt32(employeeIdTextBox.Text),

            };

            if (payMethodTextBox.Text.ToLower() == "cash")
            {
                newTrans.PaymentMethod = Models.Enums.PaymentMethod.Cash;
            }
            else if (payMethodTextBox.Text.ToLower() == "product")
            {
                newTrans.PaymentMethod = Models.Enums.PaymentMethod.CreditCard;
            }
            else
            {
                payMethodTextBox.Text = "";
            }

            if (dateTextBox.Text == "")
            {
                newTrans.Date = DateTime.Now;
            }
            else
            {
                newTrans.Date = Convert.ToDateTime(dateTextBox.Text);
            }
            
            CheckCard(newTrans);
            newTrans.PaymentMethodCheck();
            if(totalPriceTextBox.Text == "")
            {
                newTrans.TotalValueCalc();
            }
            else
            {
                newTrans.TotalValue = Convert.ToDecimal(totalPriceTextBox.Text);
            }
            

            _transactionRepo.Add(newTrans);
        }

        public void AddTransLine()
        {
            var newTransLine = new TransactionLine()
            {
                Quantity = Convert.ToInt32(qntTextBox.Text)
            };
            GetItem(newTransLine);
            if (totalValueTextBox.Text == "")
            {
                var itemId = newTransLine.ItemId;
                var item = _itemRepo.GetById(itemId);
                newTransLine.TotalValueCalc(item);
            }
            else
            {
                newTransLine.TotalValue = Convert.ToDecimal(totalValueTextBox.Text);
            }
            
            AddTransLineToTrans(newTransLine);

            _transactionLineRepo.Add(newTransLine);
            
           
        }

        public void DeleteTransLine()
        {
            if (transLineIdTextBox.Text != "")
            {
                var transLineId = Convert.ToInt32(transLineIdTextBox.Text);                
                var dbTransLine = _transactionLineRepo.GetById(transLineId);
                var transId = dbTransLine.TransactionId;
                var trans = _transactionRepo.GetById(transId);

                trans.TotalValue -= dbTransLine.TotalValue;

                trans.TotalValueCalc();
                trans.PaymentMethodCheck();

                var entityTrans = new Transaction
                {
                    Date = trans.Date,
                    EmployeeId = trans.EmployeeId,
                    CustomerId = trans.CustomerId,
                    PaymentMethod = trans.PaymentMethod,
                    TotalValue = trans.TotalValue,
                };

                _transactionRepo.Update(transId, entityTrans);

                _transactionLineRepo.Delete(transLineId);

            }

        }
        public void DeleteTrans()
        {
            if (transIdTextBox1.Text != "")
            {
                var transId = Convert.ToInt32(transIdTextBox1.Text);
                _transactionRepo.Delete(transId);

            }
        }

        public void EditTrans()
        {
            if (transIdTextBox1.Text != "")
            {
                var transId = Convert.ToInt32(transIdTextBox1.Text);
                var dbTrans = _transactionRepo.GetById(transId);

                Transaction newTransaction = new Transaction()
                {
                    CustomerId = dbTrans.CustomerId,
                    PaymentMethod = dbTrans.PaymentMethod,
                    TotalValue = Convert.ToDecimal(totalPriceTextBox.Text),
                    EmployeeId= dbTrans.EmployeeId,
                    Date = Convert.ToDateTime(dateTextBox.Text),
                };

                _transactionRepo.Update(transId, newTransaction);

            }
        }
        public void EditTransLine()
        {

        }

        public void CheckCard(Transaction trans)
        {
            if (cardNumberTextBox.Text !="")
            {
                var customers = _customerRepo.GetAll();
                foreach (var customer in customers)
                {
                    if (customer.CardNumber == cardNumberTextBox.Text)
                    {
                        trans.CustomerId = customer.Id;
                    }
                    else
                    {

                    }
                }

            }
        
        }

        public void GetItem(TransactionLine transLine)
        {
            if (itemIdTextBox.Text != "")
            {
                var itemId = Convert.ToInt32(itemIdTextBox.Text);
                var tlItem = _itemRepo.GetById(itemId);
                if (tlItem != null)
                {
                    tlItem.Price = transLine.ItemPrice;
                    transLine.ItemId = itemId;
                }
                
            }
        }

        public void AddTransLineToTrans(TransactionLine transLine) 
        {
            if (transIdTextBox2.Text != "")
            {
                var transId = Convert.ToInt32(transIdTextBox2.Text);
                var trans = _transactionRepo.GetById(transId);

                if(trans != null)
                {
                    trans.TransactionLines.Add(transLine);
                    transLine.TransactionId= transId;

                    trans.TotalValueCalc();
                    trans.PaymentMethodCheck();

                    var entityTrans = new Transaction
                    {
                        Date = trans.Date,
                        EmployeeId = trans.EmployeeId,
                        CustomerId = trans.CustomerId,
                        PaymentMethod = trans.PaymentMethod,
                        TotalValue = trans.TotalValue,
                    };

                    _transactionRepo.Update(transId, entityTrans);
                    
                }
            }   
        }


        //Buttons
        private void newCustomerBtn_Click(object sender, EventArgs e)
        {
            CustomersView customers = new CustomersView();
            customers.ShowDialog();
        }

        private void saveTransBtn_Click(object sender, EventArgs e)
        {
            if (transIdTextBox1.Text != "")
            {
                EditTrans();
            }
            else
            {
                AddTrans();
            }
            totalPriceTextBox.Text = "";
            dateTextBox.Text = "";
            payMethodTextBox.Text = "";
            cardNumberTextBox.Text = "";
            employeeIdTextBox.Text = "";
            DataBinding();
        }

        private void deleteTransBtn_Click(object sender, EventArgs e)
        {
            DeleteTrans();

            totalPriceTextBox.Text = "";
            dateTextBox.Text = "";
            payMethodTextBox.Text = "";
            cardNumberTextBox.Text = "";
            employeeIdTextBox.Text = "";
            DataBinding();
        }

        private void viewItemBtn_Click(object sender, EventArgs e)
        {
            ItemsView view = new ItemsView();
            view.ShowDialog();
        }

        private void saveTransLineBtn_Click(object sender, EventArgs e)
        {
            if (transIdTextBox2.Text != "")
            {   
                AddTransLine();
            }
            else
            {
                EditTransLine();
            }
            totalValueTextBox.Text = "";
            qntTextBox.Text = "";
            itemIdTextBox.Text = "";
            transIdTextBox2.Text = "";
            DataBinding();

        }

        private void deleteTransLineBtn_Click(object sender, EventArgs e)
        {
            DeleteTransLine();

            totalValueTextBox.Text = "";
            qntTextBox.Text = "";
            itemIdTextBox.Text = "";
            transIdTextBox2.Text = "";
            DataBinding();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            GetTrans();
        }

        private void okBtn2_Click(object sender, EventArgs e)
        {
            GetTransLine();
        }
    }
}
