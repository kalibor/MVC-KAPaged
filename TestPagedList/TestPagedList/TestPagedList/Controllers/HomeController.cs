using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestPagedList.KAPagedTool;
using TestPagedList.Models;

namespace TestPagedList.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int page =1,int size =3)
        {
            Models.AnimalEntities db = new Models.AnimalEntities();

            List<Bear> list = db.Bear.ToList();
            var pagedData = list.ToKAPaged(new KAPagedContext(page, size));
            return View(pagedData);
        }


    }

}