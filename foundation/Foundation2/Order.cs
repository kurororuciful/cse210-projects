class Order 
{

    // PRIVATE ATTRIBUTES OR FIELDS
    private string _oID;
    private Customer _oCustomer;
    private Address _oShipAddress;
    private List<Product> _products;


    // GETTERS AND SETTERS FOR WRAPPER PROPERTY
    public string orderID
    {
        get { return _oID;}
        set { _oID = generateOrderNumber();}
    }

    public Customer customer
    {
        get { return _oCustomer;}
        set { _oCustomer = value;}
    }

    public Address shippingAddress
    {
        get { return _oShipAddress;}
        set { _oShipAddress = value;}
    }

    public List<Product> productOrderList
    {
        get { return _products;}
        set { _products = value;}
    }


    // CONSTRUCTOR FOR ORDERS
    public Order(Customer customer, Address shippingAddress)
    {
        _oID = generateOrderNumber();
        _oCustomer = customer;
        _oShipAddress = shippingAddress;
        _products = new List<Product>();
    }


    // METHOD FOR ORDER CALCULATION
    public double CalculateOrder()
    {
        double orderValue = 0;

        foreach (Product product in _products)
        {
            orderValue += product.TotalValue();            
        }
        
        return orderValue;
    }


    // METHOD FOR AUTO GENERATING ORDER NUMBER
    public string generateOrderNumber()
    {
        DateTime now = DateTime.Now;
        string orderNumber = now.ToString("yyyyMMddHHmm");
        return orderNumber;
    }

}