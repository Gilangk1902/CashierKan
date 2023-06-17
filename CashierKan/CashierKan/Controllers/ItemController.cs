using CashierKan.Factory;
using CashierKan.Handler;
using CashierKan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierKan.Controllers
{
    public class ItemController
    {
        private static ItemHandler itemHandler = new ItemHandler();

        public static void AddItem(string name, string type, string price)
        {
            itemHandler.Add(ItemFactory.Create(name, type, price));
        }
        public static void Update(string targetId, string name, string type, string price)
        {
            itemHandler.Update(targetId, ItemFactory.Create(name, type, price));
        }
        public static Item Get(string id)
        {
            return itemHandler.Get(id);
        }

        public static List<Item> GetAll()
        {
            return itemHandler.GetAll();
        }

        public static List<Item> SearchItems(string searchQuery)
        {
            List<Item> allItem = GetAll();
            List<Item> searchResult = new List<Item>();
            foreach(Item item in allItem)
            {
                if (item.name.Contains(searchQuery))
                {
                    searchResult.Add(item);
                }
            }
            return searchResult;
        }

        public static string GetId(string name) {
            List<Item> allItems = GetAll();
            string id = "";
            foreach (Item item in allItems)
            {
                if (item.name.Equals(name))
                {
                    id = item.itemId;
                }
            }
            return id;
        }

        public static bool Validate(string name, string type, string price)
        {
            if(name.Length<=0 || type.Length<=0 || price.Length <= 0)
            {
                return false;
            }
            else if (ContainsLetter(price))
            {
                return false;
            }
            return true;
        }
        private static bool ContainsLetter(string price)
        {
            foreach(char c in price)
            {
                if(char.IsLetter(c)) return true;
            }
            return false;
        }
    }
}