using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Controller;
namespace PSDProject.Views
{
    public partial class Transaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int userid = (int)Session["ID"];

            TableRepeater.DataSource = TransactionController.GetAllTransaction(userid);
            TableRepeater.DataBind();
        }

        protected void OpenDetail_Click(object sender, EventArgs e)
        {
            LinkButton linkbtn = (LinkButton)sender;
            string id = linkbtn.CommandArgument;
            Response.Redirect("~/Views/TransactionDetail.aspx?id=" + id);
        }
    }
}