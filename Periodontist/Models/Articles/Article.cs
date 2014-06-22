using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Periodontist.Models.Articles
    {
    public class Article
        {
        public long ArticleID { get; set; }
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string Content { get; set; }
        }
    }