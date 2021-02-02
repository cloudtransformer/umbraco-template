using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace CloudTransformerTemplate.Core.Controllers
{
    public class HomePageController : RenderMvcController
    {
        public override ActionResult Index(ContentModel model)
        {
            return CurrentTemplate(model);
        }
    }
}