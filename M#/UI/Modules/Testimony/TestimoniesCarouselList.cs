using MSharp;

namespace Modules.Testimony
{
    public class TestimoniesCarouselList : ListModule<Domain.Testimony>
    {
        public TestimoniesCarouselList()
        {
            IsViewComponent()
                .WrapInForm(false)
                .SortingStatement("item.DisplayOrder")
                .RenderMode(ListRenderMode.List);

            Markup(@"
                <div style='background-image: url(@item.Image);' title='@item.Name (@item.Position)' class='image'></div>
                <p>@item.Content</p>
                <div class='metadata'>
                    <h4>@item.Name</h4>
                    <h6>@item.Position</h6>
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

            LoadJavascriptModule("scripts/components/TestimoniesCarouselModule.js")
                .Event(UIModuleEvent.Load);
        }
    }
}
