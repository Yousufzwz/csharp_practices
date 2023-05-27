

class Students : Courses
{
    public Students(double price) : base(price)
    {
    }

    public override double GetDiscount(double price)
    {
        throw new NotImplementedException();
    }
}