using System.Collections.Specialized;

namespace CloudTransformerTemplate.Core.Wrappers
{
    public interface IConfigurationManager
    {
        NameValueCollection AppSettings { get; }
    }
}