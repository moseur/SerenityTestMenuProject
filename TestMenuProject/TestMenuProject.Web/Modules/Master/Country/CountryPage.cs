using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace TestMenuProject.Master.Pages
{

    [PageAuthorize(typeof(CountryRow))]
    public class CountryController : Controller
    {
        [Route("Master/Country")]
        public ActionResult Index()
        {
            return View("~/Modules/Master/Country/CountryIndex.cshtml");
        }
    }
}