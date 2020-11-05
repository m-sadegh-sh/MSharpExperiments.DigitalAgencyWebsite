using MSharp;

namespace Modules.Feature
{
    public class FeaturesTopList : ListModule<Domain.Feature>
    {
        /*M#:w[7]T-Prop:Markup-Type:ListModule-Do not use '<A>' directly in the code. Instead create a Button and reference it here using [#BUTTONS(ButtonName)#].*//*M#:w[7]T-Prop:Markup-Type:ListModule-Hardcoding in-line style is forbidden. Set a Css class instead.*/
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
