using MSharp;

namespace Pages.Login
{
    public class DispatchPage : SubPage<LoginPage>
    {
        public DispatchPage()
        {
            OnStart(x =>
            {
                x.If(AppRole.Admin)
                 .Go<DashboardPage>()
                 .RunServerSide();

                x.GentleMessage("TODO: Add redirect logic here and then delete this activity!");
            });
        }
    }
}