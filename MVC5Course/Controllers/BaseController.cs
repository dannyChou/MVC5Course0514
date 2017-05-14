using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5Course.Models;
using MVC5Course.Models.ViewModels;
using System.Data.Entity.Validation;

namespace MVC5Course.Controllers
{
    [HandleError(ExceptionType = typeof(DbEntityValidationException), View = "Error_DbEntityValidationException")]
    public abstract class BaseController : Controller
    {
        protected FabricsEntities db = new FabricsEntities();

        [LocalOnly]
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