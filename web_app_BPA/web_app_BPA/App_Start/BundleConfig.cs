using System.Web;
using System.Web.Optimization;

namespace web_app_BPA
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/global.css"));

            bundles.Add(new ScriptBundle("~/Assets/Scripts/js").Include("~/Assets/Scripts/main.js"));
        }
    }
}
