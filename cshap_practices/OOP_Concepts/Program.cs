

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
var name1 =person.GetName()+"- "+person.Occupation()+", "+ person.Hobby();
Console.WriteLine(name1);

Products products = new Products();
var name2= products.GetName();
Console.WriteLine(name2);



Electronics newItem1= new Electronics();
newItem1.name = "Tablet";
newItem1.price = 100;

var newItem2 = newItem1.ProductCount(11, 1);
Console.WriteLine(newItem2);

var getProduct = products.GetNames;
Console.WriteLine(getProduct);

Shirt newShirt = new Shirt("Green", "XXL");
Console.WriteLine($"US Polo :{newShirt.ShirtColor}, Shirt Size: {newShirt.ShirtSize}");

Products getPaper= new Products("Yellow", "A4");
Console.WriteLine($"Paper Color: {getPaper.PaperColor}, Paper Size:{getPaper.PaperColor}");



