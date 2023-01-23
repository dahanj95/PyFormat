using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFormat.Models
{
    public class Header
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public Header(string line)
        {
            string[] split = line.Split(':');
            Name = split[0];
            Value = split[1].TrimStart();
        }

        public override string ToString()
        {
            return $"'{Name}':'{Value}',";
        }
    }
}
