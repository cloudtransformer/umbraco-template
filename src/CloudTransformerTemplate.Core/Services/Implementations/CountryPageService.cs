using System.Collections.Generic;
using System.Linq;
using CloudTransformerTemplate.Core.DocumentTypes;
using Umbraco.Web;

namespace CloudTransformerTemplate.Core.Services.Implementations
{
    public class CountryPageService : ICountryPageService
    {
        private readonly IPublishedContentService _publishedContentService;
        private readonly IPublishedContentQuery _publishedContentQuery;

        public CountryPageService(
            IPublishedContentService publishedContentService, 
            IPublishedContentQuery publishedContentQuery)
        {
            _publishedContentService = publishedContentService;
            _publishedContentQuery = publishedContentQuery;
        }

        public IEnumerable<CountryPage> GetAll()
        {
            return _publishedContentQuery
                .ContentAtXPath($"/root/{CountryPage.ModelTypeAlias}")
                .Select(c => c as CountryPage)
                .Where(c => c != null)
                .OrderBy(c => c.CountryName)
                .ToList();
        }

        public CountryPage Get()
        {
            return _publishedContentService.Get().AncestorOrSelf<CountryPage>();
        }
    }
}