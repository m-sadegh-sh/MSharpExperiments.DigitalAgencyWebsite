using MSharp;

namespace Modules.Client
{
    public class ClientsCarouselList : ListModule<Domain.Client>
    {
        /*M#:w[6]T-Prop:Markup-Type:ListModule-Hardcoding in-line style is forbidden. Set a Css class instead.*/public ClientsCarouselList()
        {
            IsViewComponent();

            WrapInForm(false);

            RenderMode(ListRenderMode.List);

            LoadJavascriptModule("scripts/components/ClientsCarouselModule.js")
                .Event(UIModuleEvent.Load);

            Markup(@"
                <div style='background-image: url(@item.Image);' class='image' title='@item.Name'></div>
            ");
        }
    }
}
