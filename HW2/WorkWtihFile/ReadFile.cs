using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW2.WorkWtihFile
{
    internal class ReadFile
    {
        public void Read(int lineCount)
        {
            string line;
            try
            {
                using StreamReader sr = new StreamReader("C:\\tmp\\Sample.txt");

                line = sr.ReadLine();

                for (int i = 0; i != lineCount; i++)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
