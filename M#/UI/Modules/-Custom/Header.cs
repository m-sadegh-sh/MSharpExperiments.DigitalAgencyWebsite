using MSharp;

namespace Modules.Custom
{
    public class Header : GenericModule
    {
        public Header()
        {
            IsInUse()
                .IsViewComponent()
                .WrapInForm(false)
                .Using("Olive.Security")
                .RootCssClass("header-wrapper");

            var logo = Link("Geeks")
                .CssClass("logo")
                .OnClick(x => x.Go<Pages.HomePage>());

            var burger = Link("Burger")
                .NoText()
                .Icon("fas")
                .CssClass("menu-toggler burger-icon")
                .ExtraTagAttributes("type=\"button\"");

            var login = Link("Login")
                .Icon(FA.UnlockAlt)
                .VisibleIf(AppRole.Anonymous)
                .OnClick(x => x.Go<Pages.LoginPage>());

            var backToLiveWebsite = Link("Live website")
                 .OnClick(x => x.Go<Pages.HomePage>());

            var logout = Link("Logout")
                .CssClass("align-bottom logout")
                .ValidateAntiForgeryToken(false)
                .VisibleIf(CommonCriterion.IsUserLoggedIn)
                .OnClick(x =>
                {
                    x.CSharp("await OAuth.Instance.LogOff();");
                    x.Go<Pages.LoginPage>();
                });

            Markup($@"
                <nav class=""navbar"">
                    <div class=""header-left-actions-wrapper"">
                        {burger.Ref}
                        {logo.Ref}
                    </div>
                    <div class=""header-account-wrapper"">
                        {backToLiveWebsite.Ref}
                        {logout.Ref}
                    </div>
                </nav>
            ");
        }
    }
}