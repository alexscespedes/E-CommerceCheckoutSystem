// See https://aka.ms/new-console-template for more information
public class LoyalCustomerDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal total)
    {
        return total - 20m; // Flat $20 discount
    }
}