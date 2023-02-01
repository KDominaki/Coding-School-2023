using ClassLibrary1;

namespace Session_16
{
    public partial class Form1 : Form
    {
        private PetShop _petshop = new PetShop();
        private MonthlyLedgerManager _manager;
        private decimal _money = 300;
        private MonthlyLedger _monthLedger;
        public Transaction trans1 = new Transaction()
        {
            TotalPrice= 10000,
        };
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _manager = new MonthlyLedgerManager(_petshop);
            _monthLedger = new MonthlyLedger(2023, 10, _petshop);
        }

        private void totalResult_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {

            _manager.CurrentMonthTotal();
            totalResult.Text = _manager.currentMonthTotal.ToString();

            //_monthLedger.MothlyTotalCalc();
            //totalResult.Text = _monthLedger.Total.ToString();

            _manager.CurrentMonthOverAllTotal();
            overAllTotalRes.Text = _manager.overAllTotal.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _petshop.Transactions.Add(trans1);
        }

        private void overAllTotalRes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}