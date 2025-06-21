// See https://aka.ms/new-console-template for more information
public class EmailService
{
    public void SendConfirmation(Order order)
    {
        Console.WriteLine("Sending confirmation email...");
        Console.WriteLine($"Email: Thank you for your order of {order.TotalAmount:C}!");
    }
}