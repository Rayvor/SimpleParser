using System.Collections.Generic;
using System.Linq;
using AngleSharp.Dom.Html;

namespace SimpleParser.Core.Site
{
    class SiteParser : IParser<List<string>>
    {
        public List<string> Parse(IHtmlDocument document, string selector, string content)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll(selector).Where(item => item.ClassName != null && item.ClassName.Contains(content));

            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }

            return list;
        }
    }
}
