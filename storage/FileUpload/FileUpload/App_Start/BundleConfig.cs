﻿using System.Web.Optimization;

namespace FileUpload
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region JS
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/jquery.dataTables.min.js",
                      "~/Scripts/dataTables.bootstrap4.min.js"));
            #endregion

            #region CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                          "~/Content/bootstrap.css",
                          "~/Content/site.css",
                          "~/Content/Custom.css",
                          "~/Content/dataTables.bootstrap.min.css",
                          "~/Content/responsive.bootstrap.min.css")); 
            #endregion
        }
    }
}