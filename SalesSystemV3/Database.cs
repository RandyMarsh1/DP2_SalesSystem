using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystemV3
{
    class Database
    {
        // Sales, List/dictionary of all sales
        private Dictionary<int, Sale> _sales = new Dictionary<int, Sale>();

        // Search, return list of Sales, has a few overload methods for different search types
        // Add, Edit
        // Sort, used by search

        public Database() { }

        // returns Next avalable ID number for sales
        public int GetNextID()
        {
            try
            {
                return _sales.Keys.Max() + 1;
            }
            catch (Exception)
            { return 0; }
        }

        // need a way of adding multi items in single sale at once
        public void AddSale(Item i)
        {
            List<Item> item = new List<Item>();
            item.Add(i);

            _sales.Add(GetNextID(), new Sale(item));
        }

        
        public void AddSale(Item i, string note)
        {
            List<Item> item = new List<Item>();
            item.Add(i);

            Sale s = new Sale(item);
            s.notes = note;

            _sales.Add(GetNextID(), s);
        }

        public void AddSale(Sale s)
        {
            _sales.Add(GetNextID(), s);
        }

        public void RemoveSale(Sale s)
        {
            _sales.Remove(s.ID);
        }

        // Returns list of Sales in database
        public List<Sale> getSalesList()
        {
            List<Sale> sales = new List<Sale>();

            foreach (KeyValuePair<int, Sale> s in _sales)
            {
                sales.Add(s.Value);
            }

            return sales;
        }

    }
}
