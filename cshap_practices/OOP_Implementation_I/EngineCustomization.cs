

public class EngineCustomization : EngineFactory
{
    public int  EngineCount { get; set; }

    public void Engines(EngineFactory counter)
    {
     
        EngineCount++;
    }

    public EngineCustomization(EngineFactory engineName)
    {

    }

}