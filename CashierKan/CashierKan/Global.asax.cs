using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CashierKan
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteFolder("~/Views");

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            // RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        static void MapPageRoute(string folder, string rootFolder)
        {
            // obtain sub-folders
            string[] folders = Directory.GetDirectories(folder);

            foreach (var subFolder in folders)
            {
                MapPageRoute(subFolder, rootFolder);
            }

            string[] files = Directory.GetFiles(folder);

            foreach (var file in files)
            {
                // not a page, skip action
                if (!file.EndsWith(".aspx"))
                    continue;

                string webPath = file.Replace(rootFolder, "~/").Replace("\\", "/");

                var filename = Path.GetFileNameWithoutExtension(file);

                if (filename.ToLower() == "default")
                {
                    continue;
                }

                RouteTable.Routes.MapPageRoute(filename, filename, webPath);
            }
        }

        public static void RouteFolder(string folder)
        {
            string rootFolder = HttpContext.Current.Server.MapPath("~/");

            if (folder.StartsWith("~/"))
            { }
            else if (folder.StartsWith("/"))
            {
                folder = "~" + folder;
            }
            else
            {
                folder = "~/" + folder;
            }

            folder = HttpContext.Current.Server.MapPath(folder);

            MapPageRoute(folder, rootFolder);
        }
    }
}
