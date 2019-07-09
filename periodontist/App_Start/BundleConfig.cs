using System.Web;
using System.Web.Optimization;

namespace periodontist
{
    public class BundleConfig
    {
        // Дополнительные сведения об объединении см. на странице https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;


            bundles.Add(new ScriptBundle("~/bundles/periodontist").Include(
                     "~/Scripts/periodontist/main.js"
                     ));
            bundles.Add(new ScriptBundle("~/bundles/userquestion").Include(
                     "~/Scripts/periodontist/UserQuestion.js"
                     ));
            bundles.Add(new ScriptBundle("~/bundles/userslist").Include(
                     "~/Scripts/periodontist/UsersList.js"
                     ));

            bundles.Add(new ScriptBundle("~/bundles/userdata").Include(
                     "~/Scripts/periodontist/UserData.js"
                     ));

            bundles.Add(new ScriptBundle("~/bundles/roles").Include(
                     "~/Scripts/periodontist/Role.js"
                     ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // готово к выпуску, используйте средство сборки по адресу https://modernizr.com, чтобы выбрать только необходимые тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                     "~/Scripts/umd/popper.js"
                    ));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"
                     ));
            bundles.Add(new ScriptBundle("~/bundles/axios").Include(
                     "~/Scripts/axios.js"
                    ));
            bundles.Add(new ScriptBundle("~/bundles/vue").Include(
                     "~/Scripts/vue.js"
                    ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //bundles.Add(new StyleBundle("~/Content/admin").Include(
            //          "~/Content/admin/*.css"));
        }
    }
}
