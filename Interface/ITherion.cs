using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugasAbstaksi.Interface
{
    class ITherion : IVape
    {
        #region IVape Members

        public void harga()
        {
            Console.WriteLine("Harga : -+Rp.1.600,000");
            Console.WriteLine("=================================================");
        }

        #endregion
    }
}
