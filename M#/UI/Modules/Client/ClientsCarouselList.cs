using MSharp;

namespace Modules.Client
{
    public class ClientsCarouselList : ListModule<Domain.Client>
    {
        public ClientsCarouselList()
        {
            IsViewComponent()
                .WrapInForm(false)
                .RenderMode(ListRenderMode.List);

            Markup(@"
                <div style='background-image: url(@item.Image);' class='image' title='@item.Name'></div>
            ");

            Footer(@"
                @if (Model.Items.Any()) {
                    <div class='paging-icons'>
                        <!--
                            <button class='prev'>
                                <i class='fa fa-arrow-left'></i>
                            </button>
                            <button class='next'>
                                <i class='fa fa-arrow-right'></i>
                            </button>
                        -->
                    </div>
                }
            ");

            LoadJavascriptModule("scripts/components/ClientsCarouselModule.js")
                .Event(UIModuleEvent.Load);
        }
    }
}
