using ClassLibrary1.PopulateClasses;
using ClassLibrary1;

namespace Session_11
{
    public partial class Form1 : Form
    {
        PetShop petShop;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            petShop= new PetShop();
            EngagePopulate ep = new EngagePopulate();
            petShop = ep.SetPopulation();
            

            SetControlProperties();
        }

















































        private void SetControlProperties()
        {
            grvCustomer.AutoGenerateColumns = false;
            bsCustomer.DataSource = petShop.Customers;
            grvCustomer.DataSource = bsCustomer;
            
            // FOR THE BINDING SOURCES 
            /*  
                        grvCustomer.DataSource = bsCustomer;
                        grvCustomer.AutoGenerateColumns = false;
                        grvPet.DataSource = bsPet;
                        grvPet.AutoGenerateColumns = false;
                        grvPetFood.DataSource = bsPetFood;
                        grvPetFood.AutoGenerateColumns = false;
                        grvEmployees.DataSource = bsEmployees;
                        grvEmployees.AutoGenerateColumns = false;
                        grvTransaction.DataSource = bsTransact;
                        grvTransaction.AutoGenerateColumns = false;
                        grvMonthLedger.DataSource = bsMonthlyLedger; 
                        grvMonthLedger.AutoGenerateColumns = false;
                        grvPetReport.DataSource = bsPetReport;
                        grvPetReport.AutoGenerateColumns = false;
            */

            /*          //FOR THE COMBO BOXES 
                        DataGridViewComboBoxColumn colUniversity = grvStudents.Columns["colUniversity"] as DataGridViewComboBoxColumn;
                        colUniversity.DataSource = //GetUniversities();
                        colUniversity.DisplayMember = //"Name";
                        colUniversity.ValueMember = //"ID";*/


        }









        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void btnManage_Click(object sender, EventArgs e)
        {

            TransactionsForm form2 = new TransactionsForm();
            //Form1.Close();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}