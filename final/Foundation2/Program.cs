// program that creates at least two orders with 
// a 2-3 products each. 

// Call the methods to get the packing label, 
// the shipping label, and the total price 
// of the order, and display the results of 
// these methods.

using System;

class Program 
{
    public static void Main(string[] args)
    {
        // Introduction
        Console.WriteLine("Online Ordering Program");
        Console.WriteLine();
        // order 1
        List<string> order1Customer = new List<string>() {
            "Lara", "123 Main Street", "Anytown", "CA", "USA"};
        List<List<string>> order1Products = new List<List<string>>() {
            new List<string> {"Apples", "2.99", "5", "145"},
            new List<string> {"Bread", "1.99", "2", "218"},
            new List<string> {"Milk", "3.49", "1", "376"},
            new List<string> {"Eggs", "0.20", "12", "529"},
            new List<string> {"Chicken", "5.99", "2", "642"},
            new List<string> {"Pasta", "1.49", "2", "771"}
        };
        Order order1 = new Order(order1Products, order1Customer);
        string shippingLabel1 = order1.ShippingLabel();
        string packingLabel1 = order1.PackingLabel();
        float total1 = order1.TotalCost();


        // order 2
        List<string> order2Customer = new List<string>() {
            "Mario", "456 Oak Avenue", "Springfield", "IL", "USA"};
        List<List<string>> order2Products = new List<List<string>>() {
            new List<string> {"Bananas", "0.99", "6", "278"},
            new List<string> {"Yogurt", "2.29", "4", "498"},
            new List<string> {"Cheese", "3.99", "1", "852"},
            new List<string> {"Tomatoes", "1.79", "4", "185"},
            new List<string> {"Milk", "3.49", "1", "376"},
            new List<string> {"Rice", "2.99", "1", "903"}
        };
        Order order2 = new Order(order2Products, order2Customer);
        string shippingLabel2 = order2.ShippingLabel();
        string packingLabel2 = order2.PackingLabel();
        float total2 = order2.TotalCost();        


        // order 3
        List<string> order3Customer = new List<string>() {
            "Etan", "987 Maple Drive", "Toronto", "ON", "CAN"};
        List<List<string>> order3Products = new List<List<string>>() {
            new List<string> {"Oranges", "3.49", "4", "352"},
            new List<string> {"Lettuce", "1.99", "1", "630"},
            new List<string> {"Cereal", "3.99", "1", "725"},
            new List<string> {"Carrots", "0.99", "2", "492"},
            new List<string> {"Ground Turkey", "3.99", "1", "816"},
            new List<string> {"Potatoes", "2.49", "5", "964"}, 
            new List<string> {"Apples", "2.99", "3", "145"},
        };
        Order order3 = new Order(order3Products, order3Customer);
        string shippingLabel3 = order3.ShippingLabel();
        string packingLabel3 = order3.PackingLabel();
        float total3 = order3.TotalCost();  
    

        // order 4
        List<string> order4Customer = new List<string>() {
            "Chris", "246 Pine Lane", "Sydney", "NSW", "AUS"};
        List<List<string>> order4Products = new List<List<string>>() {
            new List<string> {"Yogurt", "2.29", "4", "498"},
            new List<string> {"Butter", "2.99", "1", "637"},
            new List<string> {"Bread", "1.99", "2", "218"},
            new List<string> {"Milk", "3.49", "1", "376"},
            new List<string> {"Chicken", "5.99", "2", "642"},
            new List<string> {"Eggs", "0.25", "12", "529"}, 
            new List<string> {"Cheese", "3.99", "1", "852"},
        };
        Order order4 = new Order(order4Products, order4Customer);
        string shippingLabel4 = order4.ShippingLabel();
        string packingLabel4 = order4.PackingLabel();
        float total4 = order4.TotalCost();  

        Display(shippingLabel1, packingLabel1, total1);
        Display(shippingLabel2, packingLabel2, total2);
        Display(shippingLabel3, packingLabel3, total3);
        Display(shippingLabel4, packingLabel4, total4);
        
    }

    // A Display method to print each Order
    public static void Display(string shipping, string label, float total) {
        Console.WriteLine($"{shipping}"); 
        Console.WriteLine($"\nProduct List:"); 
        Console.WriteLine($"{label}"); 
        Console.WriteLine($"Total value: {total}"); 
        Console.WriteLine("\n----------------------------------------\n");
    }


}