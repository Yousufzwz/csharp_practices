// See https://aka.ms/new-console-template for more information
using InterfacePractices;


var person1 = new LibraryMembers();
PrintLibraryID(person1);
var person2 = new LibraryStaff(); 
PrintLibraryID(person2);

void PrintLibraryID(LibraryHall persons)
{
    Console.WriteLine(persons.PersonID);
}

