using MSharp;

namespace Modules.Custom
{
    public class About : GenericModule
    {
        public About()
        {
            IsInUse()
                .IsViewComponent()
                .WrapInForm(false)
                .RootCssClass("about-wrapper");

            Markup($"@(await Component.InvokeAsync<ContentBlockView>(new ViewModel.ContentBlockView {{Key=\"{nameof(Domain.ContentBlock.HomeAbout)}\"}}))");
        }
    }
}