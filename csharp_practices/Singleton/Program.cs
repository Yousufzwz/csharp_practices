using Singleton;

Logger logger1 = Logger.CreateLogger();
Logger logger2 = Logger.CreateLogger();

if(logger1==logger2)
{
    Console.WriteLine("Same Instance");
}
