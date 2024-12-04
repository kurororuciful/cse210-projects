using System;

class Program
{
    static void Main(string[] args)
    {
        
        // ############## Customer 1 ##############

        // CREATING CUSTOMER OBJECT 
        Customer myCustomer = new Customer("Cynthia Patag", "123 N Mountain View, Los Angeles, CA 90026 US");
        
        // CREATING ADDRESS OBJECT 
        Address myShippingAddress = new Address("123 N Mountain View", "Los Angeles", "CA", "90026", "US");
        
        // CREATING ORDER OBJECT 
        Order myOrder = new Order(myCustomer, myShippingAddress);

        // CREATING PRODUCT OBJECT
        Product soap = new Product("Soap", "SG123", 1.25, 367);
        Product toothpaste = new Product("Toothpaste", "CG456", 0.75, 425);

        // ADDING PRODUCTS TO ORDER BATCH
        myOrder.productOrderList.Add(soap);
        myOrder.productOrderList.Add(toothpaste);

        // DISPLAY ORDER NUMBER
        Console.WriteLine($"\n\nOrder Number: " + myOrder.orderID);

        // DISPLAY CUSTOMER
        Console.WriteLine($"Customer Name and Billing Address: {myOrder.customer.customerName}, \n {myOrder.customer.customerBillingAddress}");

        // DISPLAY ADDRESS
        Console.WriteLine($"{myOrder.shippingAddress.GetDisplayAddress()}");

        // DISPLAY ORDER
        Console.WriteLine($"\nProduct Name, ID, Unit Price, and Quantity: " );
        foreach (Product product in myOrder.productOrderList)
        {
            Console.WriteLine($"{product.productName}, {product.productID}, {product.productPrice}, {product.productQuantity} ");
        }
        
        // DISPLAY THE TOTAL ORDER VALUE
        Console.WriteLine($"\nTotal Order Value: $ " + myOrder.CalculateOrder());



        // ############## Customer 2 ##############

        // CREATING CUSTOMER OBJECT 
        Customer myCustomer2 = new Customer("Joey Marquez", "354 A Chico St., Cembo, Fort Bonifactio, Makati City, 1214 PH");
        
        // CREATING ADDRESS OBJECT 
        Address myShippingAddress2 = new Address("345 A Chico St., Cembo", "Fort Bonifactio", "Makati City", "1214", "PH");
        
        // CREATING ORDER OBJECT 
        Order myOrder2 = new Order(myCustomer2, myShippingAddress2);

        // CREATING PRODUCT OBJECT
        Product sleipnir = new Product("KG-6 Sleipnir", "KP364X", 7.25, 6);
        Product loneshadow = new Product("Lone Shadow", "KM-143", 3.5, 25);
        Product gashinsentai = new Product("Gasshin Sentai Mechandermax", "15822L", 6.75, 5);

        // ADDING PRODUCTS TO ORDER BATCH
        myOrder2.productOrderList.Add(sleipnir);
        myOrder2.productOrderList.Add(loneshadow);
        myOrder2.productOrderList.Add(gashinsentai);

        // DISPLAY ORDER NUMBER
        Console.WriteLine($"\n\nOrder Number: " + myOrder2.orderID);

        // DISPLAY CUSTOMER
        Console.WriteLine($"Customer Name and Billing Address: {myOrder2.customer.customerName}, \n {myOrder2.customer.customerBillingAddress}");

        // DISPLAY ADDRESS
        Console.WriteLine($"{myOrder2.shippingAddress.GetDisplayAddress()}");

        // DISPLAY ORDER
        Console.WriteLine($"\nProduct Name, ID, Unit Price, and Quantity: " );
        foreach (Product product in myOrder2.productOrderList)
        {
            Console.WriteLine($"{product.productName}, {product.productID}, {product.productPrice}, {product.productQuantity} ");
        }
        
        // DISPLAY THE TOTAL ORDER VALUE
        Console.WriteLine($"\nTotal Order Value: $ " + myOrder2.CalculateOrder());
    }

}