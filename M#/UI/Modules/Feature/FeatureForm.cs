using MSharp;

namespace Modules.Feature
{
    public class FeatureForm : FormModule<Domain.Feature>
    {
        public FeatureForm()
        {
            Field(x => x.Title);

            Field(x => x.Description);

            Button("Cancel")
                .OnClick(x => x.ReturnToPreviousPage());

            Button("Save")
                .IsDefault()
                .Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.Go<Pages.Dashboard.Cms.FeaturesPage>();
                });
        }
    }
}