using MSharp;

namespace Modules.Settings
{
    public class GeneralSettingsForm : FormModule<Domain.GeneralSettings>
    {
        public GeneralSettingsForm()
        {
            HeaderText("General settings")
                .DataSource("Domain.GeneralSettings.Current");

            Field(x => x.PasswordResetTicketExpiryMinutes)
                .AsNumericUpDown();

            Button("Save")
                .IsDefault()
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Updated");
                });
        }
    }
}