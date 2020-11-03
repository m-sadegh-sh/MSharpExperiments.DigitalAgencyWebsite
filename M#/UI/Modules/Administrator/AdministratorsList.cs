using MSharp;

namespace Modules.Administrator
{
    public class AdministratorsList : ListModule<Domain.Administrator>
    {
        public AdministratorsList()
        {
            ShowFooterRow()
                .ShowHeaderRow()
                .Sortable()
                .UseDatabasePaging(false)
                .HeaderText("Administrators")
                .PageSize(10);

            var search = SearchButton("Search")
                .Icon(FA.Search)
                .OnClick(x => x.Reload());

            Search(GeneralSearch.AllFields)
                .Label("Find:")
                .AfterInput(search.Ref);

            Column(x => x.Email);

            Column(x => x.IsDeactivated)
                .NeedsMerging()
                .DisplayExpression(cs("item.IsDeactivated"));

            ButtonColumn("Edit")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .Icon(FA.Edit)
                .OnClick(x => x.PopUp<Pages.Dashboard.Security.Administrators.EnterPage>().Send("item", "item.ID"));

            ButtonColumn("Delete")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Administrator?")
                .CssClass("btn-danger")
                .Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Reload();
                });

            Button("New Administrator")
                .Icon(FA.Plus)
                .OnClick(x => x.PopUp<Pages.Dashboard.Security.Administrators.EnterPage>());
        }
    }
}
