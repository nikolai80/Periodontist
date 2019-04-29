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

        public void Create(Article item)
        {
            throw new NotImplementedException();
        }

        public Article FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetAll()
        {
            IEnumerable<Article> articles;
            string sql="SELECT * FROM Articles";
            using (SqlConnection cn = new SqlConnection(connString))
            {
                cn.Open();
                int personId = 1;
                 articles= cn.Query<Article>(sql);
                cn.Close();
            }

            return articles;
        }

        public void Remove(Article item)
        {
            throw new NotImplementedException();
        }

        public void Update(Article item)
        {
            throw new NotImplementedException();
        }
    }
}