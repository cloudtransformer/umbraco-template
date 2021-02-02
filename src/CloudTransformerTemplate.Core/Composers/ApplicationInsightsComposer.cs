using System.Configuration;
using System.Web.Mvc;
using CloudTransformerTemplate.Core.Attributes;
using CloudTransformerTemplate.Core.Constants;
using Microsoft.ApplicationInsights.Extensibility;
using Umbraco.Core.Composing;

namespace CloudTransformerTemplate.Core.Composers
{
    public class ApplicationInsightsComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            if (ConfigurationManager.AppSettings[AppSettings.ApplicationInsightsInstrumentationKey] == null)
            {
                return;
            }

            GlobalFilters.Filters.Add(new ApplicationInsightsHandleErrorAttribute());

            TelemetryConfiguration.Active.InstrumentationKey =
                ConfigurationManager.AppSettings[AppSettings.ApplicationInsightsInstrumentationKey];
        }
    }
}