using Model1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model1.Controllers
{
    public class RecenzieController : Controller
    {
        private RecenzieDBContext db = new RecenzieDBContext();
        // GET: Recenzie
        public ActionResult Index()
        {
            return View();
        }
    }
}