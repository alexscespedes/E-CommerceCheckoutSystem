
var order = new Order();
order.AddItem("Laptop", 1200);
order.AddItem("Mouse", 50);

var emailService = new EmailService();
var discount = new HolidayDiscount(); // Try switching to NoDiscount or LoyalCustomerDiscount

var processor = new OrderProcessor(emailService, discount);
processor.ProcessOrder(order);