using periodontist.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Dapper;
using periodontist.Models;
using System.Data.SqlClient;

namespace periodontist.BLL
{
    public class ArticleRepository : IRepository<Article>
    {
        private string connString = WebConfigurationManager.ConnectionStrings["PeriodontistConnection"].ConnectionString;

        public bool Create(Article item)
        {
            var res = false;
            string sql = "INSERT INTO p_Article(Title,Text,UserID,Data) VALUES(" + item.Title + "," + item.Text + "," + item.Author.Id + "," + item.Date + ")";
            using (SqlConnection cn = new SqlConnection(connString))
            {
                cn.Open();
                try
                {
                    cn.ExecuteScalar(sql);
                    res=true;
                }
                catch (Exception)
                {
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

        public void Remove(Article item)
        {
            string sql = "DELETE FROM p_Article WHERE Id=" + item.ID;
            using (SqlConnection cn = new SqlConnection(connString))
            {
                cn.Open();
                var res = cn.ExecuteScalar(sql);
                cn.Close();
            }
        }

        public void Update(Article item)
        {
            string sql = "UPDATE p_Article SET Title=" + item.Title + ",Text=" + item.Text + ",UserID=" + item.Author.Id + ",Data=" + item.Date + "WHERE Id=" + item.ID;
            using (SqlConnection cn = new SqlConnection(connString))
            {
                cn.Open();
                var res = cn.ExecuteScalar(sql);
                cn.Close();
            }
        }
    }
}