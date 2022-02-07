using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookmarksWebApp.Models
{
    public class Bookmark
    {
        public int Id { get; set; }

        public string URL { get; set; }
        public string BookmarkTitle { get; set; }
        public string BookmarkResume { get; set; }

        public Bookmark()
        {

        }
    }
}
