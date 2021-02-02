using System.Collections.Generic;
using System.Linq;
using CloudTransformerTemplate.Core.DocumentTypes;
using Umbraco.Web;

namespace CloudTransformerTemplate.Core.Services.Implementations
{
    public class LanguagePageService : ILanguagePageService
    {
        private readonly ICountryPageService _countryPageService;
        private readonly IPublishedContentService _publishedContentService;

        public LanguagePageService(
            ICountryPageService countryPageService, 
            IPublishedContentService publishedContentService)
        {
            _countryPageService = countryPageService;
            _publishedContentService = publishedContentService;
        }

        public IEnumerable<LanguagePage> GetAll()
        {
            return _countryPageService.Get().Children<LanguagePage>().OrderBy(l => l.LanguageName).ToList();
        }

        public LanguagePage Get()
        {
            return _publishedContentService.Get().AncestorOrSelf<LanguagePage>();
        }
    }
}