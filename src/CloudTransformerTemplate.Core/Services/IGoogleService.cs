namespace CloudTransformerTemplate.Core.Services
{
    public interface IGoogleService
    {
        /// <summary>
        /// Gets the current Google Analytics Code.
        /// </summary>
        string GetAnalyticsCode();

        /// <summary>
        /// Gets the current Google Site Verification Code
        /// </summary>
        string GetSiteVerificationCode();
    }
}