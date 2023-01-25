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
using MessageBox = System.Windows.Forms.MessageBox;

namespace Session_11
{
    public partial class Form1 : Form
    {
        public PetShop petShop = new PetShop();
        public  EngagePopulate ep = new EngagePopulate();
        public PetShop pullElements = new PetShop();

        //PetShop petShop;
        public List<Customer> publicCustomers;
        public List<Employee> publicEmployees;
        public List<Pet> publicPet;
        public List<PetFood> publicPetFood;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            petShop = ep.SetPopulation();

            popGeneralPublic(petShop);
            startInvis();
            SetControlProperties();
        }

        //  public List<petShop.Customers> publicCustomers;

        public void popGeneralPublic(PetShop customer)
        {
            publicCustomers = petShop.Customers;
            publicEmployees = petShop.Employees;
            publicPet = petShop.Pets;
            publicPetFood = petShop.Foods;
           
           

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

           


            //trial Update/deleteCustomer
            //DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            //DataGridViewButtonColumn btnUpdate = grvCustomer.Columns["cusUpdate"] as DataGridViewButtonColumn;
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.UseColumnTextForButtonValue = true;
            btnUpdate.Text = "Update";

            grvCustomer.Columns.Add(btnUpdate);
           






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

            //Employees - Employee combobox
            DataGridViewComboBoxColumn colEmpType = grvEmployees.Columns["EmpType"] as DataGridViewComboBoxColumn;
            foreach (var type in Enum.GetValues(typeof(EmployeeType))) {
                colEmpType.Items.Add(type);
            }

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

        /*public  Point getCentered(DataGridView grvSizeChoice)
        {   
            int midX = 942, midY = 448;
            double center, Xsquared, Ysquared;
            Xsquared = Math.Pow(grvSizeChoice.Size.Width, 2);
            Ysquared = Math.Pow(grvSizeChoice.Size.Height, 2);

            center = Math.Sqrt(Xsquared + Ysquared) / 2;
            return grvSizeChoice.Location = new Point(midX - (int)center, midY - 200);
        }
*/
        


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
            /*List<DataGridView> grvNameList = new List<DataGridView>()
            {grvPet,grvEmployees,grvPetFood,grvCustomer,grvTransaction, grvPetReport,grvMonthly};


            DataGridView grvTmp = new DataGridView();
            Label tmpLabel = new Label();

            for (int i = 0; i < grvNameList.Count; i++)
            {
                grvTmp = grvNameList[i];
                grvTmp.Visible = false;           
            }*/
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grv = (DataGridView)sender;


            DataGridViewButtonColumn col = grv.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
            //conflict resolution
            if (col != null && col.Name == "btnUpdate" && e.RowIndex >= 0)
            {
                publicCustomers = grv.CurrentRow.DataBoundItem as List<Customer>;
                MessageBox.Show($"show something Plz");
            }




        }
        //customer update + delete button events 
        


      

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;
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
            tabControl1.SelectedIndex = 2;
        }

        private void btnManage_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;   
        }

        private void btnPetFood_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        

        private void btnPetReport_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void grvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvPet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }




}
