using MSharp;

namespace Modules.Menus
{
    public class MainNav : MenuModule
    {
        public MainNav()
        {
            WrapInForm(false)
                .IsViewComponent();

            Item("Home")
                .LinkCssClass("mark")
                .OnClick(x => x.Go("#SlideLst"));

            Item("Features")
                .OnClick(x => x.Go("#FeatureLst"));

            Item("About")
                .OnClick(x => x.Go("#About"));

            Item("Clients")
                .OnClick(x => x.Go("#ClientLst"));

            Item("Contact")
                .OnClick(x => x.Go("#Contact"));

            Item("Login")
                .VisibleIf(CommonCriterion.IsUserGuest_notLogged_in)
                .OnClick(x => x.Go<Pages.LoginPage>());

            Item("Dashboard")
                .VisibleIf(CommonCriterion.IsUserLoggedIn)
                .OnClick(x => x.Go<Pages.DashboardPage>());
        }
    }
}