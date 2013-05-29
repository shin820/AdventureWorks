using System;
using System.Text;
using System.Web.Mvc;
using AdventureWorks.Service.ViewModel;

namespace AdventureWorks.WebUI.MVC.Infrastructure
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString PaginationLinks(this HtmlHelper htmlHelper, PageInfo pageInfo,
                                                    Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i < pageInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                if (i == pageInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                }
                result.Append(tag.ToString());
            }

            return MvcHtmlString.Create(result.ToString());
        }
    }
}