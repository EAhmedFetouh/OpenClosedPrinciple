

namespace OpenClosedPrinciple.OpenClosed;

internal class VipDiscount : IDiscount
{
    public decimal Calcualte(decimal total)
    {
        return total* 0.10m;
    }
}
