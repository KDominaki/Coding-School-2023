﻿using ClassLibrary1.PopulateClasses;
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
using DevExpress.XtraGantt.Scheduling;

namespace Session_11 {
    public partial class Form2 : DevExpress.XtraEditors.XtraForm {

        public PetShop petShop = new PetShop();
        public EngagePopulate ep = new EngagePopulate();


        public Form2() {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Uncomment next line to set the total number of data records stored within your source
            // unboundSource1.SetRowCount(42);
        }



        private void Form2_Load_1(object sender, EventArgs e) {
            // petShop = ep.SetPopulation();
            //month = new MonthlyLedgerManager(petShop);

            InitPetShop(ep);
            //PopGeneralPublic(petShop);
            SetControlProperties();
        }

        public PetShop InitPetShop(EngagePopulate eps) { return petShop = ep.SetPopulation(); }


        private void SetControlProperties() {   //Customer binding Source
            //grvEmployees.AutoGenerateColumns = false;

            //grvEmployees.AutoFillC
            //gridControl1.AutoGenerateColumns = false;
            //grvEmployees.AutoGenerateColumns = false;
            
            bsEmployees.DataSource = petShop.Employees;
            grvEmployees.DataSource = bsEmployees;


            //    grvCustomer.AutoGenerateColumns = false;
            //    bsCustomer.DataSource = petShop.Customers;
            //    grvCustomer.DataSource = bsCustomer;

            //    //Pet binding Source
            //    grvPet.AutoGenerateColumns = false;
            //    bsPet.DataSource = petShop.Pets;
            //    grvPet.DataSource = bsPet;

            //    //PetFood binding Source
            //    grvPetFood.AutoGenerateColumns = false;
            //    bsPetFood.DataSource = petShop.GetPetFood();
            //    grvPetFood.DataSource = bsPetFood;


            //    SetControlTransactions();


            //    grvEmployees.AutoGenerateColumns = false;
            //    bsEmployees.DataSource = petShop.Employees;
            //    grvEmployees.DataSource = bsEmployees;




            //    //trial Update/deleteCustomer
            //    //DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            //    //DataGridViewButtonColumn btnUpdate = grvCustomer.Columns["cusUpdate"] as DataGridViewButtonColumn;
            //    DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            //    btnUpdate.FlatStyle = FlatStyle.Popup;
            //    btnUpdate.Name = "btnUpdate";
            //    btnUpdate.UseColumnTextForButtonValue = true;
            //    btnUpdate.Text = "Update";

            //    grvCustomer.Columns.Add(btnUpdate);







            //    //FOR THE COMBO BOXES 
            //    //PET - AnimalType combobox
            //    DataGridViewComboBoxColumn colAnimType = grvPet.Columns["AnimalT"] as DataGridViewComboBoxColumn;
            //    //colAnimType.DataSource = petShop.Pets;//GetUniversities();
            //    //colAnimType.DisplayMember = "AnimalType";//"Name";
            //    //colAnimType.ValueMember =  "ID";//"ID";*/
            //    foreach (var type in Enum.GetValues(typeof(AnimalType))) {
            //        colAnimType.Items.Add(type);
            //    }



            //    //PET - PetFood combobox
            //    DataGridViewComboBoxColumn colPetFoodType = grvPetFood.Columns["AnimType"] as DataGridViewComboBoxColumn;
            //    //colPetFoodType.DataSource = petShop.Foods;//GetUniversities();
            //    //colPetFoodType.DisplayMember = "Animaltype";//"Name";
            //    //colPetFoodType.ValueMember = "ID";//"ID";*/

            //    foreach (var type in Enum.GetValues(typeof(AnimalType))) {
            //        colPetFoodType.Items.Add(type);
            //    }

            //    /*foreach (var type in Enum.GetValues(typeof(EmployeeType))) {
            //        EmpType.Items.Add(type);
            //    }*/





            //    //Employees - Employee combobox
            //    DataGridViewComboBoxColumn colEmpType = grvEmployees.Columns["EmpType"] as DataGridViewComboBoxColumn;
            //    foreach (var type in Enum.GetValues(typeof(EmployeeType))) {
            //        colEmpType.Items.Add(type);
            //    }

        }


















        private void gridControl1_Click(object sender, EventArgs e) {


        }

        private void xtraTabCustomers_Paint(object sender, PaintEventArgs e) {

        }

        // This event is generated by Data Source Configuration Wizard
        void UnboundSource_ValuePushed(object sender, DevExpress.Data.UnboundSourceValuePushedEventArgs e) {
            // Handle this event to save modified data back to your data source
            // something = e.Value; /* TODO: Propagate the value into the storage.*/
        }

        private void grvEmployees_Click(object sender, EventArgs e) {

        }
    }
}