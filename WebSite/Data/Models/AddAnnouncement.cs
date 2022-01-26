using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data.Interfaces;

namespace WebSite.Data.Models
{
    public class AddAnnouncement : IAddAnnouncement
    {
        public void Set(Announcement announcement)
        {
            using (AppContext context = new AppContext())
            {
                context.announcements.Add(announcement);
                context.SaveChanges();
            }
        }
    }
}
