using System.Web;
using System.Web.Optimization;

namespace ArchitectureProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/paceLoader").Include(
                       "~/Assets/js/plugins/loaders/pace.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Assets/js/core/libraries/jquery.min.js"));
            
            
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Assets/js/core/libraries/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/themeScripts").Include(
                     "~/Assets/js/plugins/visualization/d3/d3.min.js",
                     "~/Assets/js/plugins/visualization/d3/d3_tooltip.js",
                     "~/Assets/js/plugins/forms/styling/switchery.min.js",
                     "~/Assets/js/plugins/forms/styling/uniform.min.js",
                     "~/Assets/js/plugins/forms/selects/bootstrap_multiselect.js",
                     "~/Assets/js/plugins/ui/moment/moment.min.js",
                     "~/Assets/js/plugins/pickers/daterangepicker.js",
                     "~/Assets/js/core/app.js",
                     "~/Assets/js/pages/dashboard.js",
                     "~/Assets/js/plugins/loaders/blockui.min.js"));
            
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Assets/style/icons/icomoon/styles.css",
                      "~/Assets/style/bootstrap.css",
                      "~/Assets/style/core.css",
                      "~/Assets/style/components.css",
                      "~/Assets/style/colors.css"));
        }
    }
}
