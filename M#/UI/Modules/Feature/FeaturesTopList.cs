using MSharp;

namespace Modules.Feature
{
    public class FeaturesTopList : ListModule<Domain.Feature>
    {
        public FeaturesTopList()
        {
            IsViewComponent();

            WrapInForm(false);

            RenderMode(ListRenderMode.List);

            Markup(@"
                <h1>@item.Title</h1>
                <p>@item.Description</p>
            ");
        }
    }
}
