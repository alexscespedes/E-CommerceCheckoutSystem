// See https://aka.ms/new-console-template for more information
public class HolidayDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal total)
    {
        return total * 0.9m;
    }
}