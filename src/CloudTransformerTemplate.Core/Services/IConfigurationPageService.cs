using CloudTransformerTemplate.Core.DocumentTypes;

namespace CloudTransformerTemplate.Core.Services
{
    public interface IConfigurationPageService
    {
        /// <summary>
        /// Gets the current Configuration Analytics Page.
        /// </summary>
        ConfigurationAnalyticsPage GetAnalyticsPage();

        /// <summary>
        /// Gets the current Configuration SEO Page.
        /// </summary>
        ConfigurationSeoPage GetSeoPage();

        /// <summary>
        /// Gets the current Configuration Site Content Page.
        /// </summary>
        ConfigurationSiteContentPage GetSiteContentPage();
    }
}