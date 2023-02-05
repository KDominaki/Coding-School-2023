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
            _pop.PopulateTrans(_petshop.Transactions);
        }

        private void btnSaveJSON_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(_petshop, "petshop.json");
        }

        private void btnLoadJSON_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            _petshop = serializer.DeserializeFromFile<PetShop>("petshop.json");
        }

        // Text Boxes
        private void txtMonthlyTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOverAllTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}