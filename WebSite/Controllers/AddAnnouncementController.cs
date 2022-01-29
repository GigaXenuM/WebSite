using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data.Interfaces;
using WebSite.Data.Models;

namespace WebSite.Controllers
{
    public class AddAnnouncementController : Controller
    {
        public ActionResult index(string title = null, string description = null)
        {
            if (title != null && description != null)
            {
                IOperationOnAnnouncement announcement = new OperationOnAnnouncement();
                announcement.Set(new Announcement(title, description, DateTime.Now.ToShortDateString()));
                return Redirect("/home/index");
            }
            return View();
        }
    }
}
