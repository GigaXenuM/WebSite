using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data.Models;

namespace WebSite.Data.Interfaces
{
    interface IAddAnnouncement
    {
        public void Set(Announcement announcement);
    }
}
