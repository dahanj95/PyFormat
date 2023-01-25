using PyFormat.Models;
using System.Diagnostics;
using System.Text;

Queue<string> lines = new(File.ReadAllLines(".\\headers.txt"));
string template = File.ReadAllText(".\\template.txt");

StringBuilder builder = new();

while (lines.Count > 0)
{
    string line = lines.Dequeue();
    Header header = new(line);

    if (lines.Count == 0)
    {
        builder.Append(header.Formatted);
        break;
    }
       
    builder.AppendLine(header.Formatted);
}

template = template.Replace("%REPLACE_ME%", builder.ToString());
File.WriteAllText(".\\headers_fixed.txt", template);