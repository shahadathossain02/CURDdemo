using System.Data.SqlClient;
using System.Web.Configuration;

namespace CURDdemo.Models
{
    public class CommonGateway
    {
        private static string connectionString = WebConfigurationManager.ConnectionStrings["CURDdemoDB"].ConnectionString;
        public static SqlConnection connection;
        public static SqlCommand command;

        static CommonGateway()
        {
            connection = new SqlConnection(connectionString);
        }
    }
}