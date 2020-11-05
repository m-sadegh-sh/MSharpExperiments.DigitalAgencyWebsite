using MSharp;

namespace Modules.User
{
    public class ConfirmPasswordResetView : ViewModule<Domain.User>
    {
        public ConfirmPasswordResetView()
        {
            HeaderText("@item Details");

            Markup("@ContentBlock.PasswordSuccessfullyReset.Content");

            Link("Proceed to the login page.")
                .OnClick(x => x.Go<Pages.LoginPage>());
        }
    }
}