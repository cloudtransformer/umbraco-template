using System.Collections.Generic;
using CloudTransformerTemplate.Core.DocumentTypes;

namespace CloudTransformerTemplate.Core.Services
{
    public interface ILanguagePageService
    {
        /// <summary>
        /// Gets all Language Pages.
        /// </summary>
        IEnumerable<LanguagePage> GetAll();

        /// <summary>
        /// Gets the current Language Page.
        /// </summary>
        LanguagePage Get();
    }
}