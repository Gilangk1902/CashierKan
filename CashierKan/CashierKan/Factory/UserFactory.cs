using CashierKan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierKan.Factory
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