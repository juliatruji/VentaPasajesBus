using System.Web;
using System.Web.Optimization;

namespace ViajesUTP
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/assets/js/jquery-3.2.1.min.js",
                        "~/Scripts/assets/styles/bootstrap4/popper.js",
                        "~/Scripts/assets/styles/bootstrap4/bootstrap.min.js",
                        "~/Scripts/assets/plugins/greensock/TweenMax.min.js",
                        "~/Scripts/assets/plugins/greensock/TimelineMax.min.js",
                        "~/Scripts/assets/plugins/scrollmagic/ScrollMagic.min.js",
                        "~/Scripts/assets/plugins/greensock/animation.gsap.min.js",
                        "~/Scripts/assets/plugins/greensock/ScrollToPlugin.min.js",
                        "~/Scripts/assets/plugins/easing/easing.js",
                        "~/Scripts/assets/plugins/parallax-js-master/parallax.min.js",
                        "~/Scripts/assets/js/about_custom.js",
                        "~/Scripts/assets/js/pago.js",
                        "~/Scripts/assets/js/bus.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/assets/styles/bootstrap4/bootstrap.min.css",
                      "~/Content/assets/plugins/font-awesome-4.7.0/css/font-awesome.min.css",
                      "~/Content/assets/plugins/OwlCarousel2 - 2.2.1/owl.carousel.css",
                      "~/Content/assets/plugins/OwlCarousel2-2.2.1/owl.theme.default.css",
                      "~/Content/assets/plugins/OwlCarousel2-2.2.1/animate.css",
                      "~/Content/assets/plugins/magnific-popup/magnific-popup.css",
                      "~/Content/assets/styles/main_styles.css",
                      "~/Content/assets/styles/bus.css",            
                      "~/Content/assets/styles/responsive.css"));

            bundles.Add(new StyleBundle("~/Content/site").Include(
                     "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/estilo").Include(
         "~/Content/assets/styles/pago.css"));
            // bundles.Add(new ScriptBundle("~/"))
        }
    }
}
