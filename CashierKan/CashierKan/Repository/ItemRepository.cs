using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CashierKan.Models;

namespace CashierKan.Repository
{
    public class ItemRepository : IRepository<Item>
    {
        public void Add(Item item)
        {
            CashierKanDatabase.GetInstance().Items.Add(item);
            CashierKanDatabase.GetInstance().SaveChanges();
        }

        public void Delete(string id)
        {
            CashierKanDatabase.GetInstance().Items.Remove(Get(id));
            CashierKanDatabase.GetInstance().SaveChanges();
        }

        public Item Get(string id)
        {
            return CashierKanDatabase.GetInstance().Items.Find(id);
        }

        public List<Item> GetAll()
        {
            return CashierKanDatabase.GetInstance().Items.ToList();
        }

        public void Update(string id, Item newItem)
        {
            Item targetItem = Get(id);

            targetItem.price = newItem.price;
            targetItem.name = newItem.name;
            targetItem.type = newItem.type;
            
            CashierKanDatabase.GetInstance().SaveChanges();
        }
    }
}