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
        public int CostPrice { get; set; }
        public int SalePrice { get; set; }
        public int Quantity { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Catagory { get; set; }

        // Default constructor, creates an empty item
        public Item() { }

        // Overload Contructor: add new item
        public Item(int id, int costPrice, int salePrice, string name, string description, string catagory)
        {
            ID = id;
            CostPrice = costPrice;
            SalePrice = salePrice;
            Name = name;
            Description = description;
            Catagory = catagory;
        }

    }
}
