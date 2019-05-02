using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace periodontist.Areas.Admin.Models
{
    public class ArticleViewModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string AuthorName { get; set; }
    }
}