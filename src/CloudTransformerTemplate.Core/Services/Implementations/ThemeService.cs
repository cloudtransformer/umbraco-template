using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Threading;
using CloudTransformerTemplate.Core.Models;
using Umbraco.Web;

namespace CloudTransformerTemplate.Core.Services.Implementations
{
    public class ThemeService : IThemeService
    {
        private readonly IConfigurationPageService _configurationPageService;
        private readonly IFileSystem _fileSystem;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ThemeService(
            IConfigurationPageService configurationPageService,
            IFileSystem fileSystem, 
            IHttpContextAccessor httpContextAccessor)
        {
            _configurationPageService = configurationPageService;
            _fileSystem = fileSystem;
            _httpContextAccessor = httpContextAccessor;
        }

        public IEnumerable<Theme> GetAll()
        {
            var retval = new List<Theme>();

            var themesPath = _httpContextAccessor.HttpContext.Server.MapPath("~/css/");
            var themes = _fileSystem.Directory.GetDirectories(themesPath);

            foreach (var theme in themes)
            {
                var id = theme.TrimEnd('\\');
                id = id.Substring(id.LastIndexOf("\\", StringComparison.Ordinal) + 1);

                retval.Add(new Theme
                {
                    Id = id,
                    Name = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(id.Replace("-", " "))
                });
            }

            return retval;
        }

        public string Get()
        {
            return _configurationPageService.GetSiteContentPage().SiteTheme;
        }
    }
}