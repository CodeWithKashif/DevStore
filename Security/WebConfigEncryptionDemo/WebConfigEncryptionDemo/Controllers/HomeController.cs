using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebConfigEncryptionDemo.Models;
using WebConfigEncryptionDemo.Repository;

namespace WebConfigEncryptionDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NameValueCollection section = (NameValueCollection)ConfigurationManager.GetSection("secureAppSettings");
            ViewBag.securedUserName = section["userName"];
            ViewBag.securedPassword = section["userPassword"];

            try
            {
                Product product = new ProductRepository().GetProduct();
                ViewBag.ProductId = product.Id;
                ViewBag.ProductName = product.Name;
            }
            catch (Exception){}

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}