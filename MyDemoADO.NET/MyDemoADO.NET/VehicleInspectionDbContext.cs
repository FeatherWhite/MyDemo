using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoADO.NET
{
    public class VehicleInspectionDbContext : MyDBContext
    {
        private static string connectionString = "Server = localhost; Database = VehicleTest; TrustServerCertificate=False;Connection Timeout=30;Integrated Security=SSPI";
        private SqlConnection connection = new SqlConnection(connectionString);
        public override void Connect()
        {
            using (connection)
            {
                try
                {
                    connection.Open();
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("连接失败");
                }
                Console.WriteLine("Connected successfully.");
            }
        }

        public override void InsertRows()
        {
            using (connection)
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"  
                SELECT  
                    TOP 5  
                        [TestNo],
                        [VIN],
                        [TestType] 
                    FROM  
                        GyTempList";

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}",
                            reader.GetString(50),
                            reader.GetString(50),
                            reader.GetString(50));
                    }
                }
            }
        }

        public override void SelectRows()
        {
            throw new NotImplementedException();
        }
    }
}
