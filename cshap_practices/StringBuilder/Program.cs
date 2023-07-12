

using System.Text;

StringBuilder textBuilder= new StringBuilder();
textBuilder.Append("Water needed").Replace('e', 'i');
string x= textBuilder.ToString();
Console.WriteLine(textBuilder);

for(int i = 0; i<x.Length; i++)
{
    textBuilder[i] = 'k';
}
Console.WriteLine(textBuilder);
