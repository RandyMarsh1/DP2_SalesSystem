using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesSystemV3
{
    public partial class Form1 : Form
    {
        private BindingSource _itemList = new BindingSource();
        private BindingSource _SaleList = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            // sample data
            Controller.GetController().Inv.AddItem(new Item(0, 10, 20, "Item 1", "Item 1 Description", "General"));
            Controller.GetController().Inv.AddItem(new Item(1, 20, 45, "Item 2", "Description of Item 2", "Drugs"));

            // Bind Inventory item list to datasource
            _itemList.DataSource = Controller.GetController().Inv.getItemsList();
            _SaleList.DataSource = Controller.GetController().Data.getSalesList();

            // Bind datasource to combobox
            itemNamecomboBox.DataSource = _itemList;
            itemNamecomboBox.DisplayMember = "Name";
            //itemNamecomboBox.ValueMember = "ID";


            SalesdataGridView.DataSource = _SaleList;
        }

        private void nextIDButton_Click(object sender, EventArgs e)
        {
            nextIDText.Text = Controller.GetController().Inv.GetNextID().ToString();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            int id = Controller.GetController().Inv.GetNextID();
            string name = itemNametextBox.Text;
            string descrip = itemDestextBox.Text;
            string cat = itemCattextBox.Text;
            int cost = Convert.ToUInt16( itemCosttextBox.Text );
            int sale = Convert.ToUInt16( itemSaletextBox.Text );

            // Do some error checking

            // add entered item into inventory list
            Controller.GetController().Inv.AddItem( new Item(id, cost, sale, name, descrip, cat));


            _itemList.ResetBindings(false); // is ment to update combobox but doesnt?
            _itemList.DataSource = Controller.GetController().Inv.getItemsList(); // rebinding does update

        }

        private void ItemListbutton_Click(object sender, EventArgs e)
        {
            string itemNames = "";
            foreach(Item I in Controller.GetController().Inv.getItemsList())
            {
                itemNames += I.Name + "\n";
            }

            ItemNameListrichTextBox.Text = itemNames;

        }

        private void itemNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item I = itemNamecomboBox.SelectedItem as Item;

            ItemPricetextBox.Text = "$" + I.SalePrice;
            DescriptextBox1.Text = I.Description;
            CatagorytextBox2.Text = I.Catagory;
        }

        private void AddSalebutton_Click(object sender, EventArgs e)
        {
            Item I = itemNamecomboBox.SelectedItem as Item;



            Controller.GetController().Data.AddSale(I);


            SalesdataGridView.DataSource = Controller.GetController().Data.getSalesList();
        }


    }
}
