using System;
using System.Globalization;
using System.Text;
using System.Web.Mvc;
using AdventureWorks.WebUI.MVC.Models;

namespace AdventureWorks.WebUI.MVC.Infrastructure
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString PaginationLinks(this HtmlHelper htmlHelper, PageInfo pageInfo,
                                                    Func<int, string> pageUrl)
        {
            var result = new StringBuilder();
            for (int i = 1; i <= pageInfo.TotalPages; i++)
            {
                var tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString(CultureInfo.InvariantCulture);
                if (i == pageInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                }
                result.Append(tag);
            }

            return MvcHtmlString.Create(result.ToString());
        }
    }
}