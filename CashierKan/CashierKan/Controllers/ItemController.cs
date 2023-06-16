using CashierKan.Factory;
using CashierKan.Handler;
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
            if(Validate(name, type, price))
            {
                itemHandler.Add(ItemFactory.Create(name, type, price));
            }
        }

        //TODO : More Method

        private static bool Validate(string name, string type, string price)
        {
            if(name.Length==0 || type.Length==0 || price.Length==0) return false;
            else if(ContainsLetter(price)) return false;
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