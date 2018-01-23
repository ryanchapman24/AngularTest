using System.Web;
using System.Web.Optimization;

namespace AngularTest
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/vendor/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/vendor/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/vendor/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //bundles.Add(new ScriptBundle("~/bundles/angular").Include("~/Scripts/vendor/angular.js",
            //    "~/Scripts/vendor/angular-*"));

            bundles.Add(new ScriptBundle("~/bundles/app")
                .IncludeDirectory("~/Scripts/app", "*.js", true));
        }
    }
}
