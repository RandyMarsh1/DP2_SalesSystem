using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystemV3
{
    class SaleItem
    {

        public int saleID { get; }
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
}
