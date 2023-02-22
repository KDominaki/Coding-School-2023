using Session30.EF.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session30.WF
{
    public partial class ItemsView : Form
    {
        private ItemRepo _itemRepo = new ItemRepo();
        public ItemsView()
        {
            InitializeComponent();
        }

        private void ItemsView_Load(object sender, EventArgs e)
        {
            GridData();
        }


        private void GridData()
        {
            var dt = _itemRepo.GetAll();
            itemsGridView.DataSource = dt;
        }
    }
}
