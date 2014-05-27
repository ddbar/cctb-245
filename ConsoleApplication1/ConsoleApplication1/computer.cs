using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Computer : Product // Computer "is a" Product
    {
        public string CPU { get; set; }
        public string OperatingSystem { get; set; }



    }
}
