

EngineFactory newEngine = new CarEngine("B-09XA11","BMW");
EngineFactory newEngine2= new BusEngine();
EngineCustomization engineCustomization = new EngineCustomization(newEngine);
engineCustomization.Engines(newEngine2);
