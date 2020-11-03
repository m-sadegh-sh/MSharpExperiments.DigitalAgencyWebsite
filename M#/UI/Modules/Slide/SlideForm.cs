using MSharp;

namespace Modules.Slide
{
    public class SlideForm : FormModule<Domain.Slide>
    {
        public SlideForm()
        {
            Field(x => x.Title);

            Field(x => x.Description);

            Field(x => x.Image);

            Field(x => x.LinkUrl);

            Field(x => x.LinkText);

            Field(x => x.DisplayOrder);

            Button("Cancel")
                .OnClick(x => x.Go<Pages.Dashboard.Cms.SlidesPage>());

            Button("Save")
                .IsDefault()
                .Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.Go<Pages.Dashboard.Cms.SlidesPage>();
                });
        }
    }
}