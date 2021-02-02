using System.Web;
using Umbraco.Web;

namespace CloudTransformerTemplate.Core.Global
{
    public class GlobalApplication : UmbracoApplication
    {
        public override string GetVaryByCustomString(HttpContext context, string custom)
        {
            if (custom.ToLower().Equals("url"))
            {
                return "url=" + context.Request.Url.AbsoluteUri;
            }

            return base.GetVaryByCustomString(context, custom);
        }
    }
}