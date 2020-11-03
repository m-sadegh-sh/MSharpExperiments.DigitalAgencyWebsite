using MSharp;

namespace Pages.Dashboard.Configuration
{
    public class GeneralSettingsPage : SubPage<ConfigurationPage>
    {
        public GeneralSettingsPage()
        {
            Add<Modules.Settings.GeneralSettingsForm>();
        }
    }
}