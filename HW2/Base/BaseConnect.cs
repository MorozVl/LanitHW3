using System.Collections.Specialized;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;


namespace HW2.Base
{
    public class BaseConnect 
    {
        private const string _connectStr = @"Server=localhost\sqlexpress;Database=dml_computer;Trusted_Connection=True";
        
        //PCSpec pCSpec = new PCSpec();
        
        public void WriteNewData(PCSpec pCSpec)
        {
            SqlConnection connection = new SqlConnection(_connectStr);
            connection.Open();
            SqlCommand command = new SqlCommand($"INSERT INTO PC (model,speed,ram,hd,cd,price)" +
                $" VALUES ('{pCSpec.model}','{pCSpec.speed}','{pCSpec.ram}','{pCSpec.hd}','{pCSpec.cd}','{pCSpec.price}') ",connection);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }

        public void ReadData() 
        {
            SqlConnection connection = new SqlConnection(_connectStr);
            connection.Open();
            SqlCommand command = new SqlCommand($"SELECT * FROM PC", connection);
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("code \tmodel \tspeed \tram \thd \tcd \tprice ");
            while (reader.Read())
            {
                Console.WriteLine($"{reader["code"]} \t{reader["model"]} \t{reader["speed"]} " +
                    $"\t{reader["ram"]} \t{reader["hd"]} \t{reader["cd"]} \t{reader["price"]} ");
            }
        }
        public void DeleteData(int id,PCSpec pCSpec) 
        {
            SqlConnection connection = new SqlConnection(_connectStr);
            connection.Open();
            pCSpec.code = id;
            SqlCommand command = new SqlCommand($"delete from PC" +
                                            $"\r\nwhere code = {pCSpec.code}", connection);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }
        public void UpdateData(int id, string field, string data, PCSpec pCSpec) 
        {
            SqlConnection connection = new SqlConnection(_connectStr);
            connection.Open();
            pCSpec.code = id;

            Console.WriteLine("UPDATE PC " +
                $"SET {field} = \'{data}\' " +
                $"WHERE code = {pCSpec.code}");

            SqlCommand command = new SqlCommand($"UPDATE PC " +
                $"SET {field} = \'{data}\' " +
                $"WHERE code = {pCSpec.code}", connection);

            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }

    }
}



//SqlConnection connect = new SqlConnection(@"Server=localhost\sqlexpress;Database=dml_computer;Trusted_Connection=True");
