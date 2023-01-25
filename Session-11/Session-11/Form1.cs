using ClassLibrary1.PopulateClasses;
using ClassLibrary1;
using System.Diagnostics;
using System.Windows;
using PopulateClassLibrary;
using Point = System.Drawing.Point;
using System.Windows.Controls;
using DevExpress.CodeParser;
using Label = System.Windows.Forms.Label;
using static DevExpress.Pdf.Native.BouncyCastle.Asn1.X509.Target;

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
            petShop = new PetShop();
            EngagePopulate ep = new EngagePopulate();
            petShop = ep.SetPopulation();

            startInvis();
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
            foreach (var type in Enum.GetValues(typeof(AnimalType))) {
                colAnimType.Items.Add(type);
            }



            //PET - PetFood combobox
            DataGridViewComboBoxColumn colPetFoodType = grvPetFood.Columns["AnimType"] as DataGridViewComboBoxColumn;
            //colPetFoodType.DataSource = petShop.Foods;//GetUniversities();
            //colPetFoodType.DisplayMember = "Animaltype";//"Name";
            //colPetFoodType.ValueMember = "ID";//"ID";*/

            foreach (var type in Enum.GetValues(typeof(AnimalType))) {
                colPetFoodType.Items.Add(type);
            }

            /*foreach (var type in Enum.GetValues(typeof(EmployeeType))) {
                EmpType.Items.Add(type);
            }*/


        }
        public void massHideGrv(DataGridView grvChoice)
        { 
            List<DataGridView> grvNameList = new List<DataGridView>()  
            {grvPet,grvEmployees,grvPetFood,grvCustomer,grvTransaction, grvPetReport,grvMonthly };

            
            
            grvNameList.Remove(grvChoice);
            
            DataGridView grvTmp = new DataGridView();
            //grvTmp = choice ;
           

            for(int i=0; i<grvNameList.Count;i++)
            {
                grvTmp = grvNameList[i];
                grvTmp.Visible = false;
 
            }
            grvChoice.Visible = true;
            

        }

        public  Point getCentered(DataGridView grvSizeChoice)
        {   
            int midX = 942, midY = 448;
            double center, Xsquared, Ysquared;
            Xsquared = Math.Pow(grvSizeChoice.Size.Width, 2);
            Ysquared = Math.Pow(grvSizeChoice.Size.Height, 2);

            center = Math.Sqrt(Xsquared + Ysquared) / 2;
            return grvSizeChoice.Location = new Point(midX - (int)center, midY - 200);
        }

       /* public Point getCenteredLabel(Label labelChoice)
        {

            int midX = 942, midY = 448;
            double center, Xsquared, Ysquared;
            Xsquared = Math.Pow(labelChoice.Size.Width, 2);
            Ysquared = Math.Pow(labelChoice.Size.Height, 2);

            center = Math.Sqrt(Xsquared + Ysquared) ;
            return labelChoice.Location = new Point(midX - (int)center, midY - 250);

           // return labelChoice.Location;
        }*/


        //public void Window_Loaded(object sender, RoutedEventArgs e)
        // {
        //     foreach (var type in Enum.GetValues(typeof(AnimalType)))
        //     {
        //         AnimType.Items.Add(type);
        //     }
        // }

        //kinda redundant but didn't figure another solution this late at night
        public void startInvis()
        {
            List<DataGridView> grvNameList = new List<DataGridView>()
            {grvPet,grvEmployees,grvPetFood,grvCustomer,grvTransaction, grvPetReport,grvMonthly};


            DataGridView grvTmp = new DataGridView();
            Label tmpLabel = new Label();

            for (int i = 0; i < grvNameList.Count; i++)
            {
                grvTmp = grvNameList[i];
                grvTmp.Visible = false;           
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        /*private void btnManage_Click(object sender, EventArgs e)
        {
            


            //TransactionsForm form2 = new TransactionsForm();
            //Form1.Close();
            //form2.Show();
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            massHideGrv(grvTransaction);

            //centering function sort of
            Point center = new Point();
            center = getCentered(grvTransaction);
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
            massHideGrv(grvPet);
            //centering function sort of
            Point center = new Point();
            center = getCentered(grvPet);
           

        }

        private void btnManage_Click_1(object sender, EventArgs e)
        {
            //could prolly do it by choosing the only visible grid but oh well
            massHideGrv(grvEmployees);
            labEmployees.Visible= false; //somehow didnt get caught in massHide
            //centering function sort of
            Point center = new Point();
            center = getCentered(grvEmployees);
            
        }

        private void btnPetFood_Click(object sender, EventArgs e)
        {
            //could prolly do it by choosing the only visible grid but oh well
            massHideGrv(grvPetFood);

            //centering function sort of
            Point center = new Point();
            center = getCentered(grvPetFood);
        }

        

        private void btnPetReport_Click(object sender, EventArgs e)
        {
            massHideGrv(grvPetReport);

            //centering function sort of
            Point center = new Point();
            center = getCentered(grvPetReport);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            massHideGrv(grvCustomer);

            //centering function sort of
            Point center = new Point();
            center = getCentered(grvCustomer);

        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            massHideGrv(grvMonthly);

            //centering function sort of
            Point center = new Point();
            center = getCentered(grvMonthly);
        }
//ignore it, accidental click
      /*  private void grvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/
    }
}