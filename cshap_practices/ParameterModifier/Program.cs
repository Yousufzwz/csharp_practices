

using ParameterModifier;

TestClass num=new TestClass();
int a = num.Add("100-A", 2, 1, 3, 3, 3, 33);


VariousText("a","b","c","d","e");

void VariousText(params string[] texts)
{
    foreach (string text in texts)
    {
        Console.WriteLine(text);
    }
}

