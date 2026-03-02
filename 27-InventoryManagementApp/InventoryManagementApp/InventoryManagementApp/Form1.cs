using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementApp
{
    public partial class InventoryManagement : Form
    {
        DataTable inventory = new DataTable();
        public InventoryManagement()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            skuTextBox.Text = "";
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            descriptionTextBox.Text = "";
            quantityTextBox.Text = "";
            categoryBox.SelectedIndex = -1;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string sku = skuTextBox.Text;
            string name = nameTextBox.Text;
            string price = priceTextBox.Text;
            string description = descriptionTextBox.Text;
            string quantity = quantityTextBox.Text;

            string category = (string)categoryBox.SelectedItem;

            inventory.Rows.Add(sku, name, category, price, description, quantity);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void inventoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Description");
            inventory.Columns.Add("Quantity");

            inventoryGridView.DataSource = inventory;
        }
    }
}
