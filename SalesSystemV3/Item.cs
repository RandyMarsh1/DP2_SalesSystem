using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystemV3
{
    class Item
    {
        // Instance of an item, Has ID, name, catagory, cost price, sale price and description

        public int ID { get; set; }
        public string Name { get; set; }
        public string Catagory { get; set; }
        public int CostPrice { get; set; }
        public int SalePrice { get; set; }
        public int Quantity { get; set; }         
        public string Description { get; set; }
        

        // Default constructor, creates an empty item
        public Item() { }

        // Overload Contructor: add new item
        public Item(int id, string name, string catagory, int costPrice, int salePrice,  string description, int qty)
        {
            ID = id;
            Name = name;
            Catagory = catagory;
            CostPrice = costPrice;
            SalePrice = salePrice;            
            Description = description;
            Quantity = qty;
            
        }

    }
}
