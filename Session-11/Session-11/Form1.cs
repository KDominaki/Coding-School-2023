using ClassLibrary1.PopulateClasses;
using ClassLibrary1;
using System.Diagnostics;
using System.Windows;
using PopulateClassLibrary;
using Point = System.Drawing.Point;

using DevExpress.CodeParser;


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

            //PetFood binding Source
            grvPetFood.AutoGenerateColumns = false;
            bsPetFood.DataSource = petShop.GetPetFood();
            grvPetFood.DataSource = bsPetFood;

            grvTransaction.AutoGenerateColumns = false;
            bsTransact.DataSource = petShop.Transactions;
            grvTransaction.DataSource = bsTransact;

            grvEmployees.AutoGenerateColumns = false;
            bsEmployees.DataSource = petShop.Employees;
            grvEmployees.DataSource = bsEmployees;

            //grvEmployees.AutoGenerateColumns = false;
            //bsEmployees.DataSource = petShop.Employees;
            //grvEmployees.DataSource = bsEmployees;

            //grvPetReport.AutoGenerateColumns = false;
            //bsPetReport.DataSource = petShop.Employees;
            //grvPetReport.DataSource = bsPetReport;

            // FOR THE BINDING SOURCES 
         



            //FOR THE COMBO BOXES 
            //PET - AnimalType combobox
            DataGridViewComboBoxColumn colAnimType = grvPet.Columns["AnimalT"] as DataGridViewComboBoxColumn;
            //colAnimType.DataSource = petShop.Pets;//GetUniversities();
            //colAnimType.DisplayMember = "AnimalType";//"Name";
            //colAnimType.ValueMember =  "ID";//"ID";*/
            foreach(var type in Enum.GetValues(typeof(AnimalType))) {
                colAnimType.Items.Add(type);
            }
               


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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            petShop = serializer.DeserializeFromFile<PetShop>("petshop.json");

            System.Windows.MessageBox.Show("Load Completed!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(petShop, "petshop.json");

            System.Windows.MessageBox.Show("Save Completed!");
        }

        private void btnPets_Click(object sender, EventArgs e)
        {
            grvPet.Visible = true;

            //centering function sort of
            int midX = 942,midY=448;
            double center,Xsquared,Ysquared;
            Xsquared = Math.Pow(grvPet.Size.Width,2);
            Ysquared = Math.Pow(grvPet.Size.Height,2);

            center = Math.Sqrt(Xsquared + Ysquared)/2;
            grvPet.Location = new Point(midX-(int)center,midY -200);
            

        }
    }
}