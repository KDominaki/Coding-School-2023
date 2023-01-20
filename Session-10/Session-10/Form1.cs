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
            university.GetGrades();
            university.GetCourses();
            Properties(university);

            //university.SetSchedule();


            List<Schedule> schedules= new List<Schedule>();

            Schedule scheduleOne = new Schedule();
            schedules.Add(scheduleOne);
            Schedule scheduleTwo = new Schedule();
            schedules.Add (scheduleTwo);

           
            dataGridView4.DataSource = schedules;
        }

        public void Properties(University university)
        {

            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView3.AutoGenerateColumns = false;
            dataGridView4.AutoGenerateColumns = false;

            dataGridView1.DataSource = university.Students;
            dataGridView2.DataSource = university.Courses;
            dataGridView3.DataSource = university.Grades;
            //dataGridView4.DataSource = university.ScheduledCourse;
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