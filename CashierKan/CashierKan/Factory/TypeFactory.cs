using CashierKan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierKan.Factory
{
    public class TypeFactory
    {
        public static ItemType Create(string name)
        {
            ItemType itemType = new ItemType
            {
                Name = name
            };
            return itemType;
        }
    }
}