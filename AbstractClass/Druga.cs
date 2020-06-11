using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasAbstaksi.AbstractClass
{
    public class Druga : Vape
    {
        public override void spek()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("Druga Foxy ");
            Console.WriteLine("Maximal Power : 150W");
            Console.WriteLine("Battery : 2x 18650 cells");
        }
    }
}
