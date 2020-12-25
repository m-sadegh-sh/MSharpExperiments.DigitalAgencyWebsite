using MSharp;

namespace Modules.Testimony
{
    public class TestimonyForm : FormModule<Domain.Testimony>
    {
        public TestimonyForm()
        {
            Field(x => x.Name);

            Field(x => x.Position);

            Field(x => x.Content);

            Field(x => x.Image);

            Field(x => x.DisplayOrder);

            Button("Cancel")
                .OnClick(x => x.Go<Pages.Dashboard.Cms.TestimoniesPage>());

            Button("Save")
                .IsDefault()
                .Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.Go<Pages.Dashboard.Cms.TestimoniesPage>();
                });
        }
    }
}