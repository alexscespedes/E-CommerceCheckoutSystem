// See https://aka.ms/new-console-template for more information
public class Order
{
    public List<string> Items { get; set; } = new List<string>();
    public decimal TotalAmount { get; set; }

    public Order()
    {
    }

    public void AddItem(string item, decimal price)
    {
        Items.Add(item);
        TotalAmount += price;
    }
}