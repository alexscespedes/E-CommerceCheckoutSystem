// See https://aka.ms/new-console-template for more information
public class OrderProcessor
{
    private readonly EmailService _emailService;
    private readonly IDiscountStrategy _discountStrategy;

    public OrderProcessor(EmailService emailService, IDiscountStrategy discountStrategy)
    {
        _emailService = emailService;
        _discountStrategy = discountStrategy;
    }

    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Processing order...");

        decimal discountedTotal = _discountStrategy.ApplyDiscount(order.TotalAmount);
        Console.WriteLine($"Order contais {order.Items.Count} items.");
        Console.WriteLine($"Original Total: {order.TotalAmount:C}");
        Console.WriteLine($"Discounted Total: {discountedTotal:C}");

        order.TotalAmount = discountedTotal;

        // Send confirmation
        _emailService.SendConfirmation(order);
    }
}