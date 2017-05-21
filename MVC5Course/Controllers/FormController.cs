using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class FormController : BaseController
    {
        // GET: Form
        public ActionResult Index()
        {
            ViewData.Model = db.Product.Take(10);
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <remarks>
        /// 這裡的id 有做ModelBind 會產生ModelState
        /// </remarks>
        public ActionResult Edit(int id)
        {
            var product = db.Product.Find(id);
            product.ProductName = "TEST Danny";

            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(int id,FormCollection form)
        {
            var product = db.Product.Find(id);

            if (TryUpdateModel(product,
                includeProperties:new[] { "ProductName"}))
            {
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }
    }
}