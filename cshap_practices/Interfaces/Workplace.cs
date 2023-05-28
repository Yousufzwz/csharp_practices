

public abstract class Workplace :IPerson
{
    public abstract string ID { get; } //you can use abstract or virtual

    public abstract string Name { get; set; } //property cause error on Concrete classes. Why?
    public abstract void WorkSchedule(string morning, string night);

    public void Position(string name, string age)
    {
        throw new NotImplementedException();
    }

    public Workplace()
    {

    }
}