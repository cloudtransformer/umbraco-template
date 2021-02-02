using CloudTransformerTemplate.Core.DocumentTypes;

namespace CloudTransformerTemplate.Core.Services
{
    public interface IHomePageService
    {
        /// <summary>
        /// Gets the current Home Page.
        /// </summary>
        HomePage Get();
    }
}