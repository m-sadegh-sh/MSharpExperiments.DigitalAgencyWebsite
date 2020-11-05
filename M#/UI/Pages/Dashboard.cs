using MSharp;

namespace Pages
{
    public class DashboardPage : RootPage
    {
        public DashboardPage()
        {
            Roles(AppRole.Admin);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            OnStart(x => x.Go<Pages.Dashboard.HomePage>().RunServerSide());
        }
    }
}
