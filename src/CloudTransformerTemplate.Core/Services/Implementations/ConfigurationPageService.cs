using CloudTransformerTemplate.Core.DocumentTypes;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace CloudTransformerTemplate.Core.Services.Implementations
{
    public class ConfigurationPageService : IConfigurationPageService
    {
        private readonly ICountryPageService _countryPageService;
        private readonly ILanguagePageService _languagePageService;
        private readonly IPublishedContentQuery _publishedContentQuery;

        public ConfigurationPageService(
            ICountryPageService countryPageService,
            ILanguagePageService languagePageService, 
            IPublishedContentQuery publishedContentQuery)
        {
            _countryPageService = countryPageService;
            _languagePageService = languagePageService;
            _publishedContentQuery = publishedContentQuery;
        }

        public ConfigurationAnalyticsPage GetAnalyticsPage()
        {
            return GetCurrentConfigPage(ConfigurationAnalyticsPage.ModelTypeAlias) as ConfigurationAnalyticsPage;
        }

        public ConfigurationSeoPage GetSeoPage()
        {
            return GetCurrentConfigPage(ConfigurationSeoPage.ModelTypeAlias) as ConfigurationSeoPage;
        }

        public ConfigurationSiteContentPage GetSiteContentPage()
        {
            return GetCurrentConfigPage(ConfigurationSiteContentPage.ModelTypeAlias) as ConfigurationSiteContentPage;
        }

        private IPublishedContent GetCurrentConfigPage(string docTypeAlias)
        {
            var currentLanguage = _languagePageService.Get();
            if (currentLanguage != null)
            {
                var languageSiteConfigPage =
                    _publishedContentQuery.ContentSingleAtXPath(
                        $"//*[@id={currentLanguage.Id}]//{docTypeAlias}");

                if (languageSiteConfigPage != null)
                {
                    return languageSiteConfigPage;
                }
            }

            var currentCountry = _countryPageService.Get();
            if (currentCountry == null)
            {
                return null;
            }

            var countrySiteConfigPage =
                _publishedContentQuery.ContentSingleAtXPath(
                    $"//*[@id={currentCountry.Id}]//{docTypeAlias}");

            return countrySiteConfigPage;
        }
    }
}