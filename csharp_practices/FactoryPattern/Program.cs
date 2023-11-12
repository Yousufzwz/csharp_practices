

using FactoryPattern;

CarFactory factory1 = new BMWFactory();

ICar car1 = factory1.Create("black", "W900", 3000);