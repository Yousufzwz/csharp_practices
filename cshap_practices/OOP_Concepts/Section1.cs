

public class Section1 :Department
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Section1(string name, string description)
    {
        Name = name;
        Description = description;
    }
    public Section1() { }

}