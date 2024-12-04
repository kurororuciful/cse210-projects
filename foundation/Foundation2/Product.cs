class Product
{

    // PRIVATE ATTRIBUTES OR FIELDS
    private string _pName;
    private string _pID;
    private double _pPrice;
    private int _pQty;


    // GETTERS AND SETTERS FOR WRAPPER PROPERTY
    public string productName
    {
        get { return _pName;}
        set { _pName = value;}
    }

    public string productID
    {
        get { return _pID;}
        set { _pID = value;}
    }

    public double productPrice
    {
        get { return _pPrice;}
        set { _pPrice = value;}
    }

    public int productQuantity
    {
        get { return _pQty;}
        set { _pQty = value;}
    }


    // CONSTRUCTOR FOR INVENTORY LIST 
    public Product (string productName, string productID, double productPrice, int productQuantity)
    {
        _pName = productName;
        _pID = productID;
        _pPrice = productPrice;
        _pQty = productQuantity;
    }


    // METHOD FOR PRODUCT ORDER
    public double TotalValue()
    {
        double totalValue = productPrice * productQuantity;
        return totalValue;
    }

}