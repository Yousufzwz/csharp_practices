using Generics_Practices;

Coordinates<string, double> position = new Coordinates<string, double>();
position.X = "100";
position.Y = 21.20;

NewCoordinates<int> firstCoordinate = new NewCoordinates<int>();
firstCoordinate.x = 100;
firstCoordinate.y = 200;
firstCoordinate.z = 300;

NewCoordinates<double> secondCoordinate = new NewCoordinates<double>();
secondCoordinate.x = 100.15;
secondCoordinate.y = 200.89;
secondCoordinate.z = 300.26;

OldCoordinate a = new OldCoordinate();
Console.WriteLine(a);

CarFactory<Mercedes> car1 = new CarFactory<Mercedes>(new Mercedes());
CarFactory<Mitshubishi> car2= new CarFactory<Mitshubishi> ( new Mitshubishi() );

car1.CheckCar();
car2.CheckCar();

Mercedes m = car1.CopyCar;
Mitshubishi ms = car2.CopyCar;  

