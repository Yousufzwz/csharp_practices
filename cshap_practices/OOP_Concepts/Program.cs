

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
Shirt newShirt2 = new Shirt("White", "XL");
Shirt newShirt3 = new Shirt("Black", "M");

Console.WriteLine($"US Polo :{newShirt.ShirtColor}, Shirt Size: {newShirt.ShirtSize}");
Console.WriteLine($"PUMA :{newShirt2.ShirtColor}, Shirt Size: {newShirt2.ShirtSize}");
Console.WriteLine($"A&Q :{newShirt3.ShirtColor}, Shirt Size: {newShirt3.ShirtSize}");


Products getPaper = new Products("Yellow", "A4");
Console.WriteLine($"Paper Color: {getPaper.PaperColor}, Paper Size:{getPaper.PaperColor}");

Console.WriteLine($"Total Production: {Shirt.productionCount}");

Categories.ProductSerial();

AllCategory categoryType = new SelectedCategory();
categoryType.Name("9ZA19911", "UI909US");
Console.WriteLine(((SelectedCategory)categoryType).GetCategory());



Department department = new Section1();

Department department2 = new Section1("A","010");

Department department3 = new Section2("B", "25A");

department3.ID = 2000;
department2.RoomNumbers = 100;
department.FacultyName = "CS-Engineering";
Console.WriteLine(department.FacultyName);