namespace SimpleParser.Core.Site
{
    class SiteSettings : IParserSettings
    {
        public SiteSettings(int start, int end, string baseUrl, string prefix)
        {
            StartPoint = start;
            EndPoint = end;
            BaseUrl = baseUrl;
            Prefix = prefix;
        }

        public string BaseUrl { get; set; }

        public string Prefix { get; set; }

        public int StartPoint { get; set; }

        public int EndPoint { get; set; }
    }
}
