using MSharp;

namespace Pages.Dashboard.Security.Administrators
{
    public class EnterPage : SubPage<AdministratorsPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.Administrator.AdministratorForm>();
        }
    }
}