using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data.Interfaces;
using WebSite.Data.Models;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        private IGetAnnouncement announcements = new GetAnnouncement();

        public ViewResult Index()
        {
            ViewBag.Title = "Index";

            return View(announcements.GetAll());
        }
    }
}
