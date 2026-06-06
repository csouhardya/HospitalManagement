using Microsoft.Data.SqlClient;
using System.Data;

namespace HospitalManagement.DbHelpers
{
    public class LegacySqlHelper
    {
        private readonly IConfiguration _configuration;

        public LegacySqlHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DataTable ExecuteQuery(string sql)
        {
            var table = new DataTable();

            var con = new SqlConnection(_configuration.GetConnectionString("Default"));
            var cmd = new SqlCommand(sql, con);

            con.Open();

            var reader = cmd.ExecuteReader();
            table.Load(reader);

            con.Close();

            return table;
        }
    }
}
