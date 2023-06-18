using CashierKan.Models;
using CashierKan.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierKan.Handler
{
    public class TypeHandler : IHandler<ItemType>
    {
        TypeRepository repository =  new TypeRepository();
        public void Add(ItemType type)
        {
            repository.Add(type);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public ItemType Get(int id)
        {
            return repository.Get(id);
        }

        public List<ItemType> GetAll()
        {
            return repository.GetAll();
        }

        public void Update(int targetId, ItemType obj)
        {
            repository.Update(targetId, obj);
        }
    }
}