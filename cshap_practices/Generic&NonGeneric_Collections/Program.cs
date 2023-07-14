

using System.Collections;
using System.Collections.Specialized;

List<string> name=new List<string>();
name.Add("Ahmad");
name.Add("Zakariya");
name.Remove("Zakariya");

ArrayList newName = new ArrayList();
newName.Add(1);
newName.Add("Rakib");
newName.Add(false);

Dictionary<int, string> person=new Dictionary<int, string>();
person.Add(1, "A");
person[1] = "B";

NameValueCollection settings=new NameValueCollection();
settings.Add("id", "name");

HashSet<string> names = new HashSet<string>();
names.Add("A");
names.Add("A");

Hashtable id=new Hashtable();
id.Add(1, 2);
id.Add(3, 3);

SortedDictionary<string, string> sortedItems=new SortedDictionary<string, string>();
sortedItems.Add("C", "101");
sortedItems.Add("A", "102");

foreach(var item in sortedItems)
{
    Console.WriteLine(item);
}

SortedSet<string> items= new SortedSet<string>();
items.Add("A");
items.Add("A");
items.Add("X");

foreach(var i in items)
{
    Console.WriteLine(i);
}