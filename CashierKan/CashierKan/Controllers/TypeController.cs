using CashierKan.Handler;
using CashierKan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierKan.Controllers
{
    public class TypeController
    {
        private static TypeHandler typeHandler = new TypeHandler();
        public static int GetId(string name)
        {
            List<ItemType> types = typeHandler.GetAll();
            foreach (ItemType type in types)
            {
                if (type.Name == name)
                {
                    return type.Id;
                }
            }
            return 0;
        }
    }
}
