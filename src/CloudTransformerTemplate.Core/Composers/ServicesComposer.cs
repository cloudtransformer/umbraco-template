using System.IO.Abstractions;
using CloudTransformerTemplate.Core.Services;
using CloudTransformerTemplate.Core.Services.Implementations;
using CloudTransformerTemplate.Core.Wrappers;
using CloudTransformerTemplate.Core.Wrappers.Implementations;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace CloudTransformerTemplate.Core.Composers
{
    public class ServicesComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<IApplicationInsightsService, ApplicationInsightsService>(Lifetime.Singleton);
            composition.Register<IConfigurationManager, ConfigurationManager>(Lifetime.Request);
            composition.Register<IConfigurationPageService, ConfigurationPageService>(Lifetime.Request);
            composition.Register<ICountryPageService, CountryPageService>(Lifetime.Request);
            composition.Register<IFileSystem, FileSystem>(Lifetime.Request);
            composition.Register<IGoogleService, GoogleService>(Lifetime.Request);
            composition.Register<IHomePageService, HomePageService>(Lifetime.Request);
            composition.Register<ILanguagePageService, LanguagePageService>(Lifetime.Request);
            composition.Register<IMetaService, MetaService>(Lifetime.Request);
            composition.Register<IPublishedContentService, PublishedContentService>(Lifetime.Request);
            composition.Register<ISitemapService, SitemapService>(Lifetime.Request);
            composition.Register<IThemeService, ThemeService>(Lifetime.Request);
        }
    }
}