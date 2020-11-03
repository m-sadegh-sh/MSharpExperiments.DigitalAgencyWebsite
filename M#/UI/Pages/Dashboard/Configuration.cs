using MSharp;

namespace Pages.Dashboard
{
    public class ConfigurationPage : SubPage<DashboardPage>
    {
        public ConfigurationPage()
        {
            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            OnStart(x => x.Go<Configuration.GeneralSettingsPage>().RunServerSide());
        }
    }
}
