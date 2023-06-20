using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CashierKan.Handler;
using CashierKan.Repository;

namespace CashierKan.Controllers
{
    public class UserController
    {
        public static List<string> CreateMember(string email, string password, string name, string address, string dob, int roleId)
        {
            List<string> messages = new List<string>();
            messages.Add("");
            messages.Add("");
            messages.Add("");
            if (IsUniqueEmail(email) != null || !email.Contains("@") || email.Contains("@.") || email.Contains(".@") || !email.Contains("."))
            {
                messages[0] = "Email must be unique and using a correct email format";
            }

            if (password.Length < 3 || password.Length > 20)
            {
                messages[1] = "Password minimal length is 3 characters and 20 characters is the maximal";
            }

            if (name.Length < 3 || name.Length > 20 || !IsAlphabet(name))
            {
                messages[2] = "Name minimal length is 3 characters and 20 characters is the maximal and must be letter";
            }

            if (messages[0] == "" && messages[1] == "" && messages[2] == "")
            {
                UserHandler.Register(email, password, name, address, dob, roleId);
                return null;
            }
            return messages;
        }

        public static bool IsAlphabet(string s)
        {
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] < 'a' || s[i] > 'z') && s[i] != ' ') return false;
            }
            return true;
        }

        public static string LoginUser(string email, string password, bool remember)
        {
            if (!email.Contains("@")
                || email.Contains("@.") || email.Contains(".@")
                || !email.Contains("."))
            {
                return "Email must using a correct email format";
            }

            if (password.Length < 3 || password.Length > 20)
            {
                return "Password must more than 3 characters and less than 20 characters";
            }

            var user = IsValidCredential(email, password);
            if (user == null)
            {
                return "Credential is not valid";
            }


            HttpContext.Current.Session["Role"] = (string) UserRepository.getUserRoleName(user);
            HttpContext.Current.Session["User"] = user;
            HttpContext.Current.Session["Name"] = user.Name;
            HttpContext.Current.Session["ID"] = user.Id;
            HttpContext.Current.Session["Email"] = email;
            if (remember)
            {
                HttpCookie userCookie = new HttpCookie("UserCookie");
                userCookie.Values.Add("Email", email);
                userCookie.Values.Add("Password", password);
                userCookie.Expires = DateTime.Now.AddHours(24);
                HttpContext.Current.Response.Cookies.Add(userCookie);
            }
            return null;
        }

        public static dynamic IsUniqueEmail(string email)
        {
            return UserHandler.IsUniqueEmail(email);
        }
        public static dynamic IsValidCredential(string email, string password)
        {
            return UserHandler.IsValidCredential(email, password);
        }
    }
}