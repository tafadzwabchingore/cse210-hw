using System;
using System.Collections.Generic;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a customer
            Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
            Customer customer1 = new Customer("John Smith", address1);

            // Create a product
            Product product1 = new Product("Widget", "W123", 10.00, 2);

            // Create an order
            List<Product> products1 = new List<Product>();
            products1.Add(product1);
            Order order1 = new Order(customer1, products1);

            // Display packing label, shipping label, and total price of the order
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: {order1.GetTotalPrice():C}");
        }
    }

    class Product
    {
        private string name;
        private string productId;
        private double price;
        private int quantity;

        public Product(string name, string productId, double price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public double GetPrice()
        {
            return price * quantity;
        }
    }

    class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public bool IsInUSA()
        {
            return address.IsInUSA();
        }
    }

    class Address
    {
        private string streetAddress;
        private string city;
        private string stateProvince;
        private string country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateProvince = stateProvince;
            this.country = country;
        }

        public bool IsInUSA()
        {
            return country == "USA";
        }

        public string GetFullAddress()
        {
            return $"{streetAddress}\n{city}, {stateProvince} {country}";
        }
    }

    class Order
    {
        private Customer customer;
        private List<Product> products;

        public Order(Customer customer, List<Product> products)
        {
            this.customer = customer;
            this.products = products;
        }

        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.GetPrice();
            }
            if (customer.IsInUSA())
            {
                totalPrice += 5.00;
            }
            else
            {
                totalPrice += 35.00;
            }
            return totalPrice;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "";
            foreach (Product product in products)
            {
                packingLabel += $"{product.name} ({product.productId})\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            string shippingLabel = $"{customer.GetFullAddress()}\n{customer.name}";
            return shippingLabel;
        }
    }
}
// Tafadzwa Chingore
