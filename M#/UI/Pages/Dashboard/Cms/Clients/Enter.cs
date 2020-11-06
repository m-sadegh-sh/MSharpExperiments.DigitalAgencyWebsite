using MSharp;

namespace Pages.Dashboard.Cms.Clients
{
    public class EnterPage : SubPage<ClientsPage>
    {
        public EnterPage()
        {
            Add<Modules.Client.ClientForm>();
        }
    }
}
