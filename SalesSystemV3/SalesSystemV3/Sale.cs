using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystemV3
{
    class Sale
    {
        // Stores list of Items
        // Has Id, time, Date, description, quantities, total $

        public List<Item> Items = new List<Item>();
        public int ID { get; set; }
        public int totalPrice { get; set; }
        public int discount { get; set; }
        public DateTime date { get; set; }
        public string notes { get; set; }

        // basic sale, no discount or notes
        public Sale(List<Item> items)
        {
            ID = Controller.GetController().Data.GetNextID();
            date = DateTime.Now;
            Items = items;

            // calc total price
            foreach(Item I in items)
            {
                totalPrice += I.SalePrice;
            }
        }

        // add overload constructors 
        
    }
}
