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

        public void Delete(int id)
        {
            CashierKanDatabase.GetInstance().Items.Remove(Get(id));
            CashierKanDatabase.GetInstance().SaveChanges();
        }

        public Item Get(int id)
        {
            return CashierKanDatabase.GetInstance().Items.Find(id);
        }

        public List<Item> GetAll()
        {
            return CashierKanDatabase.GetInstance().Items.ToList();
        }

        public void Update(int id, Item newItem)
        {
            Item targetItem = Get(id);

            targetItem.Price = newItem.Price;
            targetItem.Name = newItem.Name;
            targetItem.Type = newItem.Type;
            
            CashierKanDatabase.GetInstance().SaveChanges();
        }
    }
}