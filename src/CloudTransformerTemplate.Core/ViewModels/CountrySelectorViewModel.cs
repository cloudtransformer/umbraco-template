using System.Collections.Generic;
using CloudTransformerTemplate.Core.DocumentTypes;

namespace CloudTransformerTemplate.Core.ViewModels
{
    public class CountrySelectorViewModel
    {
        public IEnumerable<CountryPage> Countries { get; internal set; }
        public CountryPage Current { get; internal set; }
    }
}