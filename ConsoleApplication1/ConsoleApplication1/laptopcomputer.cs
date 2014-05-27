using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class laptopcomputer : Computer
    {
        public double MonitorSize { get; set; }

        public override void Purchase()
        {
            Console.Write("A " + MonitorSize + " laptop ");
            base.Purchase();
        }

    }

   


}
