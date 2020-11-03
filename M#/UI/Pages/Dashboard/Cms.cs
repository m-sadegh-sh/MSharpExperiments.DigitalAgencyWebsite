using MSharp;

namespace Pages.Dashboard
{
    public class CmsPage : SubPage<DashboardPage>
    {
        public CmsPage()
        {
            Roles(AppRole.Admin);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        }
    }
}
