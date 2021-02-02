using CloudTransformerTemplate.Core.DocumentTypes;
using Umbraco.Web;

namespace CloudTransformerTemplate.Core.Services.Implementations
{
    public class HomePageService : IHomePageService
    {
        private readonly IPublishedContentQuery _publishedContentQuery;
        private readonly IPublishedContentService _publishedContentService;

        public HomePageService(
            IPublishedContentQuery publishedContentQuery, 
            IPublishedContentService publishedContentService)
        {
            _publishedContentQuery = publishedContentQuery;
            _publishedContentService = publishedContentService;
        }

        public HomePage Get()
        {
            var currentPage = _publishedContentService.Get();
            if (currentPage == null)
            {
                return null;
            }

            var retval = currentPage.AncestorOrSelf<HomePage>();
            if (retval != null)
            {
                return retval;
            }

            return _publishedContentQuery.ContentSingleAtXPath($"//*[@id={currentPage.Id}]//{HomePage.ModelTypeAlias}") as HomePage;
        }
    }
}