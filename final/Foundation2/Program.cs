using System;

class Program
{
    static void Main(string[] args)
    {
            Product product1 = new Product("123", "Grapes", 2, 3);
        Product product2 = new Product("321", "Bananas", 7, 4);
        Address address1 = new Address("Santiago del Estero 45 south, SJ ARG 5400", true);
        address1.SetA(true);
        Customer customer1 = new Customer("LAURA PEREZ");
        customer1.SetAddress(address1);
        Order order1 = new Order();
        order1.AddItem(product1);
        order1.AddItem(product2);
        order1.SetCustomer(customer1);
        Console.WriteLine("");
        Console.WriteLine("/////////////////////////////////////////////////////////////////////////");
        order1.DisplayPackingSlip();
        order1.CalculateCost();
        Console.WriteLine("");
        order1.DisplayShippingLabel();
        Console.WriteLine("/////////////////////////////////////////////////////////////////////////");
        Console.WriteLine("");



        Product product3 = new Product("483974", "Milk", 4, 5);
        Product product4 = new Product("321", "Bread", 2, 4);
        Address address2 = new Address("1234 Candido Pujato Santa Fe, Santa Fe Argentina 6582", false);
        address2.SetA(false);
        Customer customer2 = new Customer("JULIAN DAVID");
        customer2.SetAddress(address2);
        Order order2 = new Order();
        order2.AddItem(product3);
        order2.AddItem(product4);
        order2.SetCustomer(customer2);
        order2.DisplayPackingSlip();
        order2.CalculateCost();
        Console.WriteLine("");
        order2.DisplayShippingLabel();

    }
}