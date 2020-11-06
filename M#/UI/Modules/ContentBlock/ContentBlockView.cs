using MSharp;

namespace Modules.ContentBlock
{
    public class ContentBlockView : ViewModule<Domain.ContentBlock>
    {
        public ContentBlockView()
        {
            IsViewComponent()
                .DataSource("await ContentBlock.FindByKey(info.Key)")
                .Markup("@info.Output.Raw()")
                .WrapInForm(false);

            ViewModelProperty<string>("Key");

            ViewModelProperty<string>("Output")
                .Getter(@"if (Item == null) return ""No content found for key: '"" + Key + ""'"";
                             return Item.Content;");
        }
    }
}