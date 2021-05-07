using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTVWebAPI.Controllers
{
    public class BorrowsController : Controller
    {
        // GET: Borrows
        public ActionResult Index()
        {
            return View();
        }
    }
}