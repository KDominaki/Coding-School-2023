﻿using Session30.EF.Repositories;
using Session30.Web.Server.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using Session30.Web.Shared;
using Session30.Models;

namespace Session30.WF
{
    
    public partial class CustomersView : Form
    {
        private CustomerRepo _customerRepo;
        
        
        public CustomersView()
        {
            
            InitializeComponent();
            
        }

        private void CustomersView_Load(object sender, EventArgs e)
        {
            _customerRepo= new CustomerRepo();

            GridData();
        }
        

        public void GridData()
        {
            customersGridView.DataSource = _customerRepo.GetAll();
        }

        public void AddNewCustomer()
        {
            var customer = new Customer();
            customer.Name = nameTextBox.Text;
            customer.Surname= surnameTextBox.Text;

            _customerRepo.Add(customer);
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            AddNewCustomer();
            //Refresh :(\\
        }
    }
}
