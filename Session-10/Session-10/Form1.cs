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
            Properties();
            MakeUniversity(_university);
        }

        private void MakeUniversity(University university)
        {
            university = new University();
            university.CreateStudentList();
            university.GetStudent(95636, "Kostas", "Dimitropoulos");
            university.GetStudent(4854985, "James", "Bond");
            university.GetGrades();
            university.GetCourses();
            university.SetSchedule();
            DataSourses(university);
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

        // Αυτά τα έβαλα καταλάθος, αλλά φοβάμαι ελαφρός να τα ακουμπίσω τώρα
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