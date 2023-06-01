



public class Department
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int id;
    public int room;
    public string FacultyName { get; set; }
    public int ID
    {
        get
        {
            if (id < 0)
                return 0;
            else
                return id;
        }
        set
        {
            if (value >= 0)
                id = value;
            else
                throw new Exception("Number cannot be negative!");


        }
    }

        public int RoomNumbers
    { get 
        { if (room < 0)
                return 0;
               else return room;
        }

        set
        {
            if (value >= 0)
                room = value;
            else
                throw new Exception("Number cannot be negative!");


        }

    }

    public Department(string faculty)
    {
        FacultyName = faculty;
    }

    public Department(string name, string description)
    {
        Name = name;
        Description = description;
    }
    public Department() { }


}
