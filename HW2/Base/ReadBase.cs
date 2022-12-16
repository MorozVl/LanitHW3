using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2.Base
{
    public class ReadBase : BaseConnect
    {
        //string V = @"Server=localhost\sqlexpress;Database=dml_computer;Trusted_Connection=True";
        public void Read() 
        {
            
            
            string query = "select pro.model\r\n" +
            ",p.ram\r\n" +
            ",p.price\r\n" +
            "from Product pro\r\n" +
            "join PC p on pro.model = p.model \r\n" +
            "union\r\n" +
            "select pro.model\r\n" +
            ",l.ram\r\n" +
            ",l.price\r\n" +
            "from product pro\r\n" +
            "join Laptop l on pro.model = l.model";

            SqlCommand command = new SqlCommand(query);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"model {reader["model"]} - {reader["ram"]} - {reader["price"]}");
            }

        }
    }
}
