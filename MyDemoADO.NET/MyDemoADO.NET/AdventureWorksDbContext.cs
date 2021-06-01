using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoADO.NET
{
    public class AdventureWorksDbContext:MyDBContext
    {
        private static string connectionString = "Server = localhost\\SQLEXPRESS; Database = AdventureWorksLT2019; TrustServerCertificate=False;Connection Timeout=30;Integrated Security=SSPI";
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
        public override void SelectRows()
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
                        COUNT(soh.SalesOrderID) AS [OrderCount],  
                        c.CustomerID,  
                        c.CompanyName  
                    FROM  
                                        SalesLT.Customer         AS c  
                        LEFT OUTER JOIN SalesLT.SalesOrderHeader AS soh  
                            ON c.CustomerID = soh.CustomerID  
                    GROUP BY  
                        c.CustomerID,  
                        c.CompanyName  
                    ORDER BY  
                        [OrderCount] DESC,  
                        c.CompanyName; ";

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}",
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetString(2));
                    }
                }
            }
        }

        public override void InsertRows()
        {
            SqlParameter parameter;
            using (connection)
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"  
                INSERT INTO SalesLT.Product  
                        (Name,  
                        ProductNumber,  
                        StandardCost,  
                        ListPrice,  
                        SellStartDate  
                        )  
                    OUTPUT  
                        INSERTED.ProductID  
                    VALUES  
                        (@Name,  
                        @ProductNumber,  
                        @StandardCost,  
                        @ListPrice,  
                        CURRENT_TIMESTAMP  
                        ); ";

                    parameter = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                    parameter.Value = "SQL Server Express 2014";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@ProductNumber", SqlDbType.NVarChar, 25);
                    parameter.Value = "SQLEXPRESS2014";
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@StandardCost", SqlDbType.Int);
                    parameter.Value = 11;
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter("@ListPrice", SqlDbType.Int);
                    parameter.Value = 12;
                    command.Parameters.Add(parameter);

                    int productId = (int)command.ExecuteScalar();
                    Console.WriteLine("The generated ProductID = {0}.", productId);
                }
            }
        }
    }
}
