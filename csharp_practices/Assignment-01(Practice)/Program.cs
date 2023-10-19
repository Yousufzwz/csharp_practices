using Assignment_01_Practice_;







//first Test case======
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("````````First test case``````````");

House house = new House
{
    Rooms = new List<Room>
    {
        new Room
        {
            RoomNumber = "200",
            Windows = new List<Window>
            {
                new Window { Width = 200, Height = 300 },
                new Window { Width = 44, Height = 88 }
            }
        },
        new Room
        {
            RoomNumber = "300",
            Windows = new List<Window>
            {
                new Window { Width = 100, Height = 200 },
                new Window { Width = 350, Height = 500 }
            }
        }
    }
};

Building building = new Building();

SimpleMapper mapper2 = new SimpleMapper();
mapper2.Copy(house, building);

foreach (var room in building.Rooms)
{
    Console.WriteLine("Room Number: " + room.RoomNumber);
    Console.WriteLine("Windows:");
    foreach (var window in room.Windows)
    {
        Console.WriteLine("Width: " + window.Width);
        Console.WriteLine("Height: " + window.Height);
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("````````Second test case``````````");


//second test case=========


Company sourceCompany1 = new Company
{
    CompanyName = "ABC Corporation",
    CompanyCEO = new CEO
    {
        CEOName = "Mahmud",
        Subsidiaries = new List<Company>
                {
                    new Company
                    {
                        CompanyName = "XYZ Inc.",
                        CompanyCEO = new CEO
                        {
                            CEOName = "Ahmad"
                        }
                    }
                }
    },
    Departments = new List<Department>
            {
                new Department
                {
                    DepartmentName = "HR",
                    Employees = new List<Employee>
                    {
                        new Employee
                        {
                            EmployeeName = "Idris",
                            Projects = new List<Project>
                            {
                                new Project
                                {
                                    ProjectName = "Employee Training",
                                    Tasks = new List<MyTask>
                                    {
                                        new MyTask
                                        {
                                            TaskName = "Create Training Materials",
                                            Priority = 1
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
    }
};

Company destinationCompany = new Company();

SimpleMapper mapper3 = new SimpleMapper();
mapper3.Copy(sourceCompany1, destinationCompany);

Console.WriteLine($"Company Name: {destinationCompany.CompanyName}");
Console.WriteLine($"CEO Name:  {destinationCompany.CompanyCEO.CEOName}");
Console.WriteLine("Subsidiaries:");
foreach (var subsidiary in destinationCompany.CompanyCEO.Subsidiaries)
{
    Console.WriteLine("- " + subsidiary.CompanyName);
    Console.WriteLine("  - CEO: " + subsidiary.CompanyCEO.CEOName);
}

Console.WriteLine("Departments:");
foreach (var department in destinationCompany.Departments)
{
    Console.WriteLine("- " + department.DepartmentName);
    Console.WriteLine("  Employees:");
    foreach (var employee in department.Employees)
    {
        Console.WriteLine("  - " + employee.EmployeeName);
        Console.WriteLine("    Projects:");
        foreach (var project in employee.Projects)
        {
            Console.WriteLine("    - " + project.ProjectName);
            Console.WriteLine("      Tasks:");
            foreach (var task in project.Tasks)
            {
                Console.WriteLine("      - " + task.TaskName);
                Console.WriteLine("        Priority: " + task.Priority);
            }
        }
    }
}

Console.WriteLine("===========");


Company sourceCompany = new Company
{
    CompanyName = "ABC Corporation",
    HRDepartment = new Department
    {
        DepartmentName = "HR",
        Employees = new List<Employee>
        {
            new Employee
            {
                EmployeeName = "Idris",
                Projects = new List<Project>
                {
                    new Project
                    {
                        ProjectName = "Employee Training",
                        Tasks = new List<MyTask>
                        {
                            new MyTask
                            {
                                TaskName = "Create Training Materials",
                                Priority = 1
                            }
                        }
                    }
                }
            }
        }
    },
    ITDepartment = new Department
    {
        DepartmentName = "IT",
        Employees = new List<Employee>
        {
            new Employee
            {
                EmployeeName = "Alice",
                Projects = new List<Project>
                {
                    new Project
                    {
                        ProjectName = "Software Development",
                        Tasks = new List<MyTask>
                        {
                            new MyTask
                            {
                                TaskName = "Code Review",
                                Priority = 2
                            }
                        }
                    }
                }
            }
        }
    },
    Employees = new List<Employee>
    {
        new Employee
        {
            EmployeeName = "Bob",
            Projects = new List<Project>
            {
                new Project
                {
                    ProjectName = "Research",
                    Tasks = new List<MyTask>
                    {
                        new MyTask
                        {
                            TaskName = "Data Analysis",
                            Priority = 3
                        }
                    }
                }
            }
        }
    }
};

Company destinationCompany1 = new Company();

SimpleMapper mapper = new SimpleMapper();
mapper.Copy(sourceCompany, destinationCompany1);

// Now you can inspect the destinationCompany object to verify the data mapping.
Console.WriteLine($"Destination Company Name: {destinationCompany1.CompanyName}");
Console.WriteLine("HR Department:");
Console.WriteLine($"Department Name: {destinationCompany1.HRDepartment.DepartmentName}");
Console.WriteLine("HR Employees:");
foreach (var employee in destinationCompany1.HRDepartment.Employees)
{
    Console.WriteLine($"- Employee Name: {employee.EmployeeName}");
    Console.WriteLine("  Employee Projects:");
    foreach (var project in employee.Projects)
    {
        Console.WriteLine($"  - Project Name: {project.ProjectName}");
        Console.WriteLine("    Project Tasks:");
        foreach (var task in project.Tasks)
        {
            Console.WriteLine($"    - Task Name: {task.TaskName}");
            Console.WriteLine($"      Task Priority: {task.Priority}");
        }
    }
}

Console.WriteLine("IT Department:");
Console.WriteLine($"Department Name: {destinationCompany1.ITDepartment.DepartmentName}");
Console.WriteLine("IT Employees:");
foreach (var employee in destinationCompany1.ITDepartment.Employees)
{
    Console.WriteLine($"- Employee Name: {employee.EmployeeName}");
    Console.WriteLine("  Employee Projects:");
    foreach (var project in employee.Projects)
    {
        Console.WriteLine($"  - Project Name: {project.ProjectName}");
        Console.WriteLine("    Project Tasks:");
        foreach (var task in project.Tasks)
        {
            Console.WriteLine($"    - Task Name: {task.TaskName}");
            Console.WriteLine($"      Task Priority: {task.Priority}");
        }
    }
}

Console.WriteLine("Company Employees:");
foreach (var employee in destinationCompany1.Employees)
{
    Console.WriteLine($"- Employee Name: {employee.EmployeeName}");
    Console.WriteLine("  Employee Projects:");
    foreach (var project in employee.Projects)
    {
        Console.WriteLine($"  - Project Name: {project.ProjectName}");
        Console.WriteLine("    Project Tasks:");
        foreach (var task in project.Tasks)
        {
            Console.WriteLine($"    - Task Name: {task.TaskName}");
            Console.WriteLine($"      Task Priority: {task.Priority}");
        }
    }
}

Console.WriteLine();
Console.WriteLine("1111111111111111111");


   // Create a source library with data
        var sourceLibrary = new Library
        {
            Name = "Public Library",
            Branches = new List<LibraryBranch>
            {
                new LibraryBranch
                {
                    BranchName = "Main Branch",
                    Shelves = new List<Shelf>
                    {
                        new Shelf
                        {
                            ShelfNumber = "A",
                            Books = new List<Book>
                            {
                                new Book { Title = "Book 1", Author = "Author 1", YearPublished = 2020 },
                                new Book { Title = "Book 2", Author = "Author 2", YearPublished = 2019 }
                            }
                        },
                        new Shelf
                        {
                            ShelfNumber = "B",
                            Books = new List<Book>
                            {
                                new Book { Title = "Book 3", Author = "Author 3", YearPublished = 2018 },
                                new Book { Title = "Book 4", Author = "Author 4", YearPublished = 2017 }
                            }
                        }
                    }
                },
                new LibraryBranch
                {
                    BranchName = "Second Branch",
                    Shelves = new List<Shelf>
                    {
                        new Shelf
                        {
                            ShelfNumber = "X",
                            Books = new List<Book>
                            {
                                new Book { Title = "Book 5", Author = "Author 5", YearPublished = 2016 },
                                new Book { Title = "Book 6", Author = "Author 6", YearPublished = 2015 }
                            }
                        }
                    }
                }
            }
        };

        // Create an empty destination library
        var destinationLibrary = new DestinationLibrary();

        // Use your SimpleMapper to copy data from source to destination
        SimpleMapper mapper4 = new SimpleMapper();
        mapper4.Copy(sourceLibrary, destinationLibrary);

        // Print the destination library's data to verify the mapping
        Console.WriteLine($"Destination Library Name: {destinationLibrary.Name}");
        Console.WriteLine("Destination Library Branches:");

        if (destinationLibrary.Branches != null)
        {
            foreach (var branch in destinationLibrary.Branches)
            {
                Console.WriteLine($"Branch Name: {branch.BranchName}");
                Console.WriteLine("Shelves:");

                if (branch.Shelves != null)
                {
                    foreach (var shelf in branch.Shelves)
                    {
                        Console.WriteLine($"Shelf Number: {shelf.ShelfNumber}");
                        Console.WriteLine("Books:");

                        if (shelf.Books != null)
                        {
                            foreach (var book in shelf.Books)
                            {
                                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year Published: {book.YearPublished}");
                            }
                        }
                    }
                }
            }
        }


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("````````Third test case``````````");


// Create a source school with data
var sourceSchool = new School
{
    Name = "Sample School",
    Classrooms = new List<Classroom>
            {
                new Classroom
                {
                    RoomNumber = "101",
                    Students = new List<Student>
                    {
                        new Student { Name = "Alice" },
                        new Student { Name = "Bob" }
                    }
                },
                new Classroom
                {
                    RoomNumber = "102",
                    Students = new List<Student>
                    {
                        new Student { Name = "Charlie" },
                        new Student { Name = "David" }
                    }
                }
            }
};

// Create an empty destination school
var destinationSchool = new DestinationSchool();

// Use your SimpleMapper to copy data from source to destination
SimpleMapper mapper5 = new SimpleMapper();
mapper5.Copy(sourceSchool, destinationSchool);

// Print the destination school's data to verify the mapping
Console.WriteLine($"Destination School Name: {destinationSchool.Name}");
Console.WriteLine("Destination Classrooms:");
foreach (var classroom in destinationSchool.Classrooms)
{
    Console.WriteLine($"Room Number: {classroom.RoomNumber}");
    Console.WriteLine("Students:");
    foreach (var student in classroom.Students)
    {
        Console.WriteLine($"Student Name: {student.Name}");
    }
}


Console.WriteLine();
Console.WriteLine("`````Fourth test case``````");

//// Create a source person with data
//var sourcePerson = new Person
//{
//    Name = "John Doe",
//    Age = 30,
//    Address = new Address
//    {
//        Street = "123 Main St",
//        City = "Anytown",
//        State = "CA"
//    },
//    PhoneNumbers = new List<PhoneNumber>
//    {
//        new PhoneNumber { Number = "123-456-7890" }
//    }
//};

//// Create an empty destination person
//var destinationPerson = new DestinationPerson();

//// Use your SimpleMapper to copy data from source to destination
//SimpleMapper mapper6 = new SimpleMapper();
//mapper6.Copy(sourcePerson, destinationPerson);

//// Print the destination person's data to verify the mapping
//Console.WriteLine($"Full Name: {destinationPerson.FullName}");
//Console.WriteLine($"Current Age: {destinationPerson.CurrentAge}");
//if (destinationPerson.CurrentAddress != null)
//{
//    Console.WriteLine("Current Address:");
//    Console.WriteLine($"Street: {destinationPerson.CurrentAddress.Street}");
//    Console.WriteLine($"City: {destinationPerson.CurrentAddress.City}");
//    Console.WriteLine($"State: {destinationPerson.CurrentAddress.State}");
//}
//else
//{
//    Console.WriteLine("Current Address is null");
//}

//if (destinationPerson.ContactNumbers != null)
//{
//    Console.WriteLine("Contact Numbers:");
//    foreach (var phoneNumber in destinationPerson.ContactNumbers)
//    {
//        Console.WriteLine($"Number: {phoneNumber.Number}");
//        Console.WriteLine($"Type: {phoneNumber.PhoneType}");
//    }
//}
//else
//{
//    Console.WriteLine("Contact Numbers are null");
//}


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("````````Fourth test case``````````");

// Create a source person with data
var sourcePerson = new Person
{
    Name = "John Doe",
    Age = 30,
    Address = new Address
    {
        Street = "123 Main St",
        City = "Anytown",
        State = "CA"
    },
    PhoneNumbers = new List<PhoneNumber>
    {
        new PhoneNumber { Number = "123-456-7890" }
    }
};

// Create an empty destination person
var destinationPerson = new Person();

// Use your SimpleMapper to copy data from source to destination
SimpleMapper mapper6 = new SimpleMapper();
mapper6.Copy(sourcePerson, destinationPerson);

// Print the destination person's data to verify the mapping
Console.WriteLine($"Full Name: {destinationPerson.Name}");
Console.WriteLine($"Current Age: {destinationPerson.Age}");
Console.WriteLine("Current Address:");

