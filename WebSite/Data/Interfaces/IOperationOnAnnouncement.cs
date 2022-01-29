using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data.Models;

namespace WebSite.Data.Interfaces
{
    interface IOperationOnAnnouncement
    {
        public void Set(Announcement announcement);
        public void Delete(Announcement announcement);
        public void Edit(Announcement announcement, string title, string description);
    }
}
