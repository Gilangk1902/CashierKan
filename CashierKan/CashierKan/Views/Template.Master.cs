using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CashierKan.Repository;

namespace CashierKan.Views
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterContainer.Visible = false;
            LoginContainer.Visible = false;
            LogoutLink.Visible = false;
            ManagePanel.Visible = false;
            AddItemContainer.Visible = false;
            ViewItemsLink.Visible = false;
            ViewUsersLink.Visible = false;

            var rawr = HttpContext.Current.Session;
            if (rawr["Role"] == null)
            {
                LoginContainer.Visible = true;
                RegisterContainer.Visible = true;
                return;
            }
            LogoutBtn.Visible = true;

            string getRole = (string) rawr["Role"];
            //System.Diagnostics.Debug.WriteLine(getRole);

            ManagePanel.Visible = getRole == "Admin" || getRole == "Cashier";
            ViewUsersLink.Visible = getRole == "Admin";
            //ViewItemsLink.Visible = ManagePanel.Visible;
            AddItemContainer.Visible = ManagePanel.Visible;
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["UserCookie"] != null)
            {
                HttpCookie userCookie = new HttpCookie("UserCookie");
                Request.Cookies["UserCookie"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(userCookie);
            }
            Session.Abandon();
            Response.Redirect("~/Login");
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Register");
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login");
        }

        protected void AddItemBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/AddItem");
        }

        protected void BrowseItems_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Browse");
        }
    }
}