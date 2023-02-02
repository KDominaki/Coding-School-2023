using ClassLibrary1;

namespace Session_16
{
    public partial class Form1 : Form
    {
        private PetShop _petshop = new PetShop();
        private MonthlyLedger _monthLedger;
        private Populate _pop = new Populate();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _pop.PopulateCustomers(_petshop.Customers, 4);
            employeeGrid.DataSource = _petshop.Customers;
        }

        private void totalResult_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            _monthLedger = new MonthlyLedger(_petshop);

            _monthLedger.MothlyTotalCalc();
            totalResult.Text = _monthLedger.Total.ToString();

            _monthLedger.OverAllTotalCalc();
            overAllTotalRes.Text = _monthLedger.OverAllTotal.ToString();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            _pop.PopulateTrans(_petshop.Transactions);
        }

        private void overAllTotalRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveJSON_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadJSON_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddGridElem_Click(object sender, EventArgs e)
        {

        }
    }
}