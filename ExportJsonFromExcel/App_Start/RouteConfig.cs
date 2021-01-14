using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExportJsonFromExcel
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Default Home Page",
              url: "",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
              namespaces: new[] { "ExportJsonFromExcel.Controllers" }
          );

          
            routes.MapRoute(
            "Yes24-linhduong-tool-export-json",
            "export-json",
            new { controller = "Home", action = "ExportJson", id = UrlParameter.Optional }, new[] { "ExportJsonFromExcel.Controllers" }
            );
            routes.MapRoute(
           "Yes24-linhduong-tool-export-json-2",
           "Home/SubmitSelectedColumn/{id}",
           new { controller = "Home", action = "SubmitSelectedColumn", id = UrlParameter.Optional }, new[] { "ExportJsonFromExcel.Controllers" }
           );
            routes.MapRoute(
           "Yes24-linhduong-tool-download-json",
           "export-json/download",
           new { controller = "Home", action = "DownloadJson", id = UrlParameter.Optional }, new[] { "ExportJsonFromExcel.Controllers" }
           );
            routes.MapRoute(
          "Yes24-linhduong-tool-export-product-code-to-one-line",
          "product-code-comma",
          new { controller = "Home", action = "ExportProductCode", id = UrlParameter.Optional }, new[] { "ExportJsonFromExcel.Controllers" }
          );
            routes.MapRoute(
             "Yes24-linhduong-tool-export-product-code-to-one-line-process",
             "Home/ProductCodeResult/{id}",
             new { controller = "Home", action = "ProductCodeResult", id = UrlParameter.Optional }, new[] { "ExportJsonFromExcel.Controllers" }
             );

            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
              namespaces: new[] { "ExportJsonFromExcel.Controllers" }
          );
        }
    }
}
