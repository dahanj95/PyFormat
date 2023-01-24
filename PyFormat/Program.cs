using PyFormat.Models;
using System.Text;

string[] lines = File.ReadAllLines(".\\headers.txt");

StringBuilder builder = new();

foreach(string line in lines)
{
    Header header = new(line);
    builder.AppendLine(header.Formatted);
}

File.WriteAllText(".\\headers_fixed.txt", builder.ToString());