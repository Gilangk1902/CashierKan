using CashierKan.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CashierKan.Views.ItemsView
{
    public partial class AddItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Button_Click(object sender, EventArgs e)
        {
            string name = name_TextBox.Text;
            string price = price_TextBox.Text;
            string type = types_DropDownList.Text;

            if(!ItemController.Validate(name, price, type))
            {
                name_Label.Text = name;
                price_Label.Text = price;
                types_Label.Text = type;
                ItemController.AddItem(name, type, price);
                Response.Redirect("~/Browse");
            }
            
        }
    }
}