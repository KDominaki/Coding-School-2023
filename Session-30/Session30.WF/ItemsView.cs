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




        //Methods

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

        private void DeleteCustomer()
        {
            if (idTextBox.Text != "")
            {
                var itemId = Convert.ToInt32(idTextBox.Text);
                _itemRepo.Delete(itemId);

            }
        }

        private void GetItem()
        {
            var itemId = Convert.ToInt32(idTextBox.Text);
            var item = _itemRepo.GetById(itemId);
            if (item != null)
            {
                descriptionTextBox.Text = item.Description;
                typeTextBox.Text = item.ItemType.ToString();
                CostTextBox.Text = item.Cost.ToString();
                priceTextBox.Text = item.Price.ToString();
                errorLabel.Text = "";
            }
            else
            {
                errorLabel.Text = $"There is no item with id:{itemId}";
            }
         
        }

        private void EditItem()
        {
            if (idTextBox.Text != "")
            {
                var itemId = Convert.ToInt32(idTextBox.Text);
                var itemEntity = new Item();
                {
                    itemEntity.Description = descriptionTextBox.Text;
                    itemEntity.Cost = Convert.ToDecimal(CostTextBox.Text);
                    itemEntity.Price = Convert.ToDecimal(priceTextBox.Text);

                    if (typeTextBox.Text.ToLower() == "fuel")
                    {
                        itemEntity.ItemType = Models.Enums.ItemType.Fuel;
                    }
                    else if (typeTextBox.Text.ToLower() == "product")
                    {
                        itemEntity.ItemType = Models.Enums.ItemType.Product;
                    }
                    else if (typeTextBox.Text.ToLower() == "service")
                    {
                        itemEntity.ItemType = Models.Enums.ItemType.Service;
                    }
                }
                _itemRepo.Update(itemId, itemEntity);

            }
        }


        // Buttons
        private void itemAddBtn_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                EditItem();
            }
            else
            {
                AddItem();
            }
            descriptionTextBox.Text = "";
            typeTextBox.Text = "";
            CostTextBox.Text = "";
            priceTextBox.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
            idTextBox.Text = "";
            descriptionTextBox.Text = "";
            typeTextBox.Text = "";
            CostTextBox.Text = "";
            priceTextBox.Text = "";
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            GetItem();
        }

    }
}
