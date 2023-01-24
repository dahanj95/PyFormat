using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PyFormat.Models
{
    public class Header
    {
        public string Formatted { get; private set; }

        public Header(string line)
        {
            Formatted = Regex.Replace(line, @"(.*):\s(.*)", "'$1':'$2'");
        }
    }
}
