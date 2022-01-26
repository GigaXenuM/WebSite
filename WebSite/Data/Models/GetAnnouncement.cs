using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data.Interfaces;

namespace WebSite.Data.Models
{
    public class GetAnnouncement : IGetAnnouncement
    {
        private List<Announcement> announcements = new List<Announcement>
        {
            new Announcement
            {
                title = "Junior Software Engineer (Java, .NET)",
                description = "If you are young, talented, have basic knowledge of one of the program languages as Java/.NET, and looking forward to getting your first commercial software development experience — you are more than welcome to apply.",
                dateAdded = "11/01.2022",
            },
            new Announcement
            {
                title = "Junior .NET Developer",
                description = "Valtech Craft Studio introduces .NET internship program. This is a 2,5 months, trainers led program, focused on a fast track to gain real project experience and to help you elevate to Junior level in the shortest possible timeline. You will work at Valtech fulltime from day 1 and after 2,5 months of practice with a trainers you will be assigned to real client projects in shadow mode with a dedicated mentor. ",
                dateAdded = "11/01.2022",
            },
            new Announcement
            {
                title = ".Net Intern",
                description = "We are looking for highly motivated people to join our internship program. You need to have a strong theoretical knowledge in software development (.NET in particular) and a good command of English.  This is an amazing opportunity for people without (or with little) experience to join a leading global digital consultancy and to start your exciting career in IT!",
                dateAdded = "11/01.2022",
            }
        };

        public GetAnnouncement()
        {
            using (AppContext context = new AppContext())
            {
                if (context.announcements.ToList().Count == 0)
                {
                    foreach (var item in announcements)
                    {
                        context.announcements.Add(item);
                    }
                    context.SaveChanges();
                }
            }
        }
        public IEnumerable<Announcement> GetAll()
        {
            using (AppContext context = new AppContext())
            {
                return context.announcements.ToList();
            }
        }

        public Announcement GetObject(int id)
        {
            using (AppContext context = new AppContext())
            {
                return context.announcements.FirstOrDefault(i => i.id == id);
            }
        }
    }
}
