using MSharp;

namespace Pages.Dashboard
{
    public class ConfigurationPage : SubPage<DashboardPage>
    {
        public ConfigurationPage()
        {
            OnStart(x => x.Go<Configuration.GeneralSettingsPage>().RunServerSide());
        }
    }
}
