class Order 
{

    // PRIVATE ATTRIBUTES OR FIELDS
    private string _oID;
    private string _oCustomer;
    private string _oShipAddress;
    private List<Product> _products;


    // GETTERS AND SETTERS FOR WRAPPER PROPERTY
    public string orderID
    {
        get { return _oID;}
        set { _oID = value;}
    }

    public string customer
    {
        get { return _oCustomer;}
        set { _oCustomer = value;}
    }

    public string shippingAddress
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
    public Order(string orderID, string customer, string shippingAddress)
    {
        _oID = orderID;
        _oCustomer = customer;
        _oShipAddress = shippingAddress;
        _products = new List<Product>();
    }


    // METHOD FOR ORDER CALCULATION
    public int CalculateOrder()
    {
        int orderValue = 0;

        foreach (Product product in _products)
        {
            orderValue += product.TotalValue();            
        }
        
        return orderValue;
    }

}