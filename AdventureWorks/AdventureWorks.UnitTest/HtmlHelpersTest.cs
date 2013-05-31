using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using AdventureWorks.WebUI.MVC.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventureWorks.WebUI.MVC.Infrastructure;

namespace AdventureWorks.UnitTest
{
    [TestClass]
    public class HtmlHelpersTest
    {
        [TestMethod]
        public void ShouldGeneratePageLinks()
        {
            var pageInfo = new PageInfo
                {
                    CurrentPage = 2,
                    ItemsPerPage = 10,
                    TotalItems = 28
                };

            MvcHtmlString result = HtmlHelpers.PaginationLinks(null, pageInfo, i => "Page" + i);

            string expected =
                @"<a href=""Page1"">1</a><a class=""selected"" href=""Page2"">2</a><a href=""Page3"">3</a>";

            Assert.AreEqual(expected, result.ToString());
        }
    }
}
