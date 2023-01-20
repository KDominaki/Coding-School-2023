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
        {   //University university = new University()
            List <Student> students= new List<Student>();
            
            Student studentOne= new Student();
            students.Add(studentOne);
            Student studentTwo = new Student();
            students.Add(studentTwo);

            List<Grade>grades = new List<Grade>();

            Grade gradeOne = new Grade();
            grades.Add(gradeOne);
            Grade gradeTwo = new Grade();
            grades.Add(gradeTwo);

            List<Course> courses = new List<Course>();

            Course courseOne = new Course();
            courses.Add(courseOne);
            Course courseTwo = new Course();
            courses.Add(courseTwo);

            List<Schedule> schedules= new List<Schedule>();

            Schedule scheduleOne = new Schedule();
            schedules.Add(scheduleOne);
            Schedule scheduleTwo = new Schedule();
            schedules.Add (scheduleTwo);
            
        

            dataGridView1.DataSource = students;
            dataGridView2.DataSource = grades;
            dataGridView3.DataSource = courses;
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