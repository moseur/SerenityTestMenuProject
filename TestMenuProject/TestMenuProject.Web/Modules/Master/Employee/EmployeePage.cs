using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace TestMenuProject.Master.Pages
{

    [PageAuthorize(typeof(EmployeeRow))]
    public class EmployeeController : Controller
    {
        [Route("Master/Employee")]
        public ActionResult Index()
        {
            return View("~/Modules/Master/Employee/EmployeeIndex.cshtml");
        }
    }
}