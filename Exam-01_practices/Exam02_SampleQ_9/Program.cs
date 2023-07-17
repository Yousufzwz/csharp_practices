

using Exam02_SampleQ_9;
using System.Collections;
using System.Text;

string txt = "This.is!a,sample text";
string[] txtWords=txt.Split(new char[] {' ', '.', ',', '?', '!'});

Dictionary<string, int> wordOccurences = new Dictionary<string, int>();  
foreach (string word in txtWords)
{
    if(wordOccurences.ContainsKey(word))
    {
        wordOccurences[word]++;
    }

    else
    {
        wordOccurences.Add(word, 1);
    }
}

foreach(KeyValuePair<string, int> pair in wordOccurences)
{
    Console.WriteLine("Word:{0}, Occurences:{1}", pair, pair.Value);
}

Console.WriteLine();

Hashtable personData= new Hashtable();
personData.Add("Name", "Esa");
personData.Add("Age", "34");

foreach(var key in personData.Keys)
{
    Console.WriteLine("Key :"+ key );
    Console.WriteLine("Value :"+ personData[key]);
}

Console.WriteLine();

List<string> fruits= new List<string>();
fruits.Add("Banana");
fruits.Add("Mango");
fruits.Add("Pineapple");

Console.WriteLine(fruits[0]);
Console.WriteLine(fruits[1]);
Console.WriteLine(fruits[2]);


fruits[1] = "Watermelon";
fruits.RemoveAt(0);

foreach(var fru in fruits)
{
    Console.WriteLine(fru);
}

bool containsPA = fruits.Contains("Pineapple");
Console.WriteLine(containsPA);

int counter=fruits.Count;
Console.WriteLine(counter);


Console.WriteLine();

ArrayList numbers= new ArrayList();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);


numbers[2] = 1000;
numbers.Remove(1);

foreach(var n in numbers)
{
    Console.WriteLine(n);
}

bool contains30 = numbers.Contains(300);
Console.WriteLine(contains30);  

int count = numbers.Count;
Console.WriteLine(count);  

numbers.Clear();

count = numbers.Count;
Console.WriteLine(count);




Console.WriteLine();
var person = GetPerson();
Console.WriteLine(person.name);
Console.WriteLine(person.country);

(string name, int age, string country)GetPerson()
{
    return ("Mahmud", 29, "Bangladesh");
}


Console.WriteLine();

MyTests<string, int> sampleData = new MyTests<string, int>("Zakariya", 29);
sampleData.PrintTuple();

Console.WriteLine();

SortedDictionary<int, string> fruitsData=new SortedDictionary<int, string>();
fruitsData.Add(2, "Jackfruit");
fruitsData.Add(3, "Berry");
fruitsData.Add(1, "Lichi");

foreach(var pair in fruitsData)
{
    Console.WriteLine("Key: "+ pair.Key+ " Value: "+ pair.Value);
}

fruitsData.Remove(2);
Console.WriteLine("After removing an item:");

foreach(var pair in fruitsData)
{
    Console.WriteLine("Key: " + pair.Key + " Value: " + pair.Value);

}

bool reallyContains=fruitsData.ContainsKey(3);
Console.WriteLine("Contains key : "+reallyContains);

bool containsFruit = fruitsData.ContainsValue("Mango");
Console.WriteLine("this fruit contained here: "+ containsFruit);

fruitsData.Clear();
foreach (var p in fruitsData)
{
    Console.WriteLine("Key: " + p.Key + " Value: " + p.Value );

}

Console.WriteLine();


var productData = (price: 180, name: "US-POLO-Shirt", id: 9881);
Console.WriteLine(productData.name);
Console.WriteLine(productData.price);
productData.name = "H&M-Shirt";
productData.price = 170;
Console.WriteLine(productData.name);
Console.WriteLine(productData.price);

var res = PD(2);
Console.WriteLine(res);

(int price, string name, int id) PD(int id)
{
    if(id==2)
    {
        return (2, "Mask", 10090);
    }
    return (0, "Unknown", 0);
}


Console.WriteLine();

StringBuilder strings= new StringBuilder();
strings.Append("Hi, ");
strings.Append("where!!");

strings.Insert(3, "I am");
strings.Replace("where!!", "here.");
strings.Remove(0, 3);

Console.WriteLine(strings);
