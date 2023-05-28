

public class Technician : Workplace
{
    public override string ID { get { return "IT-101"; } }

    public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void WorkSchedule(string morning, string night)
    {
        throw new NotImplementedException();
    }
}