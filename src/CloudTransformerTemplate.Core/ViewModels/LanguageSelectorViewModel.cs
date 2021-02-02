using System.Collections.Generic;
using CloudTransformerTemplate.Core.DocumentTypes;

namespace CloudTransformerTemplate.Core.ViewModels
{
    public class LanguageSelectorViewModel
    {
        public IEnumerable<LanguagePage> Languages { get; internal set; }
        public LanguagePage Current { get; internal set; }
    }
}