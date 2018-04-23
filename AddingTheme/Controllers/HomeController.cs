using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AddingTheme.Models;

namespace AddingTheme.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context;

        public HomeController()
        {
            context = new ApplicationDbContext();
        }

        public ActionResult Contactus()
        {
            return View(context.Contacts.ToList());
        }

        public ActionResult Contact()
        {
            return View(new Contact());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                context.Contacts.Add(model);
                await context.SaveChangesAsync();
                return RedirectToAction("Contactus");
            }
            return View();
        }







        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

       

        public ActionResult Cricketallsports()
        {
            ViewBag.Message = "all sports";

            return View();
        }

        public ActionResult Cricketmatchfixing()
        {
            ViewBag.Message = "mix match";

            return View();
        }

        public ActionResult Events()
        {
            ViewBag.Message = "mix events";

            return View();
        }

        public ActionResult Cricketteamranking()
        {
            ViewBag.Message = "team ranking";

            return View();
        }

        public ActionResult Squad()
        {
            ViewBag.Message = "team squad";

            return View();
        }

        public ActionResult Match()
        {
            ViewBag.Message = "team match";

            return View();
        }

        public ActionResult Booking()
        {
            ViewBag.Message = "ticket-booking";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "team register";

            return View();
        }

        public ActionResult Training()
        {
            ViewBag.Message = "training";

            return View();
        }

        public ActionResult Joinclub()
        {
            ViewBag.Message = "join club";

            return View();
        }

        public ActionResult cricketabout()
        {
            ViewBag.Message = "about cricket";

            return View();
        }
    }
}