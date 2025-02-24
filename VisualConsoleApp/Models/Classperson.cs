using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualConsoleApp.Models
{
    class Classperson
    {
        public string Name { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; } = 0;

        public void Deconstruct(out string name, out string lastName, out int age)
        {
            name = Name;
            lastName = LastName;
            age = Age;
        }

    }
}
