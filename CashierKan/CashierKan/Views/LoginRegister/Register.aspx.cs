using CashierKan.Controllers;
using CashierKan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CashierKan.Views.LoginRegister
{
    public partial class Register : System.Web.UI.Page
    {
        CashierDatabaseEntities db = new CashierDatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                List<String> roletype = (from Role in db.Roles select Role.Name).ToList();

                RoleList.DataSource = roletype;
                RoleList.DataBind();
            }
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string email = EmailTxt.Text;
            string password = PasswordTxt.Text;
            string username = UsernameTxt.Text;
            string address = AddressTxt.Text;
            string dob = DobTxt.Text;
            int roleId = (from Role in db.Roles where Role.Name == RoleList.Text select Role.Id).ToList().FirstOrDefault();

            List<string> msgs = UserController.CreateMember(email, password, username, address, dob, roleId);
            if (msgs != null)
            {
                if (msgs[0] != "")
                {
                    EmailLbl.Visible = true;
                    EmailLbl.Text = msgs[0];
                }
                if (msgs[1] != "")
                {
                    PasswordLbl.Visible = true;
                    PasswordLbl.Text = msgs[1];
                }
                if (msgs[2] != "")
                {
                    UsernameLbl.Visible = true;
                    UsernameLbl.Text = msgs[2];
                }
            }
            else
            {
                Response.Redirect("/Login");
            }
        }

        protected void RoleList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}