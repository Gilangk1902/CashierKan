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

        public static void AddItem(string name, int type, int price)
        {
            itemHandler.Add(ItemFactory.Create(name, type, price));
        }
        public static void Update(int targetId, string name, int type, int price)
        {
            itemHandler.Update(targetId, ItemFactory.Create(name, type, price));
        }
        public static Item Get(int id)
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
                if (item.Name.Contains(searchQuery))
                {
                    searchResult.Add(item);
                }
            }
            return searchResult;
        }

        public static int GetId(string name) {
            List<Item> allItems = GetAll();
            int id = 0;
            foreach (Item item in allItems)
            {
                if (item.Name.Equals(name))
                {
                    id = item.Id;
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