using System.Web.Mvc;
using CloudTransformerTemplate.Core.Services;
using CloudTransformerTemplate.Core.ViewModels;
using Umbraco.Web.Mvc;

namespace CloudTransformerTemplate.Core.Controllers
{
    public class SharedController : SurfaceController
    {
        private readonly IApplicationInsightsService _applicationInsightsService;
        private readonly ICountryPageService _countryPageService;
        private readonly IGoogleService _googleService;
        private readonly ILanguagePageService _languagePageService;
        private readonly IMetaService _metaService;
        private readonly IThemeService _themeService;

        public SharedController(
            IApplicationInsightsService applicationInsightsService,
            ICountryPageService countryPageService,
            IGoogleService googleService,
            ILanguagePageService languagePageService,
            IMetaService metaService, 
            IThemeService themeService)
        {
            _applicationInsightsService = applicationInsightsService;
            _countryPageService = countryPageService;
            _googleService = googleService;
            _languagePageService = languagePageService;
            _metaService = metaService;
            _themeService = themeService;
        }

        [ChildActionOnly]
        public ActionResult ApplicationInsights()
        {
            return PartialView("ApplicationInsights", _applicationInsightsService.GetInstrumentationKey());
        }

        [ChildActionOnly]
        public ActionResult CountrySelector()
        {
            return PartialView("CountrySelector", new CountrySelectorViewModel
            {
                Countries = _countryPageService.GetAll(),
                Current = _countryPageService.Get()
            });
        }

        [ChildActionOnly]
        public ActionResult GoogleAnalytics()
        {
            return PartialView("GoogleAnalytics", _googleService.GetAnalyticsCode());
        }

        [ChildActionOnly]
        public ActionResult GoogleSiteVerification()
        {
            return PartialView("GoogleSiteVerification", _googleService.GetSiteVerificationCode());
        }

        [ChildActionOnly]
        public ActionResult LanguageSelector()
        {
            return PartialView("LanguageSelector", new LanguageSelectorViewModel
            {
                Languages = _languagePageService.GetAll(),
                Current = _languagePageService.Get()
            });
        }

        [ChildActionOnly]
        public ActionResult MetaDescription()
        {
            return PartialView("MetaDescription", _metaService.GetDescription());
        }

        [ChildActionOnly]
        public ActionResult MetaKeywords()
        {
            return PartialView("MetaKeywords", _metaService.GetKeywords());
        }

        [ChildActionOnly]
        public ActionResult MetaRobots()
        {
            return PartialView("MetaRobots", new MetaRobotsViewModel
            {
                NoFollow = _metaService.GetRobotsNoFollow(),
                NoIndex = _metaService.GetRobotsNoIndex()
            });
        }

        [ChildActionOnly]
        public ActionResult MetaTitle()
        {
            return Content(_metaService.GetTitle());
        }

        [ChildActionOnly]
        public ActionResult Theme()
        {
            return PartialView("Theme", _themeService.Get());
        }
    }
}