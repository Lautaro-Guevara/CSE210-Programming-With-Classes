public class Order
{
    Customer _customer;
    List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public int TotalPrice()
    {
        int totalPrice = 0;
        for (int i = 0; i < _products.Count; i++)
        {
            totalPrice = totalPrice + _products[i].TotalCost();
        }

        if (_customer.IsLivingInUSA())
        {
            totalPrice = totalPrice + 5;
        }else
        {
            totalPrice = totalPrice + 35;
        }

        return totalPrice;
    }

    public void Label()
    {
        for (int i = 0; i < _products.Count; i++)
        {
            _products[i].DisplayLabel();
        }
    }

    public void Shipping()
    {
        _customer.Display();
    }
}