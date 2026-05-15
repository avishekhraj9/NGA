using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace CustomerFeedbackPortal.TagHelpers
{
    [HtmlTargetElement("star-rating")]
    public class StarRatingTagHelper : TagHelper
    {
        public int MaxStars { get; set; } = 5;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            StringBuilder stars = new StringBuilder();

            for (int i = 1; i <= MaxStars; i++)
            {
                stars.Append($"<span style='font-size:30px;color:gold;'>★</span>");
            }

            output.Content.SetHtmlContent(stars.ToString());
        }
    }
}