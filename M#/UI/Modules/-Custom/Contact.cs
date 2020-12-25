using MSharp;

namespace Modules.Custom
{
    public class Contact : GenericModule
    {
        public Contact()
        {
            IsInUse()
                .IsViewComponent()
                .WrapInForm(false)
                .RootCssClass("contact-wrapper");

            Markup($"@(await Component.InvokeAsync<ContentBlockView>(new ViewModel.ContentBlockView {{Key=\"{nameof(Domain.ContentBlock.HomeContact)}\"}}))");
        }
    }
}