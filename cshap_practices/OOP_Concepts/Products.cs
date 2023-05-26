


public class Products
{
   public string name;
   public double price;
    int quantity;
    string model = "BW1";
    string brand="lenovo";

   public int Sum( )
    {
       int x = 2;
       int  y = 2;
        int z;
        return  z = x+y;
    }

    public string ProductName()
    {
        return name.ToLower();
    }

    double DiscountPrice()
    {
        return Math.Round(price);
    }

   
    public double ProductCount(double x, double y)
    {
       
        return  x+y;
    }

    public int ProductCount(int x, int y)
    {

        return x - y;
    }

    public Products()
    {
        //Empty constructor
    }

    public string GetName()
    {
        return model+" "+brand;
    }

    public string GetNames
    {
        get { return model + " " + brand; }
    }

    
    public string PaperColor { get; private set; }
    public string PaperShape { get; private set; }


     public Products(string paperColor, string paperShape)
    {
        PaperColor = paperColor;
        PaperShape = paperShape;
    }


  



}