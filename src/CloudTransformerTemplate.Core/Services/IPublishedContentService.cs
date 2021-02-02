using Umbraco.Core.Models.PublishedContent;

namespace CloudTransformerTemplate.Core.Services
{
    public interface IPublishedContentService
    {
        /// <summary>
        /// Gets the current Published Content.
        /// </summary>
        IPublishedContent Get();

        /// <summary>
        /// Gets the current Published Content as type.
        /// </summary>
        T Get<T>() where T : class;
    }
}