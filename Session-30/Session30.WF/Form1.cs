namespace Session30.WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ManagerBtn_Click(object sender, EventArgs e)
        {
            ManagerMain manager = new ManagerMain();
            manager.ShowDialog();

        }

        private void ChashierBtn_Click(object sender, EventArgs e)
        {
            ChashierMain chashier= new ChashierMain();
            chashier.ShowDialog();
        }

        private void StuffBtn_Click(object sender, EventArgs e)
        {
            ItemsView items = new ItemsView();
            items.ShowDialog();
        }
    }
}