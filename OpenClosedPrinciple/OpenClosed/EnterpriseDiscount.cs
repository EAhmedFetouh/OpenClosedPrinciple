

namespace OpenClosedPrinciple.OpenClosed;

public class EnterpriseDiscount : IDiscount
{
    public decimal Calcualte(decimal total)
    {
       return total * 0.20m;
    }
}
