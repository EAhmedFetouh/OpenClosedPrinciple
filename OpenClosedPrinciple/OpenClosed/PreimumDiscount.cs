

namespace OpenClosedPrinciple.OpenClosed;

public class PreimumDiscount : IDiscount
{
    public decimal Calcualte(decimal total)
    {
        return total * 0.15m;
    }
}
