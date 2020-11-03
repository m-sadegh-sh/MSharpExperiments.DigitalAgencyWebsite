using MSharp;

namespace Modules.Administrator
{
    public class AdministratorForm : FormModule<Domain.Administrator>
    {
        public AdministratorForm()
        {
            Field(x => x.FirstName);

            Field(x => x.LastName);

            Field(x => x.Email);

            Field(x => x.IsDeactivated)
                .AsRadioButtons(Arrange.Vertical);

            Button("Cancel")
                .OnClick(x => x.CloseModal());

            Button("Save")
                .IsDefault()
                .Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.CloseModal(Refresh.Full);
                });
        }
    }
}