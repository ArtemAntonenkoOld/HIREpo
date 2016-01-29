using System.Web;
using System.Web.Optimization;

namespace ISharpConvertor.WebUI
{
    public class BundleConfig
    {
        // Дополнительные сведения об объединении см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.js",
                        "~/Scripts/angular.js",
                        "~/Scripts/angular-resource.js",
                        "~/Scripts/BankApp.js",
                        "~/Scripts/BankController.js",
                        "~/Scripts/BankService.js", 
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                         "~/Scripts/chart.js"
                        //"~/Scripts/ConvertorApp.js"

                         /*"~/Scripts/Script.js",*/
                         //"~/Scripts/ya-map.js"


                        ));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // используйте средство построения на сайте http://modernizr.com, чтобы выбрать только нужные тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      
                      "~/Content/site.css","~/Content/chart.css"));
        }
    }
}
