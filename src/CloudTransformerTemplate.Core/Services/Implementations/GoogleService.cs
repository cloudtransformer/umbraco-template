using Umbraco.Web;

namespace CloudTransformerTemplate.Core.Services.Implementations
{
    public class GoogleService : IGoogleService
    {
        private readonly IConfigurationPageService _configurationPageService;
        private readonly IHomePageService _homePageService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IPublishedContentService _publishedContentService;

        public GoogleService(
            IConfigurationPageService configurationPageService, 
            IHomePageService homePageService, 
            IHttpContextAccessor httpContextAccessor, 
            IPublishedContentService publishedContentService)
        {
            _configurationPageService = configurationPageService;
            _homePageService = homePageService;
            _httpContextAccessor = httpContextAccessor;
            _publishedContentService = publishedContentService;
        }

        public string GetAnalyticsCode()
        {
            return _httpContextAccessor.HttpContext.IsDebuggingEnabled
                ? null
                : _configurationPageService.GetAnalyticsPage().GoogleAnalytics;
        }

        public string GetSiteVerificationCode()
        {
            if (_httpContextAccessor.HttpContext.IsDebuggingEnabled)
            {
                return null;
            }

            var homePage = _homePageService.Get();
            var currentPage = _publishedContentService.Get();

            return currentPage?.Id == homePage?.Id
                ? _configurationPageService.GetSeoPage().GoogleSiteVerification
                : null;
        }
    }
}