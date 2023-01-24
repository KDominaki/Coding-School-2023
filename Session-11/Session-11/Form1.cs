using ClassLibrary1.PopulateClasses;
using ClassLibrary1;
using System.Diagnostics;
using System.Windows;
using PopulateClassLibrary;

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

            //Pet binding Source
            grvPetFood.AutoGenerateColumns = false;
            bsPetFood.DataSource = petShop.Foods;
            grvPetFood.DataSource = bsPetFood;

            grvTransaction.AutoGenerateColumns = false;
            bsTransact.DataSource = petShop.Transactions;
            grvTransaction.DataSource = bsTransact;

            grvEmployees.AutoGenerateColumns = false;
            bsEmployees.DataSource = petShop.Employees;
            grvEmployees.DataSource = bsEmployees;

            
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

            //PET - PetFood combobox
            DataGridViewComboBoxColumn colPetFoodType = grvPetFood.Columns["AnimType"] as DataGridViewComboBoxColumn;
            colPetFoodType.DataSource = petShop.Foods;//GetUniversities();
            colPetFoodType.DisplayMember = "Animaltype";//"Name";
            colPetFoodType.ValueMember = "ID";//"ID";*/

            


        }             




          //public void Window_Loaded(object sender, RoutedEventArgs e)
          // {
          //     foreach (var type in Enum.GetValues(typeof(AnimalType)))
          //     {
          //         AnimType.Items.Add(type);
          //     }
          // }





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