using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data.Interfaces;
using WebSite.Data.Models;

namespace WebSite.Controllers
{
    public class DeleteAnnouncementController : Controller
    {

        public ActionResult Index(int id)
        {
            IGetAnnouncement currentAnnouncement = new GetAnnouncement();
            IOperationOnAnnouncement announcement = new OperationOnAnnouncement();

            announcement.Delete(currentAnnouncement.GetObject(id));

            return View();
        }
    }
}
