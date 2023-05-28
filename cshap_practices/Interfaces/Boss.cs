

public class Boss : Workplace
{
    

    public override string ID
    {
        get
        { return "B-1A"; }
     }

    public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void WorkSchedule(string morning, string night)
    {
        throw new NotImplementedException();
    }
}