using MSharp;

namespace Pages
{
    public class DashboardPage : RootPage
    {
        public DashboardPage()
        {
            Roles(AppRole.Admin);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            /*M#:w[12]T-Prop:Page-Type:NavigateActivity-This page has no content or start-up action, and so it doesn't exist as a valid target.*/OnStart(x => x.Go<Pages.Dashboard.HomePage>().RunServerSide());
        }
    }
}
