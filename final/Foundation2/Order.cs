using System;

class Order
{
 private List<Product> _products = new List<Product>();
    private Customer Customer;
    private int _shippingCost = 0;
    private int _totalCost = 0;
    private int _subtotal = 0;

    public Order()
    {

    }

    public void CalculateCost()
    {
        foreach (Product product in _products)
        {
            _subtotal = _subtotal + product.GetTotalPrice();
        }
        _totalCost = _subtotal;
        Console.WriteLine($"Cost without shipping: ${_totalCost}");
        CalculateShipping();
        _totalCost = _totalCost + _shippingCost;
        Console.WriteLine($"Shipping charge: ${_shippingCost}");
        Console.WriteLine($"Total Cost: ${_totalCost}");
        
    }


    public void CalculateShipping() 
    {
        if (Customer.GetA() == true)
        {
            _shippingCost = 5;
        }
        else {
            _shippingCost = 35;
        }
        
    }


    public void SetCustomer(Customer customer)
    {
        Customer = customer;
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        Console.WriteLine($"Shipping Address: {Customer.GetAddress()}");
    }

    public void DisplayPackingSlip()
    {
        Console.WriteLine($"Customer Name: {Customer.GetCustName()}");
        Console.WriteLine("Packing Label");
        Console.WriteLine("");
        foreach (Product product in _products)
        {
            product.DisplayItem();
            Console.WriteLine("");
        }
    }

    public void AddItem(Product product)
    {
        _products.Add(product);
    }

}