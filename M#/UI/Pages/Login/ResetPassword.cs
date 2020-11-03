using MSharp;

namespace Pages.Login
{
    public class ResetPasswordPage : SubPage<LoginPage>
    {
        public ResetPasswordPage()
        {
            Route("password/reset/{ticket}");

            Add<Modules.User.ResetUserPasswordForm>();
        }
    }
}