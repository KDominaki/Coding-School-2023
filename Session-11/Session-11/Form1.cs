namespace Session_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnManage_Click(object sender, EventArgs e) {
            TransactionsForm form2 = new TransactionsForm();
            //Form1.Close();
            form2.Show();
        }
    }
}