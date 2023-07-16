

using System.Text;

int texts = int.Parse(Console.ReadLine());

StringBuilder buildText= new StringBuilder();
buildText.AppendLine("<body>");

for(int i = 0; i < texts; i++)
{
    string words= Console.ReadLine();   
    buildText.AppendLine($"<h1>{words}</h1>");
}

buildText.AppendLine("</body>");
Console.WriteLine(buildText);