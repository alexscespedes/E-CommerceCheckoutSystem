// See https://aka.ms/new-console-template for more information
public class OrderProcessor
{
    private readonly EmailService _emailService;

    public OrderProcessor(EmailService emailService)
    {
        _emailService = emailService;
    }

    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Processing order...");

        Console.WriteLine($"Order contais {order.Items.Count} items.");
        Console.WriteLine($"Total amount: {order.TotalAmount:C}");

        // Send confirmation
        _emailService.SendConfirmation(order);
    }
}