using CashierKan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CashierKan.Views.UsersView
{
    public partial class ViewUsers : System.Web.UI.Page
    {
        CashierDatabaseEntities db = new CashierDatabaseEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<User> list = db.Users.ToList();
            usersGridView.DataSource = list;
            usersGridView.DataBind();
        }

        protected void userGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //bingung masih error
            int id = Convert.ToInt32(usersGridView.Rows[e.RowIndex].Cells[0]);

            db.Users.Remove(db.Users.Find(id));
            db.SaveChanges();

            usersGridView.DataSource = db.Users.ToList();
            usersGridView.DataBind();

        }

        protected void usersGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}