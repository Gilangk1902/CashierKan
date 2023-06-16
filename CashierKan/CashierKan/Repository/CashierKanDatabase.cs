using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CashierKan.Models;

namespace CashierKan.Repository
{
    public class CashierKanDatabase
    {
        private static CashierkanDatabaseEntities db = new CashierkanDatabaseEntities();

        public static CashierkanDatabaseEntities GetInstance() { return db; }
    }
}