


public class Products
{
   int  a, b;
   public string name;
   public double price;
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


}