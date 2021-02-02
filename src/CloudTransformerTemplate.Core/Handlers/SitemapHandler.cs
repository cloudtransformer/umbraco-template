using System.Web;
using CloudTransformerTemplate.Core.Services;
using Umbraco.Core.Composing;

namespace CloudTransformerTemplate.Core.Handlers
{
    public class SitemapHandler : IHttpHandler
    {
        private readonly ISitemapService _sitemapService;

        public SitemapHandler(ISitemapService sitemapService)
        {
            _sitemapService = sitemapService;
        }

        public SitemapHandler()
        {
            _sitemapService = Current.Factory.GetInstance(typeof(ISitemapService)) as ISitemapService;
        }

        public void ProcessRequest(HttpContext context)
        {
            var sitemap = _sitemapService.Get();

            if (string.IsNullOrWhiteSpace(sitemap))
            {
                context.Response.Clear();
                context.Response.StatusCode = 404;
                context.Response.End();
            }
            else
            {
                context.Response.Clear();
                context.Response.ContentType = "application/xml";
                context.Response.Write(sitemap);
            }
        }

        public bool IsReusable => false;
    }
}