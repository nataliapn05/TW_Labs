using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace eUseControl.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.min").Include(
                      "~/Scripts/jquery.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-ui.min").Include(
                      "~/Scripts/jquery-ui.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.slimscroll.min").Include(
                      "~/Scripts/jquery.slimscroll.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap.min").Include(
                      "~/Scripts/jquery.bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/metisMenu.min").Include(
                      "~/Scripts/metisMenu.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/icheck.min").Include(
                      "~/Scripts/icheck.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/index").Include(
                     "~/Scripts/index.js"));
            bundles.Add(new ScriptBundle("~/bundles/homer").Include(
                     "~/Scripts/homer.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/font-awesome.css"));
            bundles.Add(new StyleBundle("~/Content/metisMenu").Include(
                     "~/Content/metisMenu.css"));
            bundles.Add(new StyleBundle("~/Content/animate").Include(
                     "~/Content/animate.css"));
            bundles.Add(new StyleBundle("~/Content/pe-icon-7-stroke").Include(
                     "~/Content/pe-icon-7-stroke.css"));
            bundles.Add(new StyleBundle("~/Content/helper").Include(
                     "~/Content/helper.css"));
            bundles.Add(new StyleBundle("~/Content/style").Include(
                     "~/Content/style.css"));

        }
    }
}