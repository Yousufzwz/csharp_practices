

public class Section2:Department
{
    public string Name { get; set; }
    public string Description { get; set; }
  

    public Section2(string name, string description)
    {
        Name = name;
        Description = description;
    }
}