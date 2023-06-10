
using AssignmentTask_05;
using MyCodes.Core;



// Nissan is brand name and 200X is model
Vehicle v = new Bus("Nissan", "200X");
Vehicle t = new Truck();
Garage g = new Garage(v);
g.Add(t);
Console.WriteLine($"Total vehicle: {g.TotalVehicleCount}");

