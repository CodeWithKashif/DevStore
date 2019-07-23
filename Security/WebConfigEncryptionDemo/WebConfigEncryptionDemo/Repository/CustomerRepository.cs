using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using WebConfigEncryptionDemo.Models;
using Dapper;

namespace WebConfigEncryptionDemo.Repository
{

    public class ProductRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Product GetProduct()
        {
            using (var db = new SqlConnection(_connectionString))
            {
               return db.Query<Product>("select * from Product").FirstOrDefault();
            }
        }

    }
}
