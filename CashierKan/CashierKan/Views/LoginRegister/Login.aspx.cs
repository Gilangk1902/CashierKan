using CashierKan.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CashierKan.Views.LoginRegister
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Role"] != null)
                {
                    Response.Redirect("/Browse", false);
                }
                else if (Request.Cookies["UserCookie"] != null)
                {
                    EmailTxt.Text = Request.Cookies["UserCookie"]["Email"];
                    PasswordTxt.Attributes["value"] = Request.Cookies["UserCookie"]["Password"];
                }
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = EmailTxt.Text;
            string password = PasswordTxt.Text;
            bool rememberCheck = RememberCheckBox.Checked;

            string LoginUser = UserController.LoginUser(email, password, rememberCheck);
            if (LoginUser == null)
            {
                Response.Redirect("/Login");
            }
            else
            {
                ErrorLbl.Text = LoginUser;
                ErrorLbl.Visible = true;
            }
        }
    }
}