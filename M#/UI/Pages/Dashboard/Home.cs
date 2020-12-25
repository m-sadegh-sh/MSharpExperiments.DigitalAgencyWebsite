using MSharp;

namespace Pages.Dashboard
{
    public class HomePage : SubPage<DashboardPage>
    {
        public HomePage()
        {
            MarkupTemplate($"@(await Component.InvokeAsync<ContentBlockView>(new ViewModel.ContentBlockView {{Key=\"{nameof(Domain.ContentBlock.DashboardGreeting)}\"}}))");
        }
    }
}