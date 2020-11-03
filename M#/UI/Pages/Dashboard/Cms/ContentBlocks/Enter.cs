using MSharp;

namespace Pages.Dashboard.Cms.ContentBlocks
{
    public class EnterPage : SubPage<ContentBlocksPage>
    {
        public EnterPage()
        {
            Add<Modules.ContentBlock.ContentBlockForm>();
        }
    }
}