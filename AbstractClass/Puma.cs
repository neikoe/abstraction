using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasAbstaksi.AbstractClass
{
    public class Puma : Vape
    {
        public override void spek()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("Puma Box ");
            Console.WriteLine("Maximal Power : 200W");
            Console.WriteLine("Battery : 2x 18650 cells");
        }
    }
}
