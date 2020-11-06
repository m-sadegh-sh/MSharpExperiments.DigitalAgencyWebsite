using MSharp;

namespace Modules.Client
{
    public class ClientForm : FormModule<Domain.Client>
    {
        public ClientForm()
        {
            Field(x => x.Name);

            Field(x => x.Image);

            Button("Cancel")
                .OnClick(x => x.Go<Pages.Dashboard.Cms.ClientsPage>());

            Button("Save")
                .IsDefault()
                .Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.Go<Pages.Dashboard.Cms.ClientsPage>();
                });
        }
    }
}