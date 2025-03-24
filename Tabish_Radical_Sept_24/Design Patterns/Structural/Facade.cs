using System;

namespace Tabish_Radical_Sept_24.Design_Patterns.Structural
{
    internal class OrderFacade
    {
        private readonly InventoryService _inventoryService;
        private readonly PaymentService _paymentService;
        private readonly ShippingService _shippingService;

        public OrderFacade()
        {
            _inventoryService = new InventoryService();
            _paymentService = new PaymentService();
            _shippingService = new ShippingService();
        }

        public void PlaceOrder(string productId, int quantity, string paymentInfo, string shippingAddress)
        {
            if (_inventoryService.CheckAvailability(productId, quantity))
            {
                if (_paymentService.ProcessPayment(paymentInfo))
                {
                    _shippingService.ShipOrder(productId, quantity, shippingAddress);
                    Console.WriteLine("Order placed successfully!");
                }
                else
                {
                    Console.WriteLine("Payment processing failed.");
                }
            }
            else
            {
                Console.WriteLine("Product is not available.");
            }
        }
    }

    internal class InventoryService
    {
        public bool CheckAvailability(string productId, int quantity)
        {
            // Check inventory logic
            return true; // Assume product is available for simplicity
        }
    }

    internal class PaymentService
    {
        public bool ProcessPayment(string paymentInfo)
        {
            // Payment processing logic
            return true; // Assume payment is successful for simplicity
        }
    }

    internal class ShippingService
    {
        public void ShipOrder(string productId, int quantity, string shippingAddress)
        {
            // Shipping logic
            Console.WriteLine($"Shipping {quantity} of {productId} to {shippingAddress}.");
        }
    }

    class ConsoleCLient
    {
        public static void Main()
        {
            OrderFacade orderFacade = new OrderFacade();
            orderFacade.PlaceOrder("ABC123", 2, "Credit Card", "123 Main St, Anytown");
        }
    }
}
