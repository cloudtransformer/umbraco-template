using CloudTransformerTemplate.Core.Constants;
using CloudTransformerTemplate.Core.Wrappers;
using Umbraco.Web;

namespace CloudTransformerTemplate.Core.Services.Implementations
{
    public class ApplicationInsightsService : IApplicationInsightsService
    {
        private readonly IConfigurationManager _configurationManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationInsightsService(
            IConfigurationManager configurationManager, 
            IHttpContextAccessor httpContextAccessor)
        {
            _configurationManager = configurationManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetInstrumentationKey()
        {
            return _httpContextAccessor.HttpContext.IsDebuggingEnabled
                ? null
                : _configurationManager.AppSettings[AppSettings.ApplicationInsightsInstrumentationKey];
        }
    }
}