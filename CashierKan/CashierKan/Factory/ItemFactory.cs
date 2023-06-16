using CashierKan.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CashierKan.Factory
{
    public class ItemFactory
    {
        public static Item Create(string name, string type, string price)
        {
            Item newItem = new Item
            {
                itemId = CreateId(),
                name = name,
                type = type,
                price = price
            };

            return newItem;
        }

        private static string CreateId()
        {
            Random random = new Random();

            string itemIdCode = "IT";
            
            int randomNumber = random.Next(100, 1000);
            string randomNumber_str = randomNumber.ToString();

            return itemIdCode + randomNumber_str;
        }
    }
}