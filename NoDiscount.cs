// See https://aka.ms/new-console-template for more information
public class NoDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal total)
    {
        return total;
    }
}