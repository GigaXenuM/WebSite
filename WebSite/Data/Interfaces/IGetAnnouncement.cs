using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data.Models;

namespace WebSite.Data.Interfaces
{
    interface IGetAnnouncement
    {
        public IEnumerable<Announcement> GetAll();
        public Announcement GetObject(int id);
    }
}
