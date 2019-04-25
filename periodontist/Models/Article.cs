using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace periodontist.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public ApplicationUser Author { get; set; }
    }
}