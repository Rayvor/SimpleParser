using AngleSharp.Dom.Html;

namespace SimpleParser.Core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document, string selector, string content);
    }
}
