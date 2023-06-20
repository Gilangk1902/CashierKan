using CashierKan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using CashierKan.Repository;

namespace CashierKan.Repository
{
    public class RoleRepository
    {
        private static CashierDatabaseEntities db = new CashierDatabaseEntities();

        public static string getRoleName(int roleId)
        {
            return db.Roles
                .Where(x => x.Id == roleId)
                .Select(x => x.Name).FirstOrDefault();
        }

        public static int getRolePermissionLevel(int roleId)
        {
            return roleId;
        }

        public static int getRolePermissionLevel(string roleName)
        {
            return db.Roles
                .Where(x => x.Name == roleName)
                .Select(x => x.Id).FirstOrDefault();
        }
    }
}