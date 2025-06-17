using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.OpenClosed
{
    public class RegularDiscount : IDiscount
    {
        public decimal Calcualte(decimal total)
        {
            return total * 0.05m;
        }
    }
}
