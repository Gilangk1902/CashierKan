using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CashierKan
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("Browse", "Browse", "~/Views/ItemsView/Browse.aspx");
            routes.MapPageRoute("AddItem", "AddItem", "~/Views/ItemsView/AddItem.aspx");
            routes.MapPageRoute("UpdateItem", "UpdateItem", "~/Views/ItemsView/UpdateItem.aspx");
        }
    }
}
