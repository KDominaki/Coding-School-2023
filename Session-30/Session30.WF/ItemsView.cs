using Session30.EF.Repositories;
using Session30.Models;
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

        private void AddItem()
        {
            var item = new Item();
            item.Description = descriptionTextBox.Text;
            item.Cost = Convert.ToDecimal(CostTextBox.Text);
            item.Price = Convert.ToDecimal(priceTextBox.Text);
            if(typeTextBox.Text.ToLower() == "fuel")
            {
                item.ItemType = Models.Enums.ItemType.Fuel;
            }
            else if(typeTextBox.Text.ToLower() == "product")
            {
                item.ItemType = Models.Enums.ItemType.Product;
            }
            else if (typeTextBox.Text.ToLower() == "service")
            {
                item.ItemType = Models.Enums.ItemType.Service;
            }
            _itemRepo.Add(item);
        }

        private void itemAddBtn_Click(object sender, EventArgs e)
        {
            AddItem();
        }
    }
}
