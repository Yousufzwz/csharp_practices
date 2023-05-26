

public class Shirt
{
    public string ShirtColor { get; private set; }
    public string ShirtSize { get; private set; }
     
    public Shirt(string shirtColor, string shirtSize)
    {
        ShirtColor = shirtColor;
        ShirtSize = shirtSize;

    }
}
