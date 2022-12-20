using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW2.WorkWtihFile
{
    public class WriteFile
    {
        public void WriteF()
        {
            try
            {
                using HttpClient client = new HttpClient();

                var responce = client.GetAsync(Console.ReadLine());
                using StreamWriter streamWriter = new StreamWriter("C:\\tmp\\Sample1.txt");

                streamWriter.WriteLine(responce);
                streamWriter.Close();
            } 
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ссылка не работает \n" + ex.Message + "\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
    }
}
