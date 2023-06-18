using CashierKan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierKan.Repository
{
    public class TypeRepository : IRepository<ItemType>
    {
        public void Add(ItemType item)
        {
            CashierKanDatabase.GetInstance().ItemTypes.Add(item);
        }

        public void Delete(int id)
        {
            CashierKanDatabase.GetInstance().ItemTypes.Remove(Get(id));
        }

        public ItemType Get(int id)
        {
            return CashierKanDatabase.GetInstance().ItemTypes.Find(id);
        }

        public List<ItemType> GetAll()
        {
            return CashierKanDatabase.GetInstance().ItemTypes.ToList();
        }

        public void Update(int targetId, ItemType item)
        {
            ItemType targetType = Get(targetId);
            targetType.Name = item.Name;
        }
    }
}