

namespace OpenClosedPrinciple.OpenClosed;

public class NewDiscountService
{
    private readonly IDiscount _discount;
    public NewDiscountService(IDiscount discount)
    {
        _discount = discount;
    }
    public decimal CalculateTotal(decimal total)
    {
        return  _discount.Calcualte(total);
    }
}
