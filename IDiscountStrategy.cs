// See https://aka.ms/new-console-template for more information
public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal total);
}