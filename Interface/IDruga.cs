using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasAbstaksi.Interface
{
    class IDruga : IVape
    {
        #region IVape Members

        public void harga()
        {
            Console.WriteLine("Harga : -+Rp.770,000");
            Console.WriteLine("=================================================");
        }

        #endregion
    }
}
