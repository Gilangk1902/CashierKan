using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierKan.Handler
{
    public interface IHandler<T>
    {
        T Get(string id);
        List<T> GetAll();
        void Add(T obj);
        void Delete(string id);
        void Update(string targetId, T obj);
    }
}