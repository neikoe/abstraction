using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using TugasAbstaksi.AbstractClass;
using TugasAbstaksi.Interface;
namespace TugasAbstaksi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                  Informasi Spesifikasi Dan Harga Vape              ");
            Console.WriteLine("===============================================");
            //AbstractClass
            Vape vape;
            Vape vape2;
            Vape vape3;
            //Interface
            IVape ivape;
            IVape ivape2;
            IVape ivape3;
            vape = new Druga();
            vape.spek();
            ivape = new IDruga();
            ivape.harga();
            vape2 = new Therion();
            vape2.spek();
            ivape2 = new ITherion();
            ivape2.harga();
            vape3 = new Puma();
            vape3.spek();
            ivape3 = new IPuma();
            ivape3.harga();

            Console.WriteLine("================================================");
            Console.ReadKey();
        }
    }
}
