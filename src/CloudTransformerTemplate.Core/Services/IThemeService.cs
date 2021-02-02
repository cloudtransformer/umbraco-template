using System.Collections.Generic;
using CloudTransformerTemplate.Core.Models;

namespace CloudTransformerTemplate.Core.Services
{
    public interface IThemeService
    {
        /// <summary>
        /// Gets all themes available to choose from.
        /// </summary>
        IEnumerable<Theme> GetAll();

        /// <summary>
        /// Gets the current Theme.
        /// </summary>
        string Get();
    }
}