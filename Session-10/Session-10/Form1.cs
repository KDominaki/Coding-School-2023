using ClassLibrary1;
using Session_06;

namespace Session_10
{
    public partial class Form1 : Form
    {
        private University _university;
   
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
            _university = new University();
            _university.GetStudents();
            _university.GetGrades();
            _university.GetCourses();
            _university.SetSchedule();
            Properties();
            DataSourses(_university);
        }

        public void Properties()
        {

            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView3.AutoGenerateColumns = false;
            dataGridView4.AutoGenerateColumns = false;

        }   
        public void DataSourses(University university)
        {
            dataGridView1.DataSource = university.Students;
            dataGridView2.DataSource = university.Courses;
            dataGridView3.DataSource = university.Grades;
            dataGridView4.DataSource = university.ScheduledCourse;
        }
    

        private void btnSave_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(_university, "university.json");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            _university = serializer.Deserialize<University>("university.json");
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