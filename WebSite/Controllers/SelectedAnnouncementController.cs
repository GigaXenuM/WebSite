using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data.Interfaces;
using WebSite.Data.Models;

namespace WebSite.Controllers
{
    public class SelectedAnnouncementController : Controller
    {
        private IGetAnnouncement announcements = new GetAnnouncement();
        public ViewResult Index(int id)
        {
            Announcement announcement = announcements.GetObject(id);
            ViewBag.SimilarAnnouncements = announcements.GetSimilar(announcement);
            return View(announcement);
        }
    }
}
