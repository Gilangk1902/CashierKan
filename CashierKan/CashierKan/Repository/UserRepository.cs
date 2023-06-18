using CashierKan.Factory;
using CashierKan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashierKan.Repository
{
    public class UserRepository
    {
        public static CashierDatabaseEntities db = new CashierDatabaseEntities();

        public static dynamic IsUniqueEmail(string email)
        {
            var users = db.Users.Where(x => x.Email == email).FirstOrDefault();

            return users;
        }

        public static dynamic IsValidCredential(string email, string password)
        {
            var members = db.Users.Where(x => x.Email == email && x.Password == password).FirstOrDefault();

            return members;
        }
        public static void Register(string email, string password, string name, string address, string dob, int roleId)
        {
            db.Users.Add(UserFactory.CreateUser(name, email, password, address, dob, roleId));
            db.SaveChanges();
        }


        public static void deleteUser(int id)
        {
            db.Users.Remove(db.Users.Find(id));
            db.SaveChanges();
        }

        public User getUsers(int id)
        {
            return db.Users.Where(x => x.Id == id).FirstOrDefault();

        }
    }
}