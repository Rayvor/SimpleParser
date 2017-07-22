using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleParser.Core
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseUrl}/{settings.Prefix}/";
        }

        public async Task<string> GetSourceByPageId(int id)
        {
            var currentUrl = url.Replace("{CurrentId}", id.ToString());
            var responce = await client.GetAsync(currentUrl);
            string source = null;


            if (responce != null && responce.StatusCode == HttpStatusCode.OK)
            {
                source = await responce.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
    
}
