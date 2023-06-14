using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Controller;
namespace PSDProject.Views
{
    public partial class TransactionDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int transactionid = int.Parse(Request.QueryString["Id"]);
                TableRepeater.DataSource = TransactionController.GetAllTransactionDetail(transactionid);
                TableRepeater.DataBind();
            }
        }
    }
}