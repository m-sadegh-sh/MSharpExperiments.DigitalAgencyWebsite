using MSharp;

namespace Pages.Login.ResetPassword
{
    public class ConfirmPage : SubPage<ResetPasswordPage>
    {
        public ConfirmPage()
        {
            Add<Modules.User.ConfirmPasswordResetView>();
        }
    }
}