using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data.Interfaces;
using WebSite.Data.Models;

namespace WebSite.Controllers
{
    public class EditAnnouncementController : Controller
    {

        public ActionResult Index(int id, bool isEdited = false, string title = null, string description = null)
        {
            IGetAnnouncement currentAnnouncement = new GetAnnouncement();
            if (isEdited)
            {
                IOperationOnAnnouncement announcement = new OperationOnAnnouncement();

                announcement.Edit(currentAnnouncement.GetObject(id), title, description);
                return Redirect($"/SelectedAnnouncement/index/{id}");
            }

            return View(currentAnnouncement.GetObject(id));
        }
    }
}
