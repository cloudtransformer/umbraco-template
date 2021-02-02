using System.Collections.Specialized;

namespace CloudTransformerTemplate.Core.Wrappers.Implementations
{
    public class ConfigurationManager : IConfigurationManager
    {
        public NameValueCollection AppSettings => System.Configuration.ConfigurationManager.AppSettings;
    }
}