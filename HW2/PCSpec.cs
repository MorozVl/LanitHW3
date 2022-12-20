using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class PCSpec
    {
        public int code { get; set; }
        public string model { get; set; }
        public int speed { get; set; } = 0;
        public int ram { get; set; } = 0;
        public double hd { get; set; } = 0;
        public string cd { get; set; } = "0";
        public double price { get; set; } = 0.0;

    }
}
