using CashierKan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CashierKan.Repository;

namespace CashierKan.Handler
{
    public class ItemHandler : IHandler<Item>
    {
        private ItemRepository repository = new ItemRepository();
        public void Add(Item obj)
        {
            repository.Add(obj);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public Item Get(int id)
        {
            return repository.Get(id);
        }

        public List<Item> GetAll()
        {
            return repository.GetAll();
        }

        public void Update(int targetId, Item obj)
        {
            repository.Update(targetId, obj);
        }
    }
}