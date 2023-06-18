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
        public static Item Create(string name, int type, int price)
        {
            Item newItem = new Item
            {
                Name = name,
                Type = type,
                Price = price
            };

            return newItem;
        }
    }
}