using MSharp;

namespace Modules.Menus
{
    public class AdminSettingsMenu : MenuModule
    {
        public AdminSettingsMenu()
        {
            SubItemBehaviour(MenuSubItemBehaviour.ExpandCollapse)
                .WrapInForm(false)
                .AjaxRedirect()
                .IsViewComponent()
                .RootCssClass("sidebar-menu")
                .UlCssClass("nav flex-column")
                .Using("Olive.Security");

            Item("General settings")
                .OnClick(x => x.Go<Pages.Dashboard.Configuration.GeneralSettingsPage>());

            Item("Administrators")
                .OnClick(x => x.Go<Pages.Dashboard.Security.AdministratorsPage>());

            Item("Content blocks")
                .OnClick(x => x.Go<Pages.Dashboard.Cms.ContentBlocksPage>());

            Item("Slides")
                .OnClick(x => x.Go<Pages.Dashboard.Cms.SlidesPage>());

            Item("Features")
                .OnClick(x => x.Go<Pages.Dashboard.Cms.FeaturesPage>());
        }
    }
}