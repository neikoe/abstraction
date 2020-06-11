using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasAbstaksi.AbstractClass
{
    public class Therion : Vape
    {
        public override void spek()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("Therion DNA ");
            Console.WriteLine("Maximal Power : 75W/133W/166W");
            Console.WriteLine("Battery : 2x 18650 cells");
        }
    }
}
