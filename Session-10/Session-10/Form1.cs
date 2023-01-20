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

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeUniversity();
        }

        private void MakeUniversity()
        {
            University university = new University();
            university.GetStudents();

            List<Course> courses = new List<Course>();

            Course courseOne = new Course()
            {
                Subject = "Biology",
                Code = "00001"
            };
            courses.Add(courseOne);
            Course courseTwo = new Course()
            {
                Subject = "Chemistry",
                Code = "00002"
            };
            courses.Add(courseTwo);

            List<Schedule> schedules= new List<Schedule>();

            Schedule scheduleOne = new Schedule();
            schedules.Add(scheduleOne);
            Schedule scheduleTwo = new Schedule();
            schedules.Add (scheduleTwo);
            
        

            dataGridView1.DataSource = university.Students;
            dataGridView2.DataSource = courses;
            dataGridView3.DataSource = university.Grades;
            dataGridView4.DataSource = schedules;
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

       
    }
}