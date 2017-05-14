using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Unknown()
        {
            return View();
        }

        [SharedViewBag]
        public ActionResult About()
        {
            // ViewBag.Message = "Your application description page.";

            throw new ArgumentException("Error Handled!!");

            return View();
        }

        [SharedViewBag(MyProperty = "")]
        public ActionResult PartialAbout()
        {
            // ViewBag.Message = "Your application description page.";

            if (Request.IsAjaxRequest())
            {
                return PartialView("About");
            }
            else
            {
                return View("About");
            }
        }

        public ActionResult SomeAction()
        {
            //Response.Write("<script>alert('建立成功!'); location.href='/';</script>");
            //return "<script>alert('建立成功!'); location.href='/';</script>";
            //return Content("<script>alert('建立成功!'); location.href='/';</script>");
            return PartialView("SuccessRedirect", "/");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult GetFile()
        {
            return File(Server.MapPath("~/Content/WannaCry.png"), "image/png", "NewName.png");
        }

        public ActionResult GetJson()
        {
            db.Configuration.LazyLoadingEnabled = false;

            return Json(db.Product.Take(5),
                JsonRequestBehavior.AllowGet);
        }

        public ActionResult VT() {
            ViewBag.IsEnabled = true;
            return View();
        }

        public ActionResult RazorTest()
        {
            ViewData.Model =new int[] { 1,2,3,4,5 };
            return PartialView();
        }

    }
}