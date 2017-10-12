using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesSystemV3
{
    public partial class Form2 : Form
    {

        private BindingSource _itemList = new BindingSource();
        private BindingSource _SaleList = new BindingSource();

        private List<Item> CurrentItems = new List<Item>();
        private Sale currentSale;
        

        // Constructor
        // setup reference to database and inventory lists
        public Form2()
        {
            InitializeComponent();

            // sample data (delete later)
            Controller.GetController().Inv.AddItem(new Item(0, "Item 1", "General", 6, 12, "Item 1 Description", 1 ));
            Controller.GetController().Inv.AddItem(new Item(1, "Item 2", "Drugs", 20, 50, "Description of Item 2", 1 ));
            Controller.GetController().Data.AddSale(new Item(4, "Item 1", "Drugs", 20, 50, "Description of Item 1", 1), "First Sale!");
            Controller.GetController().Data.AddSale(new Item(2, "Item 2", "Drugs", 10, 15, "Description of Item 2", 1));
            Controller.GetController().Data.AddSale(new Item(3, "Item 3", "Fun Drugs", 30, 35, "Description of Item 3", 2), "much notes, such sales");
            Controller.GetController().Data.AddSale(new Item(4, "Item 4", "Drugs", 5, 950, "Description of Item 4", 6), "Makin dat money yo!");


            // Bind Inventory item list to datasource
            _itemList.DataSource = Controller.GetController().Inv.getItemsList();
            _SaleList.DataSource = Controller.GetController().Data.getSalesList();

            dataGridViewItems.DataSource = _itemList;
            dataGridViewSales.DataSource = _SaleList;

            // Update ID number textboxes
            textBoxID.Text = Controller.GetController().Inv.GetNextID().ToString();
            textBoxsaleID.Text = Controller.GetController().Data.GetNextID().ToString();
            dateTime1.Text = DateTime.Now.ToString();

            // Item list in combo box, display "Name" Column
            comboBoxItemslist.DataSource = _itemList;
            comboBoxItemslist.DisplayMember = "Name";
        }


        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Run the local help file using the user's default browser
            // Hotkey is currently CTRL + F1
            // Need to make sure that the path is from the local directory ONLY!
            System.Diagnostics.Process.Start("Help.html");
        }


        
            /// Inventory Tab ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// Inventory Tab ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// Inventory Tab ////////////////////////////////////////////////////////////////////////////////////////////////////////////


            // Add Item to inventory button
            private void buttonAddItemInv_Click(object sender, EventArgs e)
        {        
            // Error check fields
            if (String.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show(" No Item Name Entered ");
            }
            else if (String.IsNullOrWhiteSpace(comboBoxCatagory.Text))
            {
                MessageBox.Show(" No Category Selected ");
            }
            else if (validateInt(textBoxCost.Text) < 0)
            {
                MessageBox.Show(" No Cost Price Entered ");
            }
            else if (validateInt(textBoxSale.Text) < 0)
            {
                MessageBox.Show(" No Sale Price Entered ");
            }
            else
            {

                try
                {
                    // Get data from fields
                    int id = Convert.ToInt16(textBoxID.Text);
                    string name = textBoxName.Text;
                    string description = richTextBoxDescription.Text;
                    string catagory = comboBoxCatagory.Text;
                    int cost = Convert.ToInt16(textBoxCost.Text);
                    int sale = Convert.ToInt16(textBoxSale.Text);

                    // add entered item into inventory list
                    Controller.GetController().Inv.AddItem(new Item(id, name, catagory, cost, sale, description, 1));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //rebind to update datagridview
                _itemList.DataSource = Controller.GetController().Inv.getItemsList();

                // Update ID to next
                textBoxID.Text = Controller.GetController().Inv.GetNextID().ToString();
            }

        }
        

        // Seleted Item changed, auto fill info boxes
        private void comboBoxItemslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Item I = comboBoxItemslist.SelectedItem as Item;

                textBoxitemID.Text = I.ID.ToString();
                comboBoxItemCat.Text = I.Catagory;
                textBoxCostsale.Text = I.CostPrice.ToString();
                textBoxsaleprice.Text = I.SalePrice.ToString();
                richTextBoxDescrip.Text = I.Description;
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        // 
        private void buttonEdititem_Click(object sender, EventArgs e)
        {
            // Error check input data
            if (validateInt(textBoxeditID.Text) < 0)
            {
                MessageBox.Show(" Invalid ID ");
            }
            else if (String.IsNullOrWhiteSpace(textBoxeditName.Text))
            {
                MessageBox.Show("Invalid Name ");
            }
            else if (String.IsNullOrWhiteSpace(comboBoxeditCat.Text))
            {
                MessageBox.Show(" Invalid Category ");
            }
            else if (validateInt(textBoxeditCost.Text) < 0)
            {
                MessageBox.Show(" Invalid Cost Price Entered ");
            }
            else if (validateInt(textBoxeditSale.Text) < 0)
            {
                MessageBox.Show(" Invalid Sale Price Entered ");
            }
            else
            {
                try
                {   // Create new item, add info
                    Item i = (Item)dataGridViewItems.CurrentRow.DataBoundItem;
                    i.ID = toInt(textBoxeditID.Text);
                    i.Name = textBoxeditName.Text;
                    i.Description = richTextBoxeditDescrip.Text;
                    i.Catagory = comboBoxeditCat.Text;
                    i.CostPrice = toInt(textBoxeditCost.Text);
                    i.SalePrice = toInt(textBoxeditSale.Text);

                    _itemList.DataSource = Controller.GetController().Inv.getItemsList();

                }
                catch (Exception) { }
            }
        }

        // Selected row on Inventory datagridview changed, update selected item in edit panel
        private void dataGridViewItems_RowEnter(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Item i = (Item)dataGridViewItems.CurrentRow.DataBoundItem;
                textBoxeditID.Text = i.ID.ToString();
                textBoxeditName.Text = i.Name;
                richTextBoxeditDescrip.Text = i.Description;
                comboBoxeditCat.Text = i.Catagory;
                textBoxeditCost.Text = i.CostPrice.ToString();
                textBoxeditSale.Text = i.SalePrice.ToString();
            }
            catch (Exception) { }
        }

        // Delete item in currently selected inventory row
        private void buttonDeleteEdit_Click(object sender, EventArgs e)
        {
            Controller.GetController().Inv.RemoveItem((Item)dataGridViewItems.CurrentRow.DataBoundItem);
            _itemList.DataSource = Controller.GetController().Inv.getItemsList();
        }

        /// end Inventory tab
        /// 
        /// 
        /// Sales tab  ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Sales tab  ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Sales tab  ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        // Add a item to sale basket
        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            
            Item item = new Item();

            item.ID = toInt(textBoxitemID.Text);                        
            item.Quantity = Convert.ToInt32( comboBoxQtysale.Text);
            item.Name = comboBoxItemslist.Text;
            item.Catagory = comboBoxItemCat.Text;
            item.CostPrice = Convert.ToInt32( textBoxCostsale.Text);
            item.SalePrice = Convert.ToInt32( textBoxsaleprice.Text);
            item.Description = richTextBoxDescrip.Text;

            CurrentItems.Add(item);

            if (!_itemList.Contains((Item)comboBoxItemslist.SelectedItem))
            {
                MessageBox.Show(" New item added to Inventory ");
                item.ID = Controller.GetController().Inv.GetNextID();

                // add entered item into inventory list
                Controller.GetController().Inv.AddItem(item);
                _itemList.DataSource = Controller.GetController().Inv.getItemsList();
                textBoxID.Text = Controller.GetController().Inv.GetNextID().ToString();

            }
            
            // calc total price of all items & Qtys in basket
            int price = 0;
            foreach (Item I in CurrentItems) {
                price = price + (I.SalePrice * I.Quantity);
            }
                       
            // Reset/clear sale panel textboxes
            listBox1.DataSource = null;
            listBox1.DataSource = CurrentItems;
            listBox1.DisplayMember = "Name";
            listBox2.DataSource = null;
            listBox2.DataSource = CurrentItems;
            listBox2.DisplayMember = "Quantity";

            textBoxPrice.Text = price.ToString();

            textBoxTotal.Text = (toInt(textBoxPrice.Text) - toInt(textBoxDiscount.Text)).ToString();
            
        }

        // Add current sale to database
        private void buttonAddSale_Click(object sender, EventArgs e)
        {
            // Check theres items in the sale
            if (CurrentItems.Count == 0)
            {
                MessageBox.Show(" No Items in Sale ");
            }
            else
            {
                // Create new Sale object and add required info from fields
                Sale s = new Sale();
                try
                {
                    s.ID = Convert.ToInt32(textBoxsaleID.Text);
                    s.date = dateTime1.Value;
                    s.discount = toInt(textBoxDiscount.Text);
                    s.totalPrice = toInt(textBoxTotal.Text);
                    s.notes = richTextBoxNotes.Text;

                    s.Items.AddRange(CurrentItems);

                    Controller.GetController().Data.AddSale(s);

                }
                catch (Exception ex)  {MessageBox.Show(ex.Message); }

                // Update saleslist
                _SaleList.DataSource = Controller.GetController().Data.getSalesList();

                // clear boxes
                textBoxsaleID.Text = Controller.GetController().Data.GetNextID().ToString();
                dateTime1.Value = DateTime.Now;
                textBoxPrice.Clear();
                textBoxTotal.Clear();
                textBoxDiscount.Clear();
                richTextBoxNotes.Clear();
                CurrentItems.Clear();
                listBox1.DataSource = null;
                listBox1.DataSource = CurrentItems;
                listBox1.DisplayMember = "Name";
                listBox2.DataSource = null;
                listBox2.DataSource = CurrentItems;
                listBox2.DisplayMember = "Quantity";
            }
            
        }

       
        // Selected item in grid view changed, Show selected sales info in edit panel
        private void dataGridViewSales_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                // get instance of item selected
                Sale s = (Sale)dataGridViewSales.CurrentRow.DataBoundItem;
                currentSale = s;

                // display in edit panel textboxes
                textBoxEditSaleID.Text = s.ID.ToString();
                dateTime2.Value = s.date;

                textBoxEditDiscount.Text = s.discount.ToString();
                textBoxEditPrice.Text = s.totalPrice.ToString();
                textBoxEditTotal.Text = (s.totalPrice - s.discount).ToString();
                richTextBoxEditNotes.Text = s.notes;

                listBox3.DataSource = null;
                listBox3.DataSource = s.Items;
                listBox3.DisplayMember = "Name";

                

            }
            catch (Exception) { }
        }

        // Convert string to int, Returns 0 if invalid
        private int toInt(string text) {
            int i = 0;
            if(!Int32.TryParse(text, out i))  { i = 0; }
            return i;
        }

        // Convert string to int, Returns -1 if invalid
        private int validateInt(string text)
        {
            int i = 0;
            if (!Int32.TryParse(text, out i)) { i = -1; }
            return i;
        }

        // Remove Item from basket button
        private void buttonRemoveBasket_Click(object sender, EventArgs e)
        {
            Item I = (Item)listBox1.SelectedItem;
            CurrentItems.Remove(I);

            // Reset/clear textboxes
            listBox1.DataSource = null;
            listBox1.DataSource = CurrentItems;
            listBox1.DisplayMember = "Name";
            listBox2.DataSource = null;
            listBox2.DataSource = CurrentItems;
            listBox2.DisplayMember = "Quantity";
        }

        
        // Delete currently selected sale from database
        private void buttonDeleteSale_Click(object sender, EventArgs e)
        {
            Controller.GetController().Data.RemoveSale((Sale)dataGridViewSales.CurrentRow.DataBoundItem);
            _SaleList.DataSource = Controller.GetController().Data.getSalesList();

        }

        // Update Sale data after edit
        private void buttonUpdateSale_Click(object sender, EventArgs e)
        {
            Sale s = (Sale)dataGridViewSales.CurrentRow.DataBoundItem;

            try
            {
                s.ID = toInt(textBoxEditSaleID.Text);
                s.date = dateTime2.Value;
                s.discount = toInt(textBoxEditDiscount.Text);
                s.totalPrice = toInt(textBoxEditTotal.Text);
                s.notes = richTextBoxEditNotes.Text;
            }
            catch (Exception) { }

            dataGridViewSales.Refresh();
        }

        // Recalculate total price with new discount applied
        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            textBoxTotal.Text = (toInt(textBoxPrice.Text) - toInt(textBoxDiscount.Text)).ToString();
        }

        // Recalculate discount with new total entered
        private void textBoxEditDiscount_TextChanged(object sender, EventArgs e)
        {
            textBoxEditTotal.Text = (toInt(textBoxEditPrice.Text) - toInt(textBoxEditDiscount.Text)).ToString();
        }


        /// end Sales tab
        /// 
        /// 
        /// Reports tab  ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Reports tab  ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Reports tab  ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        // tab has changed update stuff
        private void ReportsTabSelected(Object sender, TabControlCancelEventArgs e) {
            _SaleList.DataSource = Controller.GetController().Data.getSalesList();

            UpdateReports();
        }

        


        // Struct for formating Reports list
        private struct SaleItem
        {
            public int saleID { get;}

            public DateTime saleDate { get; }
            public String itemName { get; }
            public String Catagory { get; }            
            public int costPrice { get; }            
            public int Qty { get; }
            public int salePrice { get; }


            public SaleItem(Sale s, Item i)
            {
                saleID = s.ID;
                saleDate = s.date;
                costPrice = i.CostPrice;
                salePrice = i.SalePrice;
                itemName = i.Name;
                Catagory = i.Catagory;
                Qty = i.Quantity;
            }
        }

        //  Creates SaleItems list from all sales and items
        private void UpdateReports() {
            List<SaleItem> items = new List<SaleItem>();

            foreach (Sale S in Controller.GetController().Data.getSalesList())
            {
                foreach (Item I in S.Items)
                {
                    items.Add(new SaleItem(S, I));
                }
            }
            dataGridViewReports.DataSource = items;
        }





        // Predication 
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is estimated you will have " + Controller.GetController().Data.getSalesList().Count.ToString() + " sales tomorrow");
        }



    }

}
