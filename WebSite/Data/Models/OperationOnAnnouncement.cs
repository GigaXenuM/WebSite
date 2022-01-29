using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data.Interfaces;

namespace WebSite.Data.Models
{
    public class OperationOnAnnouncement : IOperationOnAnnouncement
    {
        public void Set(Announcement announcement)
        {
            using (AppContext context = new AppContext())
            {
                context.announcements.Add(announcement);
                context.SaveChanges();
            }
        }
        public void Delete(Announcement announcement)
        {
            using (AppContext context = new AppContext())
            {
                context.announcements.Remove(announcement);
                context.SaveChanges();
            }
        }
        public void Edit(Announcement announcement, string title, string description)
        {
            using (AppContext context = new AppContext())
            {
                announcement.title = title;
                announcement.description = description;
                context.announcements.Update(announcement);
                context.SaveChanges();
            }
        }
    }
}
