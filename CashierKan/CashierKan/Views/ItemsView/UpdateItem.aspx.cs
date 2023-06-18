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
            string type_name = types_DropDownList.Text;

            if(ItemController.Validate(name, type_name, price))
            {
                int type = TypeController.GetId(type_name);
                ItemController.Update(RequestID(), name, type, Convert.ToInt32(price));
                Response.Redirect("/Browse");
            }
        }

        private int RequestID()
        {
            if (Request.QueryString["id"] != null)
            {
                return int.Parse(Request.QueryString["id"]);
            }
            else
            {
                return int.MinValue;
            }
        }

        private void LoadData(int id)
        {
            Item item = ItemController.Get(id);
            name_TextBox.Text = item.Name;
            types_DropDownList.Text = item.Type.ToString();
            price_TextBox.Text = item.Price.ToString();
        }
    }
}