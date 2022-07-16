using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using NorthernBrightHealth.EF.Contexts;
using NorthernBrightHealth.EF.Migrations;

namespace NorthernBrightHealth.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Ensure the database is updated to the latest migration
            //Database.SetInitializer<NorthernBrightHealthDbContext>(
            //    new CreateDatabaseIfNotExists<NorthernBrightHealthDbContext>());
            //Database.SetInitializer<NorthernBrightHealthDbContext>(
            //    new MigrateDatabaseToLatestVersion<NorthernBrightHealthDbContext, Configuration>());


            // Continue with standard WebAPI setup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
