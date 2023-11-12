using AbstractFactory;
using AbstractFactory.BMW;

CarFactory factory = new BMWFactory();
IEngine engine = factory.CreateEngine();
ITire tire = factory.CreateTire();
IHeadLight headLight = factory.CreateHeadLight();