using System.Web.Optimization;

namespace Topping.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region CSS

            bundles.Add(new StyleBundle("~/Content/global/plugins/styles").Include(
                      "~/Content/global/plugins/font-awesome/css/font-awesome.min.css",
                      "~/Content/global/plugins/simple-line-icons/simple-line-icons.min.css",
                      "~/Content/global/plugins/bootstrap/css/bootstrap.min.css",
                      "~/Content/global/plugins/uniform/css/uniform.default.css",
                      "~/Content/global/plugins/jqvmap/jqvmap/jqvmap.css",
                      "~/Content/global/plugins/morris/morris.css",
                      "~/Content/global/css/components-rounded.css",
                      "~/Content/global/css/plugins.css"
                      ));


            bundles.Add(new StyleBundle("~/Content/admin/layout/styles").Include(
                   "~/Content/admin/pages/css/tasks.css",
                    "~/Content/admin/layout3/css/layout.css",
                    "~/Content/admin/layout3/css/themes/default.css",
                    "~/Content/admin/layout3/css/custom.css"
                    ));

            #endregion

            #region JS

            bundles.Add(new ScriptBundle("~/Content/global/plugins/scripts").Include(
                    "~/Content/global/plugins/jquery.min.js",
                    "~/Content/global/plugins/jquery-migrate.min.js",
                    "~/Content/global/plugins/jquery-ui/jquery-ui.min.js",
                    "~/Content/global/plugins/bootstrap/js/bootstrap.min.js",
                    "~/Content/global/plugins/bootstrap-hover-dropdown/bootstrap-hover-dropdown.min.js",
                    "~/Content/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                    "~/Content/global/plugins/jquery.blockui.min.js",
                    "~/Content/global/plugins/jquery.cokie.min.js",
                    "~/Content/global/plugins/uniform/jquery.uniform.min.js",
                    "~/Content/global/plugins/jqvmap/jqvmap/jquery.vmap.js",
                    "~/Content/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.russia.js",
                    "~/Content/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.world.js",
                    "~/Content/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.europe.js",
                    "~/Content/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.germany.js",
                    "~/Content/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.usa.js",
                    "~/Content/global/plugins/jqvmap/jqvmap/data/jquery.vmap.sampledata.js",
                    "~/Content/global/plugins/morris/morris.min.js",
                    "~/Content/global/plugins/morris/raphael-min.js",
                    "~/Content/global/plugins/jquery.sparkline.min.js",
                    "~/Content/global/scripts/metronic.js"
                    ));


            bundles.Add(new ScriptBundle("~/Content/admin/layout/scripts").Include(
                    "~/Content/admin/layout3/scripts/layout.js",
                    "~/Content/admin/layout2/scripts/quick-sidebar.js",
                    "~/Content/admin/layout3/scripts/demo.js",
                    "~/Content/admin/pages/scripts/index3.js",
                    "~/Content/admin/pages/scripts/tasks.js"
                    ));

            #endregion
        }
    }
}
