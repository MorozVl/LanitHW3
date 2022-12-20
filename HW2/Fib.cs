using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class Fib
    {
       
        public int Fibonachi(int n)
        {
           
            if( n== 0 || n == 1) { return n; }

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
    }
}
