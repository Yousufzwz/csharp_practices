


Sum("s","a","b","c","d","e","f","g");
Sum("1", "2", "3", "4");
Sum("what", "is", "your", "name?");



void Sum(params string[] nums)
{
    foreach (string s in nums)
    {
        Console.WriteLine(s);
    }
}