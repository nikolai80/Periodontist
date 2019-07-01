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
        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        
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


        public bool UpdateArticle(Article article)
        {
            var res = false; 
            res=repo.Update(article);
            return res;
        }

        internal ArticleViewModel GetArticleById(int id)
        {
            var article = repo.FindById(id);

            var res=new ArticleViewModel
            {
                ID=article.ID,
                AuthorName =UserManager.Users.Where(u => u.Id == article.AuthorID).Select(x=>x.UserName).First(),
                Date=article.Date,
                Text=article.Text,
                Title=article.Title
            };
            return res;
        }
    }
}