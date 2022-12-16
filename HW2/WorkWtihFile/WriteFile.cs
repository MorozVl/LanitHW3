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
            using HttpClient client = new HttpClient();

            var responce = client.GetAsync(Console.ReadLine());
            using StreamWriter streamWriter = new StreamWriter("C:\\tmp\\Sample1.txt");

            streamWriter.WriteLine(responce);
            streamWriter.Close();
        }
    }
}
