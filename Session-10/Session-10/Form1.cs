using ClassLibrary1;
using Session_06;

namespace Session_10
{
    public partial class Form1 : Form
    {
       
   
        public Form1()
        {
            InitializeComponent();
        }

        private void MakeUniversity()
        {    List <Student> students= new List<Student>();
            //University university = new University()
            //{
                
            //};
            Student studentOne= new Student();
            students.Add(studentOne);
            //university.Students.Add(studentOne);
            dataGridView1.DataSource = students;
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeUniversity();
        }
    }
}