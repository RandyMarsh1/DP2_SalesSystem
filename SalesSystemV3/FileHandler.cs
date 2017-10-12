using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SalesSystemV3
{
    class FileHandler
    {
        // Filename string
        private string _inventorypath = "inventory.csv";
        private string _transactionpath = "transactions.csv";

        //Load, Save, Create
        public void InvReadFromFile(string path)
        {
            List<Item> result = new List<Item>();
            StreamReader reader = new StreamReader(path);
            string line;

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                Item item = new Item();

                List<string> values = line.Split(',').ToList();

                item.ID = int.Parse(values[0]);
                item.Name = values[1];
                item.Description = values[2];
                item.Catagory = values[3];
                item.Quantity = int.Parse(values[4]);
                item.CostPrice = int.Parse(values[5]);
                item.SalePrice = int.Parse(values[6]);

                result.Add(item);
            }

            Controller.GetController().Inv.ClearInventory();
            
            foreach (Item item in result)
            {
                Controller.GetController().Inv.AddItem(item);
            }

            reader.Close();
        }

		public void InvWriteToFile(string path)
		{
			List<Item> result = new List<Item>();
			StreamWriter writer = new StreamWriter(path);
			string line;

            foreach (Item item in Controller.GetController().Inv.getItemsList())
			{
                line = string.Format("{0},{1},{2},{3},{4},{5},{6}", item.ID.ToString(), item.Name, item.Description, item.Catagory, item.Quantity.ToString(), item.CostPrice.ToString(), item.SalePrice.ToString());

				writer.WriteLine(line);
			}

            writer.Close();
		}

        public void TransactionsReadFromFile(string path)
        {
            StreamReader reader = new StreamReader(path);

            List<Item> itemlist = new List<Item>();
            string saleline, itemline;
            int itemcount;

            Controller.GetController().Data.ClearSales();

            while (!reader.EndOfStream)
            {
                saleline = reader.ReadLine();
                itemcount = int.Parse(reader.ReadLine());

                if (itemcount > 0)
                {
                    for (int i = 0; i < itemcount; i++)
                    {
                        itemline = reader.ReadLine();
                        //List<string> iteminfo = itemline.Split(',').ToList();
                        itemlist.Add(Controller.GetController().Inv.getItemsList()[int.Parse(itemline)]);
                    }
                }

                Sale s = Controller.GetController().Data.AddSale(itemlist);

                List<string> saleinfo = saleline.Split(',').ToList();
                s.ID = int.Parse(saleinfo[0]);
                s.date = DateTime.FromBinary(long.Parse(saleinfo[1]));
                s.totalPrice = int.Parse(saleinfo[2]);
                s.discount = int.Parse(saleinfo[3]);
                s.notes = saleinfo[4];
            }
            
            reader.Close();
        }
        

        public void TransactionsWriteToFile(string path)
        {
            StreamWriter writer = new StreamWriter(path);
            string line;

            foreach (Sale sale in Controller.GetController().Data.getSalesList())
            {
                line = string.Format("{0},{1},{2},{3},{4}", sale.ID.ToString(), sale.date.ToBinary().ToString(), sale.totalPrice.ToString(), sale.discount.ToString(), sale.notes);
                writer.WriteLine(line);

                writer.WriteLine(sale.Items.Count);
                if (sale.Items.Count > 0)
                {
                    foreach (Item item in sale.Items)
                    {
                        //line = string.Format("{0}", item.ID.ToString());
                        line = item.ID.ToString();
                        writer.WriteLine(line);
                    }
                }
            }

            writer.Close();
        }

        // Inport, Export CSV
    }
}
