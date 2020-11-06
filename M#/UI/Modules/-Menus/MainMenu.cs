using MSharp;

namespace Modules.Menus
{
    public class MainMenu : MenuModule
    {
        public MainMenu()
        {
            SubItemBehaviour(MenuSubItemBehaviour.ExpandCollapse)
                .AjaxRedirect()
                .WrapInForm(false)
                .Using("Olive.Security")
                .IsViewComponent()
                .UlCssClass("nav flex-column")
                .RootCssClass("sidebar-menu");

            Link("Open live website")
                 .OnClick(x => x.Go<Pages.HomePage>().Target(OpenIn.NewBrowserWindow));

            Link("Logout")
                 .CssClass("align-bottom logout")
                 .ValidateAntiForgeryToken(false)
                 .VisibleIf(CommonCriterion.IsUserLoggedIn)
                 .OnClick(x =>
                 {
                     x.CSharp("await OAuth.Instance.LogOff();");
                     x.Go<Pages.HomePage>();
                 });
        }
    }
}