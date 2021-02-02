using System.Collections.Generic;
using CloudTransformerTemplate.Core.DocumentTypes;

namespace CloudTransformerTemplate.Core.Services
{
    public interface ICountryPageService
    {
        /// <summary>
        /// Gets all Country Pages.
        /// </summary>
        IEnumerable<CountryPage> GetAll();

        /// <summary>
        /// Gets the current Country Page.
        /// </summary>
        CountryPage Get();
    }
}