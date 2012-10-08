using System.Web.Mvc;

namespace MvcSourceCodeLearning.Controllers
{
    public class ErrorController: Controller
    {
        public ActionResult NotFound()
        {
            return View("404");
        }
    }
}