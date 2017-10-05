using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystemV3
{
    class Inventory
    {
        // Dictionary of Items and ID number
        private Dictionary<int, Item> _itemList = new Dictionary<int, Item>();
        

        public Inventory() { }


        // returns Next avalable ID number for item (starts at 0)
        public int GetNextID()
        {
            try {
                return _itemList.Keys.Max() + 1;
            }
            catch (Exception)
            { return 0; }
        }


        // Add new item to Item List
        public void AddItem(Item i)
        {
            _itemList.Add(GetNextID(), i);
        }


        // Store the new item in existing ID position
        public void UpdateItem(Item i, int id)
        {
            _itemList[id] = i;
        }


        // Returns list of items in inventory
        public List<Item> getItemsList()
        {
            List<Item> items = new List<Item>();

            foreach(KeyValuePair<int, Item> item in _itemList)
            {
                items.Add(item.Value);
            }

            return items;
        }





    }
}
