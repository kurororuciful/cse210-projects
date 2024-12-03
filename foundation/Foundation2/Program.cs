using System;

class Program
{
    static void Main(string[] args)
    {
        Customer myCustomer = new Customer("Eric Buhain", "123 N Mountain View, Los Angeles, CA 90026");
        Address myShippingAddress = new Address("123 N Mountain View, Los Angeles, CA 90026");
        string myID = "December01";
        Order myOrder = new Order(myID, myCustomer, myShippingAddress);
    }

}