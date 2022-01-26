using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Data.Models
{
    public class Announcement
    {
        public Announcement() { }
        public Announcement(string title, string description, string dateAdded)
        {
            this.title = title;
            this.description = description;
            this.dateAdded = dateAdded;
        }

        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string dateAdded { get; set; }
    }
}
