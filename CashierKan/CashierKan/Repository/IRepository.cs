using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierKan.Repository
{
    public interface IRepository<T>
    {
        T Get(string id);
        List<T> GetAll();
        void Add(T item);
        void Update(string id ,T item);
        void Delete(string id);
    }
}