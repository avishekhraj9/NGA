using RazorItemApp.Models;
using System.Collections.Generic;

namespace RazorItemApp.Services
{
    public class ItemService
    {
        // Static list (acts like database)
        public static List<Item> Items = new List<Item>
        {
            new Item { Id = 1, Name = "Laptop" },
            new Item { Id = 2, Name = "Mobile" }
        };

        // Add new item
        public void AddItem(Item item)
        {
            item.Id = Items.Count + 1;
            Items.Add(item);
        }

        // Get all items
        public List<Item> GetItems()
        {
            return Items;
        }
    }
}