
namespace OpenClosedPrinciple
{
    public class DiscountService
    {
        public decimal CalculateDiscount(decimal total, string customerType)
        {
            if (customerType == "Regular")
            {
                return total * 0.05m;
            }
            else if (customerType == "VIP")
            {
                return total * 0.10m;
            }

            else
                return 0;
        }
    }
}
