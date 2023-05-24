

Products selectedProduct = new Products();

selectedProduct.name = "LAPTOP";
selectedProduct.price = 300;

string mainProduct = selectedProduct.ProductName();
Console.WriteLine(mainProduct);

var purchasingPrice = "$"+ selectedProduct.Sum() * selectedProduct.price; 
Console.WriteLine(purchasingPrice);

var firstCall = selectedProduct.ProductCount(10.1, 10);
Console.WriteLine(firstCall);

Person person = new Person();
var name1 =person.GetName();
Console.WriteLine(name1);

Products products = new Products();
var name2= products.GetName();
Console.WriteLine(name2);
