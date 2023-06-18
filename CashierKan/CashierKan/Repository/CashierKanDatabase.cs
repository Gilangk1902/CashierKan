using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CashierKan.Models;

namespace CashierKan.Repository
{
    public class CashierKanDatabase
    {
        private static CashierDatabaseEntities db = new CashierDatabaseEntities();

        public static CashierDatabaseEntities GetInstance() { return db; }
    }
}