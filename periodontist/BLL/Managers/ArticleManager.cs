using periodontist.Areas.Admin.Models;
using periodontist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLog;

namespace periodontist.BLL.Managers
{
    public class ArticleManager
    {
        private Logger _log=LogManager.GetLogger("admin");
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
            try
            {
                articles = repo.GetAll().ToList();
            }
            catch (Exception ex)
            {

          _log.Error(ex.Message);
            }
            return articles;
        }

    }
}