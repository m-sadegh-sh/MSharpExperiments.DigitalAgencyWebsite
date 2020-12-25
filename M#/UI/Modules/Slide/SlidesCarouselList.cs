using MSharp;

namespace Modules.Slide
{
    public class SlidesCarouselList : ListModule<Domain.Slide>
    {
        public SlidesCarouselList()
        {
            IsViewComponent()
                .WrapInForm(false)
                .SortingStatement("item.DisplayOrder")
                .RenderMode(ListRenderMode.List);

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
        }
    }
}
