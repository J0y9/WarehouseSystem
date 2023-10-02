using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem
{
    public class Warehouse
    {
        private List<Item> items;

        public Warehouse()
        {
            items = new List<Item>();
        }
        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(int itemId)
        {
            var itemToRemove = items.FirstOrDefault(i => i.Id == itemId);
            if (itemToRemove != null)
            {
                items.Remove(itemToRemove);
            }
            else
            {
                throw new Exception("Item not found");
            }
        }

        public void Clear()
        {
            items.Clear();
        }

        public void ShowItems()
        {
            if (items.Count > 0)
            {
                foreach (var item in items)
                {
                    Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Price: ${item.Price}, Quantity: {item.Quantity}");

                }
            }
            else
            {
                throw new Exception("Warehouse is empty");
            }
        }
    }
}
