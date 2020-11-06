using MSharp;

namespace Pages.Dashboard.Cms
{
    public class ClientsPage : SubPage<CmsPage>
    {
        public ClientsPage()
        {
            Add<Modules.Client.ClientsList>();
        }
    }
}