using Session30.EF.Repositories;
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
        

        // Methods
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
        private void GetCustomer()
        {
            var customerId = Convert.ToInt32(idTextBox.Text);
            var customer = _customerRepo.GetById(customerId);
            if (customer != null)
            {
                nameTextBox.Text = customer.Name;
                surnameTextBox.Text = customer.Surname;
                errorLabel.Text = "";
            }
            else
            {
                errorLabel.Text = $"There is no customer with id:{customerId}";
            }
           
        }

        private void DeleteCustomer()
        {
            if (idTextBox.Text != "")
            {
                var customerId = Convert.ToInt32(idTextBox.Text);
                _customerRepo.Delete(customerId);

            }
        }


        private void EditCustomer()
        {
            if (idTextBox.Text != "")
            {
                var customerId = Convert.ToInt32(idTextBox.Text);
                var customerEntity = new Customer();
                {
                    customerEntity.Name = nameTextBox.Text;
                    customerEntity.Surname = surnameTextBox.Text;
                }
                _customerRepo.Update(customerId, customerEntity);

            }
        }

        // Buttons
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTextBox.Text != "")
                {
                    EditCustomer();
                }
                else
                {
                    AddNewCustomer();
                }
                nameTextBox.Text = "";
                surnameTextBox.Text = "";
                idTextBox.Text = "";
                GridData();
                errorMessageLabel.Text = "";

            }
            catch (Exception) 
            {
                errorMessageLabel.Text = "*Oops something went wrong.\nMake sure that you filled the form correctly";

            }

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            GetCustomer();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteCustomer();
                nameTextBox.Text = "";
                surnameTextBox.Text = "";
                idTextBox.Text = "";
                GridData();
                errorMessageLabel.Text = "";

            }
            catch (Exception)
            {
                errorMessageLabel.Text = "*Oops something went wrong.\nMake sure that you filled the form correctly";
            }
            
        }

    }
}
