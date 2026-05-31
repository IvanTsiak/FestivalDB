using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace FestivalsBD;

public class DbHelper
{
    private static readonly string? ConnectionString;

    static DbHelper()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory) 
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfiguration config = builder.Build();
        ConnectionString = config.GetConnectionString("DefaultConnection");
        
        if (string.IsNullOrEmpty(ConnectionString))
        {
            throw new InvalidOperationException("No connection string found in the appsettings.json file");
        }
    }

    public static DataTable ExecuteQuery(string query, SqlParameter[]? parameters = null)
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    public static int ExecuteNonQuery(string query, SqlParameter[]? parameters = null)
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
    }

    public static object ExecuteScalar(string query, SqlParameter[]? parameters = null)
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                connection.Open();
                return command.ExecuteScalar();
            }
        }
    }
}