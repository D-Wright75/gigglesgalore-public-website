using System.Web;
using System.Web.Optimization;

namespace GigglesGalore.Website.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/assets/js/calendar").Include(
                        "~/Scripts/calendar.js"));

            bundles.Add(new ScriptBundle("~/assets/js/device").Include(
                        "~/Scripts/device.min.js"));

            bundles.Add(new ScriptBundle("~/assets/js/fullcalendar").Include(
                        "~/Scripts/fullcalendar.min.js"));

            bundles.Add(new ScriptBundle("~/assets/js/gcal").Include(
                        "~/Scripts/gcal.js"));

            bundles.Add(new ScriptBundle("~/assets/js/gmap3").Include(
                        "~/Scripts/gmap3.min.js"));

            bundles.Add(new ScriptBundle("~/assets/js/hoverintent").Include(
                        "~/Scripts/hoverIntent.js"));

            bundles.Add(new ScriptBundle("~/assets/js/imagesloaded").Include(
                        "~/Scripts/imagesloaded.js"));

            bundles.Add(new ScriptBundle("~/assets/js/infinitescroll").Include(
                        "~/Scripts/infinitescroll.min.js"));

            bundles.Add(new ScriptBundle("~/assets/js/jquery").Include(
                        "~/Scripts/jquery.min.js"
                          ));

            bundles.Add(new ScriptBundle("~/assets/js/jquery-bundles").Include(
                         "~/Scripts/jquery-migrate.min.js",
                         "~/Scripts/jquery-ui.custom.min.js",
                         "~/Scripts/jquery.appear.js",
                         "~/Scripts/jquery.browser.min.js",
                         "~/Scripts/jquery.event.frame.min.js",
                          "~/Scripts/jquery.fitvids.js",
                          "~/Scripts/jquery.flexslider-min.js",
                          "~/Scripts/jquery.magnific-popup.min.js",
                          "~/Scripts/jquery.pagescroller.lite.js",
                          "~/Scripts/jquery.parallax.min.js",
                          "~/Scripts/jquery.placeholder.min.js",
                           "~/Scripts/jquery.spritely.js"
                          ));

            bundles.Add(new ScriptBundle("~/assets/js/less").Include(
                        "~/Scripts/less.min.js"));

            bundles.Add(new ScriptBundle("~/assets/js/main").Include(
                        "~/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/assets/js/masonry").Include(
                        "~/Scripts/masonry.min.js"));

            bundles.Add(new ScriptBundle("~/assets/js/modernizr").Include(
                        "~/Scripts/modernizr.custom.js"));

            bundles.Add(new ScriptBundle("~/assets/js/moment").Include(
                        "~/Scripts/moment.min.js"));

            bundles.Add(new ScriptBundle("~/assets/js/eventemitter").Include(
                        "~/Scripts/eventemitter.js"));

            bundles.Add(new ScriptBundle("~/assets/js/packery.pkgd").Include(
                        "~/Scripts/packery.pkgd.min.js"));

            bundles.Add(new ScriptBundle("~/assets/js/bootstrap").Include(
                      "~/Content/bootstrap/js/bootstrap.js",
                      "~/Content/Scripts/datepicker/bootstrap-datepicker.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap/bootstrap.css",
                      "~/Content/css/animate.css",
                      "~/Content/css/grass.css",
                      "~/Content/css/style.css"));
        }
    }
}
