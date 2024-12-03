class Customer
{
    // PRIVATE ATTRIBUTES OR FIELDS
    private string _cName;
    private string _cAddress;


    // GETTERS AND SETTERS
    public string customerName
    {
        get { return _cName;}
        set { _cName = value;}
    }

    public string customerAddress
    {
        get { return _cAddress;}
        set { _cAddress = value;}
    }


    // CONSTRUCTOR FOR CUSTOMER
    public Customer(string customerName, string customerAddress)
    {
        _cName = customerName;
        _cAddress = customerAddress;
    }

}