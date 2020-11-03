using MSharp;

namespace Pages.Login
{
    public class ForgotPasswordPage : SubPage<LoginPage>
    {
        public ForgotPasswordPage()
        {
            Add<Modules.User.RequestUserPasswordResetTicketForm>();
        }
    }
}