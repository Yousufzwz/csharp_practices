

using Exam02_SampleQ_9;
using System.Collections;

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