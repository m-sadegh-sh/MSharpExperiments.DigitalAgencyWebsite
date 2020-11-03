using MSharp;

namespace Pages.Dashboard.Security
{
    public class AdministratorsPage : SubPage<DashboardPage>
    {
        public AdministratorsPage()
        {
            Add<Modules.Administrator.AdministratorsList>();
        }
    }
}