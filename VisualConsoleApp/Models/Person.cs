using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualConsoleApp.Models
{
    record class Person(string Name, string LastName, int Age); // i dati sono immutabili

    // questa classe cerca di simulare il comportamento di un record
    class Person2(string name, string lastName, int age)
    {
        // mettendo init si può inizializzare solo una volta
        public string Name { get; init; } = name;
        public string LastName { get; init; } = lastName;
        public int Age { get; init; } = age;

    }
}
