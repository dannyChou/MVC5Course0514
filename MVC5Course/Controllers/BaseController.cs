using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5Course.Models;
using MVC5Course.Models.ViewModels;

namespace MVC5Course.Controllers
{
    public abstract class BaseController : Controller
    {
        protected FabricsEntities db = new FabricsEntities();

        public ActionResult Debug()
        {
            return Content("Hello");
        }

        //protected override void HandleUnknownAction(string actionName)
        //{
        //    this.RedirectToAction("Index", "Home").ExecuteResult(this.ControllerContext);
        //}
    }
}