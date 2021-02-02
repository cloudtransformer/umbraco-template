using Umbraco.Web;

namespace CloudTransformerTemplate.Core.Services.Implementations
{
    public class SitemapService : ISitemapService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SitemapService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string Get()
        {
            var url = _httpContextAccessor.HttpContext.Request.Url.AbsoluteUri
                .ToLower()
                .Replace("http://", "")
                .Replace("https://", "")
                .Replace("/sitemap.xml", "");

            return url;
        }
    }
}