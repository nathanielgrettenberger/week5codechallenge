using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace W3CodeChallenge.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View(new Models.ContactFormForWeek3Challenge());
        }
        [HttpPost]
        public ActionResult Index(Models.ContactFormForWeek3Challenge cf3)
        {
            var db = new Models.MyBlogEntities();
            db.ContactFormForWeek3Challenge.Add(cf3);
            db.SaveChanges();
        
        // kick the user to the thank you page
            return RedirectToAction("ThankYou");}

        public ActionResult ThankYou()
            {
                return View();
            
            }
        }
    }

