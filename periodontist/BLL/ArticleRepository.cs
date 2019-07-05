using periodontist.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Dapper;
using periodontist.Models;
using System.Data.SqlClient;
using NLog;
using System.Net;

namespace periodontist.BLL
{
    public class ArticleRepository : IRepository<Article>
    {
        private Logger _log=LogManager.GetLogger("admin");
        private string connString = WebConfigurationManager.ConnectionStrings["PeriodontistConnection"].ConnectionString;

        public bool Create(Article item)
        {
            var res = false;
            string sql = "INSERT INTO p_Article(Title,Text,AuthorID,Data) VALUES(N'" + item.Title + "',N'" + item.Text + "','" + item.AuthorID + "','" + item.Date + "')";
            using (SqlConnection cn = new SqlConnection(connString))
            {
                cn.Open();
                try
                {
                    cn.ExecuteScalar(sql);
                    res=true;
                }
                catch (Exception ex)
                {
                    _log.Error(ex.Message);
                    res=false;
                }
                cn.Close();
            }
            return res;
        }

        public Article FindById(int id)
        {
            Article article = null;
            string sql = "SELECT * FROM p_Article WHERE Id=" + id;
            using (SqlConnection cn = new SqlConnection(connString))
            {
                cn.Open();
                article = cn.Query<Article>(sql).FirstOrDefault();
                cn.Close();
            }

            return article;
        }

        public IEnumerable<Article> GetAll()
        {
            IEnumerable<Article> articles;
            string sql = "SELECT * FROM p_Article";
            using (SqlConnection cn = new SqlConnection(connString))
            {
                cn.Open();
                int personId = 1;
                articles = cn.Query<Article>(sql);
                cn.Close();
            }

            return articles;
        }

        public void Remove(int id)
        {
            string sql = "DELETE FROM p_Article WHERE Id=" + id;
            using (SqlConnection cn = new SqlConnection(connString))
            {
                cn.Open();
                var res = cn.ExecuteScalar(sql);
                cn.Close();
            }
        }

        public bool Update(Article item)
        {
            bool res = false;
            string sql = "UPDATE p_Article SET Title=N'" + item.Title + "',Text=N'" + item.Text + "',AuthorID='" + item.AuthorID + "',Data='" + item.Date + "' WHERE Id=" + item.ID;
            try
            {
                using (SqlConnection cn = new SqlConnection(connString))
                {
                    cn.Open();
                    var rr = cn.ExecuteScalar(sql);
                    res = true;
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                _log.Info("Данные не обновлены для {0}- {1}",item.ID,item.Title);
                _log.Error(ex.Message);
            }

            return res;
        }
    }
}