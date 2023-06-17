using CashierKan.Controllers;
using CashierKan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CashierKan.Views.ItemsView
{
    public partial class UpdateItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData(RequestID());
            }
        }

        protected void update_Button_Click(object sender, EventArgs e)
        {
            string price = price_TextBox.Text;
            string name = name_TextBox.Text;
            string type = types_DropDownList.Text;
            if(ItemController.Validate(name, type, price))
            {
                ItemController.Update(RequestID(), name, type, price);
                Response.Redirect("/Browse");
            }
        }

        private string RequestID()
        {
            if (Request.QueryString["id"] != null)
            {
                return Request.QueryString["id"];
            }
            else
            {
                return string.Empty;
            }
        }

        private void LoadData(string id)
        {
            Item item = ItemController.Get(id);
            name_TextBox.Text = item.name;
            types_DropDownList.Text = item.type;
            price_TextBox.Text = item.price;
        }
    }
}