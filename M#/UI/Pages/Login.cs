using MSharp;

namespace Pages
{
    public class LoginPage : RootPage
    {
        public LoginPage()
        {
            Layout(Layouts.Login);

            Add<Modules.User.LoginForm>();
            Add<Modules.User.SocialMediaLoginForm>();

            MarkupTemplate("<div class=\"login-content\"><div class=\"card login\"><div class=\"card-body\">[#1#][#2#]</div></div></div>");
                OnStart(x =>
                {
                    x.If("Request.IsAjaxPost()").CSharp("return Redirect(Url.CurrentUri().OriginalString);");
                    x.If("User.Identity.IsAuthenticated").Go<Login.DispatchPage>().RunServerSide();
                    x.If("Url.ReturnUrl().IsEmpty()").Go("/login").RunServerSide()
                        .Send("ReturnUrl", ValueContext.Static, "/login");
                });
        }
    }
}