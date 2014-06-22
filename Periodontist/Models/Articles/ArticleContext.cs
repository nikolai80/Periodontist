using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Periodontist.Models.Articles
    {
    public class ArticleContext:DbContext
        {
        //Для связывания контекста со строкой подключения
        public ArticleContext():base("periodontist")
        {
        }
        public DbSet<Article> Articles { get; set; } 
        }
    }