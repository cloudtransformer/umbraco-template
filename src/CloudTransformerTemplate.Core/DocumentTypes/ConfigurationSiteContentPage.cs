using Umbraco.ModelsBuilder;
using Umbraco.Web;

namespace CloudTransformerTemplate.Core.DocumentTypes
{
    [IgnorePropertyType("siteTheme")]
    public partial class ConfigurationSiteContentPage
    {
        /// <summary>
        /// Site Theme: Select a theme that the current site will use to display.
        /// </summary>
        public string SiteTheme => this.Value<string>("siteTheme");
    }
}