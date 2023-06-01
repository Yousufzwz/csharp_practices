



public class PriceRange
{
    public double price;

    public virtual double Price(double percentage)
    {
        if (percentage >= 0 && percentage <=100)
        {
            return price * percentage /100.00;
        }
        else
            throw new InvalidOperationException();
    }

    public string Tags()
    {
        return "XXL";
    }
}