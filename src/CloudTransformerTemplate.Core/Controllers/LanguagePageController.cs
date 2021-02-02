using System.Web.Mvc;
using CloudTransformerTemplate.Core.Services;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web;

namespace CloudTransformerTemplate.Core.Controllers
{
    public class LanguagePageController : RenderMvcController
    {
        private readonly IHomePageService _homePageService;

        public LanguagePageController(IHomePageService homePageService)
        {
            _homePageService = homePageService;
        }
        
        public override ActionResult Index(ContentModel model)
        {
            return Redirect(_homePageService.Get().Url());
        }
    }
}