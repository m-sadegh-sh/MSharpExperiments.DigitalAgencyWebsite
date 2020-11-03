using MSharp;

namespace Modules.ContentBlock
{
    public class ContentBlocksList : ListModule<Domain.ContentBlock>
    {
        public ContentBlocksList()
        {
            ShowHeaderRow()
                .Sortable();

            /*M#:w[11]T-Prop:SortingStatement-Type:ListButton-Sorting statement is assumed to be this anyway. No need to hard-code.*//*M#:w[11]T-Prop:Name-Type:ListButton-Button name should not contain underline.*/LinkColumn(x => x.Key)
                .OnClick(x =>
                {
                    x.Go<Pages.Dashboard.Cms.ContentBlocks.EnterPage>()
                        .SendReturnUrl()
                        .Send("item", "item.ID");
                });

            Column(x => x.Content)
                .DisplayExpression(cs("item.Content.OrEmpty().RemoveHtmlTags().Summarize(80)"));

            Button("New Content Block")
                .Icon(FA.Plus)
                .OnClick(x => x.Go<Pages.Dashboard.Cms.ContentBlocks.EnterPage>().SendReturnUrl());
        }
    }
}
