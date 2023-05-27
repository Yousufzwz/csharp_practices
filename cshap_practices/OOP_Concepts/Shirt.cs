

public class Shirt
{
    public string ShirtColor { get; private set; }
    public string ShirtSize { get; private set; }
    public readonly string brandName;
    public static int productionCount;
     
    public Shirt(string shirtColor, string shirtSize)
    {
        ShirtColor = shirtColor;
        ShirtSize = shirtSize;
        productionCount++;
    }

    public Shirt()
    {
        brandName = "H&M";
    }

    public Shirt(string newName)
    {
        brandName = "POLO";
    }

    public string BrandChange()
    {

        throw new NotImplementedException();
    }

    
   

}
