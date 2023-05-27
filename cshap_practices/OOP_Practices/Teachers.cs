

class Teachers : Courses
{
    public override double GetDiscount(double price)
    {
        throw new NotImplementedException();
    }
    

    public Teachers(double price) : base(price)
    {
    }
}