using periodontist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace periodontist.BLL.Managers
{
    public class ArticleManager
    {
        ArticleRepository repo = new ArticleRepository();

        public bool CreateArticle(Article article)
        {
            var res = false;
            res = repo.Create(article);
            return res;
        }

        public List<Article> GetAllArticles()
        {
            List<Article> articles = new List<Article>();
            articles = repo.GetAll().ToList();
            return articles;
        }

    }
}