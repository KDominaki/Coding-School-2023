using ClassLibrary1;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_16
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        private PetShop _petshop = new PetShop();
        private MonthlyLedger _monthLedger;
        private Populate _pop = new Populate();

        public XtraForm1()
        {
            InitializeComponent();
           
        }
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            _pop.PopulateCustomers(_petshop.Customers, 4);
            gridCustomers.DataSource = _petshop.Customers;
            gridCustomers.AllowDrop= true;
        }

        private void btnTotalLoad_Click(object sender, EventArgs e)
        {
            _monthLedger = new MonthlyLedger(_petshop);

            _monthLedger.MothlyTotalCalc();
            txtMonthlyTotal.Text = _monthLedger.Total.ToString();

            _monthLedger.OverAllTotalCalc();
            txtOverAllTotal.Text = _monthLedger.OverAllTotal.ToString();
        }

        // Buttons
        private void btnAddTrans_Click(object sender, EventArgs e)
        {
            if(textEdit3.Text != null)
            {
                Transaction trans = new Transaction()
                {
                    TotalPrice = Convert.ToDecimal(textEdit3.Text)
                };
                _petshop.Transactions.Add(trans);
                textEdit3.Text = null;
            }
            else
            {
                _pop.PopulateTrans(_petshop.Transactions);
            }
        }

        private void btnSaveJSON_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(_petshop,"petshop.json");
            System.Windows.MessageBox.Show("Save Completed!");
        }

        private void btnLoadJSON_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            _petshop = serializer.DeserializeFromFile<PetShop>("petshop.json");
            System.Windows.MessageBox.Show("Load Completed!");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //    Customer cust = new Customer()
            //    {
            //        ID = Guid.NewGuid(),
            //        Name = textEdit1.Text,
            //        Surname = textEdit2.Text
            //    };
            //    _petshop.Customers.Add(cust);

        }

        // Text Boxes
        private void txtMonthlyTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOverAllTotal_TextChanged(object sender, EventArgs e)
        {

        }



        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }


        // Grid

        private void gridCustomers_Click(object sender, EventArgs e)
        {
            gridCustomers.Update();
        }

 
    }
}