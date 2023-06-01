

public class GarmentProducts:PriceRange
{
    public override double Price(double percentage)
    {
        //base.Price(percentage); //this case first call the parent then do operation in child

        if ( percentage >= 0 && percentage <=45)
        {
            return price * percentage / 100.00;
        }
        else
            throw new InvalidOperationException();
    }

    public new string Tags()
    {
        return "M";
    }

    public void TagType()
    {
        Console.WriteLine(Tags()); 
    }

}