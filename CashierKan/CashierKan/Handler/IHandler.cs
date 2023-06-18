using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierKan.Handler
{
    public interface IHandler<T>
    {
        T Get(int id);
        List<T> GetAll();
        void Add(T obj);
        void Delete(int id);
        void Update(int targetId, T obj);
    }
}