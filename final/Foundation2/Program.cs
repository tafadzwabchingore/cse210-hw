using System;
using System.Collections.Generic;
 
namespace OrderSystem
{
    // <summary>
    // Represents a product with a name and price.
    // </summary>
    public class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
 
        // <summary>
        // Constructs a new product with the specified name and price.
        //
        // Parameters:
        // - name: The name of the product.
        // - price: The price of the product.
        // </summary>
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
 
    // <summary>
    // Represents a customer with a name and address.
    // </summary>
    public class Customer
    {
        public string Name { get; private set; }
        public Address Address { get; private set; }
 
        // <summary>
        // Constructs a new customer with the specified name and address.
        //
        // Parameters:
        // - name: The name of the customer.
        // - address: The address of the customer.
        // </summary>
        public Customer(string name, Address address)
        {
            Name = name;
            Address = address;
        }
    }
 
    // <summary>
    // Represents an address with street, city, state, and country.
    // </summary>
    public class Address
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
 
        // <summary>
        // Constructs a new address with the specified street, city, state, and country.
        //
        // Parameters:
        // - street: The street of the address.
        // - city: The city of the address.
        // - state: The state of the address.
        // - country: The country of the address.
        // </summary>
        public Address(string street, string city, string state, string country)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
        }
    }
 
    // <summary>
    // Represents an order with a list of products and a customer.
    // </summary>
    public class Order
    {
        public List<Product> Products { get; private set; }
        public Customer Customer { get; private set; }
 
        // <summary>
        // Constructs a new order with the specified products and customer.
        //
        // Parameters:
        // - products: The list of products in the order.
        // - customer: The customer who placed the order.
        // </summary>
        public Order(List<Product> products, Customer customer)
        {
            Products = products;
            Customer = customer;
        }
 
        // <summary>
        // Calculates and returns the total cost of the order.
        //
        // Returns:
        // - A decimal representing the total cost of the order.
        // </summary>
        public decimal CalculateTotalCost()
        {
            decimal totalCost = 0;
 
            // Calculate the sum of the prices of each product.
            foreach (Product product in Products)
            {
                totalCost += product.Price;
            }
 
            // Add the shipping cost based on the customer's location.
            if (Customer.Address.Country == "USA")
            {
                totalCost += 5;
            }
            else
            {
                totalCost += 35;
            }
 
            return totalCost;
        }
 
        // <summary>
        // Generates and returns a string for the packing label of the order.
        //
        // Returns:
        // - A string representing the packing label of the order.
        // </summary>
        public string GeneratePackingLabel()
        {
            string packingLabel = $"Order for: {Customer.Name}\n\nProducts:\n";
 
            // Add the name and price of each product to the packing label.
            foreach (Product product in Products)
            {
                packingLabel += $"{product.Name} - ${product.Price}\n";
            }
 
            return packingLabel;
        }
 
        // <summary>
        // Generates and returns a string for the shipping label of the order.
        //
        // Returns:
        // - A string representing the shipping label of the order.
        // </summary>
        public string GenerateShippingLabel()
        {
            string shippingLabel = $"Shipping Address:\n{Customer.Address.Street}\n{Customer.Address.City}, {Customer.Address.State}\n{Customer.Address.Country}";
 
            return shippingLabel;
        }
    }
 
    // Example program for Order class.
 
    public class Program
    {
        public static void Main()
        {
            // Create some products.
            var product1 = new Product("Product 1", 10);
            var product2 = new Product("Product 2", 20);
            var product3 = new Product("Product 3", 30);
 
            // Create a customer.
            var address = new Address("123 Main St", "City", "State", "USA");
            var customer = new Customer("John Doe", address);
 
            // Create an order with the products and customer.
            var order = new Order(new List<Product> { product1, product2, product3 }, customer);
 
            // Calculate and display the total cost of the order.
            decimal totalCost = order.CalculateTotalCost();
            Console.WriteLine($"Total Cost: ${totalCost}");
 
            // Generate and display the packing label of the order.
            string packingLabel = order.GeneratePackingLabel();
            Console.WriteLine($"Packing Label:\n{packingLabel}");
 
            // Generate and display the shipping label of the order.
            string shippingLabel = order.GenerateShippingLabel();
            Console.WriteLine($"Shipping Label:\n{shippingLabel}");
        }
    }
}