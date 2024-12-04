class Address
{
    // PRIVATE ATTRIBUTES OR FIELDS
    private string _aStreet;
    private string _aCity;
    private string _aState;
    private string _aZip;
    private string _aUS;
    private bool _aLabel;


    // GETTERS AND SETTERS
    public string streetAddress
    {
        get { return _aStreet ;}
        set { _aStreet = value ;}
    }

    public string city
    {
        get { return _aCity ;}
        set { _aCity = value;}
    }

    public string stateOrProvince
    {
        get { return _aState ;}
        set { _aState = value;}
    }

    public string zip
    {
        get { return _aZip; }
        set { _aZip = value; }
    }
    public string us
    {
        get { return _aUS ;}
        set { _aUS = value ;}
    }

    public bool label
    {
        get { return _aLabel ; }
        set { _aLabel = value ; }
    }


    // CONSTRUCTOR FOR ADDRESS
    public Address(string streetAddress, string city, string stateOrProvince, string zip, string us)
    {
        _aStreet = streetAddress;
        _aCity = city;
        _aState = stateOrProvince;
        _aZip = zip;
        _aUS = us;
        _aLabel = false;
    }


    // CONDITIONS FOR US LABEL CREATION 
    public string GetDisplayAddress()
    {
        if (us.Equals("US", StringComparison.OrdinalIgnoreCase) || 
            us.Equals("USA", StringComparison.CurrentCultureIgnoreCase) || 
            us.Equals("America", StringComparison.CurrentCultureIgnoreCase) || 
            us.Equals("United States", StringComparison.CurrentCultureIgnoreCase) || 
            us.Equals("United States of America", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine($"Since you are in US, You get FREE SHIPPING!!");
                _aLabel = true;
                return $"Your order will be shipped to: {_aStreet}, {_aCity}, {_aState}, {_aZip}, {_aUS}";
            }
        else{
                Console.WriteLine($"Since this is an international order, shipping charges apply.");
                return $"Your order will be shipped to: {_aStreet}, {_aCity}, {_aState}, {_aZip}, {_aUS}";
            }   
    }
}