namespace CloudTransformerTemplate.Core.Services
{
    public interface IMetaService
    {
        /// <summary>
        /// Gets the current Meta Description.
        /// </summary>
        string GetDescription();

        /// <summary>
        /// Gets the current Meta Keywords.
        /// </summary>
        string GetKeywords();

        /// <summary>
        /// Gets the current Meta Robots No Follow.
        /// </summary>
        bool GetRobotsNoFollow();

        /// <summary>
        /// Gets the current Meta Robots No Index.
        /// </summary>
        bool GetRobotsNoIndex();

        /// <summary>
        /// Gets the current Meta Title.
        /// </summary>
        string GetTitle();
    }
}