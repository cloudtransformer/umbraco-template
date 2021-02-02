namespace CloudTransformerTemplate.Core.Services
{
    public interface IApplicationInsightsService
    {
        /// <summary>
        /// Gets the shared Application Insights Instrumentation Key.
        /// </summary>
        string GetInstrumentationKey();
    }
}