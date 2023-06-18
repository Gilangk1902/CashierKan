using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierKan.Repository
{
    public interface IRepository<T>
    {
        T Get(int id);
        List<T> GetAll();
        void Add(T item);
        void Update(int id ,T item);
        void Delete(int id);
    }
}