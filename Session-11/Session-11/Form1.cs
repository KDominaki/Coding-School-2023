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
        {   //Customer binding Source
            grvCustomer.AutoGenerateColumns = false;
            bsCustomer.DataSource = petShop.Customers;
            grvCustomer.DataSource = bsCustomer;

            //Pet binding Source
            grvPet.AutoGenerateColumns = false;
            bsPet.DataSource = petShop.Pets; 
            grvPet.DataSource = bsPet;


            // FOR THE BINDING SOURCES 
            /*  
                      
                        
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

                      //FOR THE COMBO BOXES 
                       //PET - AnimalType combobox
                        DataGridViewComboBoxColumn colAnimType = grvPet.Columns["AnimalT"] as DataGridViewComboBoxColumn;
                        colAnimType.DataSource = petShop.Pets;//GetUniversities();
                        colAnimType.DisplayMember = "AnimalType";//"Name";
                        colAnimType.ValueMember =  "ID";//"ID";*/
                       

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