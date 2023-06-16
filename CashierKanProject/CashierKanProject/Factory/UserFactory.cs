using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CashierKanProject.Model;

namespace CashierKanProject.Factory
{
    public class UserFactory
    {
        public static User CreateUser(string name, string email, string password, string address, string dob, int roleId)
        {
            return new User
            {
                Name = name,
                Email = email,
                Password = password,
                Address = address,
                Dob = dob,
                RoleId = roleId
            };
        }
    }
}