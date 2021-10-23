using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Fbg.Market.Repository
{
    public class DapperContext
    {
        private string _connectionString;

        /*public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
        }*/

        public IDbConnection CreateConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["FBGMarket_CS"].ToString();
            return new SqlConnection(_connectionString);
        }
    }
}
