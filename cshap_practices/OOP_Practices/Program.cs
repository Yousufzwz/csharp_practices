// See https://aka.ms/new-console-template for more 




using System.Xml;

Product product = new Smartphone("A","1101");
Product product1 = new Headphones();
ProductStore store = new ProductStore(product);


ProductManager productManager = new Product1();
ProductManager manager = new Product1("a",1);
ProductManager manager1 = new Product2("b", 21);
manager1.Barcode = 3110;
manager.Price = 100;
productManager.Name = "Monitor";
Console.WriteLine(productManager.Name);


Customers customer1 = new Normal();
Customers customer2 = new Normal("Zakariya", "N-101");
Customers customer3 = new Premium("Mahmud", "P-100");
customer3.ShoppingBudget = 10000;
customer2.Cost = 1000;
customer1.Name = "Ahmad";
Console.WriteLine(customer1.Name);



var takenProducts = new GarmentProducts();
takenProducts.price = 5000;

var withDiscountPrice = takenProducts.Price(10);
Console.WriteLine(withDiscountPrice);

PriceRange priceRange =new GarmentProducts();
var newDiscount = takenProducts.Price(20);
Console.WriteLine(newDiscount);


PriceRange priceRange2 =new PriceRange();
priceRange2.price = 4000;
var newDiscount2 = priceRange2.Price(100);
Console.WriteLine(newDiscount2);

Console.WriteLine(priceRange.Tags());

((GarmentProducts)(priceRange)).TagType();
