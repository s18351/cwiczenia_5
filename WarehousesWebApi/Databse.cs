using Microsoft.Data.SqlClient;
using System.Data;
using WarehousesWebApi.Model;

namespace WarehousesWebApi
{
    public class Databse : IDatabse
    {
        static string connectionString = "Data Source=db-mssql16;Initial Catalog=s18351;Integrated Security=True;TrustServerCertificate=true;";

        public void ExecuteStoredProcedure(string name, Dictionary<string, object> prms)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(name, connection) { CommandType = CommandType.StoredProcedure };
                foreach (var item in prms)
                {
                    command.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
