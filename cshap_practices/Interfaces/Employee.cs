

public class Employee : Workplace, IPerson
{


    public override string ID { get { return "E-10A"; } }


    public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



    public override void WorkSchedule(string morning, string night)
    {
        throw new NotImplementedException();
    }
}