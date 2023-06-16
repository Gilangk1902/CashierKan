using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CashierKanProject.Repository;

namespace CashierKanProject.Handler
{
    public class UserHandler
    {
        public static dynamic IsUniqueEmail(string email)
        {
            return UserRepository.IsUniqueEmail(email);
        }

        public static dynamic IsValidCredential(string email, string password)
        {
            return UserRepository.IsValidCredential(email, password);
        }
        public static void Register(string email, string password, string name, string address, string dob, int roleId)
        {
            UserRepository.Register(email, password, name, address, dob, roleId);
        }

    }
}