using System.Collections.Generic;
using System.Web.Http;
using CloudTransformerTemplate.Core.Models;
using CloudTransformerTemplate.Core.Services;
using Umbraco.Web.Editors;
using Umbraco.Web.Mvc;

namespace CloudTransformerTemplate.Core.Controllers.Api
{
    [PluginController("ThemePicker")]
    public class ThemePickerApiController : UmbracoAuthorizedJsonController
    {
        private readonly IThemeService _themeService;

        public ThemePickerApiController(IThemeService themeService)
        {
            _themeService = themeService;
        }

        [HttpGet]
        public IEnumerable<Theme> GetThemes()
        {
            return _themeService.GetAll();
        }
    }
}