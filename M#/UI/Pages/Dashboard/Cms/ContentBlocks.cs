using MSharp;

namespace Pages.Dashboard.Cms
{
    public class ContentBlocksPage : SubPage<CmsPage>
    {
        public ContentBlocksPage()
        {
            Add<Modules.ContentBlock.ContentBlocksList>();
        }
    }
}