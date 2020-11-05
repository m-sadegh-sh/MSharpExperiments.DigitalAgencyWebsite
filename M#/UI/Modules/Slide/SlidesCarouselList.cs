using MSharp;

namespace Modules.Slide
{
    public class SlidesCarouselList : ListModule<Domain.Slide>
    {
        
        /*M#:w[7]T-Prop:Markup-Type:ListModule-Do not use '<A>' directly in the code. Instead create a Button and reference it here using [#BUTTONS(ButtonName)#].*//*M#:w[7]T-Prop:Markup-Type:ListModule-Hardcoding in-line style is forbidden. Set a Css class instead.*/public SlidesCarouselList()
        {
            IsViewComponent();

            WrapInForm(false);

            SortingStatement("item.DisplayOrder");

            RenderMode(ListRenderMode.List);

            Footer(@"
                @if (Model.Items.Any()) {
                    <div class='paging-indicators'>
                        <ul>
                            @for (var page = 0; page < Model.Items.Count; page++) {
                                <li@(Html.Raw(page == 0 ? "" class='current'"" : """"))></li>
                            }
                        </ul>
                    </div>
                }
            ");

            LoadJavascriptModule("scripts/components/SlidesCarouselModule.js")
                .Event(UIModuleEvent.Load);

            Markup(@"
                <div style='background-image: url(@item.Image);' class='item-inner'>
                    <div class='overlay-container'>
                        <div class='content-wrapper'>
                            <div class='content'>
                                <h1>@item.Title</h1>
                                <p>@item.Description</p>
                            </div>
                            <a href='@item.LinkUrl' target='_blank' class='link'>
                                @item.LinkText
                            </a>
                        </div>
                    </div>
                </div>
            ");
        }
    }
}
