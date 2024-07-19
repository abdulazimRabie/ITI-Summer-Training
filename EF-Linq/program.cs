using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EF_Linq.Data;
using EF_Linq.Models;

namespace EF_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup our Dependency Injection
            var serviceProvider = new ServiceCollection()
                .AddDbContext<MyPizzaContext>(options =>
                    options.UseSqlServer("Server=DESKTOP-LUMK2AN\SQLEXPRESS;Database=PizzaDB;User Id=abdulazim;Password=3020320;"
))
                .BuildServiceProvider();

            // Get the context from the service provider
            using (var context = serviceProvider.GetService<MyPizzaContext>())
            {
                context.Database.EnsureCreated();

                AddInitialData(context);

                DisplayData(context);
            }
        }

        private static void AddInitialData(MyPizzaContext context)
        {
            if (!context.Customers.Any())
            {
                var customer = new Customer { Name = "John Doe", Address = "123 Main St" };
                context.Customers.Add(customer);

                var product1 = new Product { Name = "Pepperoni Pizza", Price = 12.99m };
                var product2 = new Product { Name = "Cheese Pizza", Price = 10.99m };
                context.Products.AddRange(product1, product2);

                var order = new Order { OrderDate = DateTime.Now, Customer = customer };
                context.Orders.Add(order);

                var orderDetail1 = new OrderDetail { Order = order, Product = product1, Quantity = 1 };
                var orderDetail2 = new OrderDetail { Order = order, Product = product2, Quantity = 2 };
                context.OrderDetails.AddRange(orderDetail1, orderDetail2);

                context.SaveChanges();
            }
        }

        private static void DisplayData(MyPizzaContext context)
        {
            var orders = context.Orders
                .Include(o => o.Customer)
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Product)
                .ToList();

            foreach (var order in orders)
            {
                Console.WriteLine($"Order {order.OrderId} for {order.Customer.Name}:");
                foreach (var detail in order.OrderDetails)
                {
                    Console.WriteLine($"  {detail.Quantity} x {detail.Product.Name} @ {detail.Product.Price}");
                }
            }
        }
    }
}
