using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace CloudTransformerTemplate.Core.Services.Implementations
{
    public class PublishedContentService : IPublishedContentService
    {
        private readonly IUmbracoContextAccessor _umbracoContextAccessor;

        public PublishedContentService(IUmbracoContextAccessor umbracoContextAccessor)
        {
            _umbracoContextAccessor = umbracoContextAccessor;
        }

        public IPublishedContent Get()
        {
            return _umbracoContextAccessor.UmbracoContext.PublishedRequest.PublishedContent;
        }

        public T Get<T>() where T : class
        {
            return Get() as T;
        }
    }
}