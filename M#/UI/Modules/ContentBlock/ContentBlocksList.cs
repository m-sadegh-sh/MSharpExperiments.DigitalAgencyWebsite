using MSharp;

namespace Modules.ContentBlock
{
    public class ContentBlocksList : ListModule<Domain.ContentBlock>
    {
        public ContentBlocksList()
        {
            ShowHeaderRow()
                .Sortable();

            LinkColumn(x => x.Key)
                .OnClick(x => x.Go<Pages.Dashboard.Cms.ContentBlocks.EnterPage>().Send("item", "item.ID"););

            Column(x => x.Content)
                .DisplayExpression(cs("item.Content.OrEmpty().RemoveHtmlTags().Summarize(80)"));

            Button("New Content Block")
                .Icon(FA.Plus)
                .OnClick(x => x.Go<Pages.Dashboard.Cms.ContentBlocks.EnterPage>());
        }
    }
}
