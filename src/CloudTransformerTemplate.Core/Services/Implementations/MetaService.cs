using CloudTransformerTemplate.Core.DocumentTypes;

namespace CloudTransformerTemplate.Core.Services.Implementations
{
    public class MetaService : IMetaService
    {
        private readonly IConfigurationPageService _configurationPageService;
        private readonly IHomePageService _homePageService;
        private readonly IPublishedContentService _publishedContentService;

        public MetaService(
            IConfigurationPageService configurationPageService, 
            IHomePageService homePageService, 
            IPublishedContentService publishedContentService)
        {
            _configurationPageService = configurationPageService;
            _homePageService = homePageService;
            _publishedContentService = publishedContentService;
        }

        public string GetDescription()
        {
            var currentPage = _publishedContentService.Get<ICompositionMetaPage>();

            if (!string.IsNullOrWhiteSpace(currentPage.MetaDescription))
            {
                return currentPage.MetaDescription;
            }

            var homePage = _homePageService.Get();

            return currentPage.Id == homePage.Id
                ? _configurationPageService.GetSiteContentPage().SiteDescription
                : null;
        }

        public string GetKeywords()
        {
            return _publishedContentService.Get<ICompositionMetaPage>().MetaKeywords;
        }

        public bool GetRobotsNoFollow()
        {
            return _publishedContentService.Get<ICompositionMetaPage>().RobotsNoFollow;
        }

        public bool GetRobotsNoIndex()
        {
            return _publishedContentService.Get<ICompositionMetaPage>().RobotsNoIndex;
        }

        public string GetTitle()
        {
            var configPage = _configurationPageService.GetSiteContentPage();
            var homePage = _homePageService.Get();

            var currentPage = _publishedContentService.Get<ICompositionMetaPage>();

            string retval;

            if (currentPage.Id == homePage.Id)
            {
                retval = string.IsNullOrWhiteSpace(currentPage.MetaTitle)
                    ? $"{configPage.SiteTitle}"
                    : $"{configPage.SiteTitle} - {currentPage.MetaTitle}";
            }
            else
            {
                retval = string.IsNullOrWhiteSpace(currentPage.MetaTitle)
                    ? $"{currentPage.Name} - {configPage.SiteTitle}"
                    : $"{currentPage.MetaTitle} - {configPage.SiteTitle}";
            }

            return retval;
        }
    }
}