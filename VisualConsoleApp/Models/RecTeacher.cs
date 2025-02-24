using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualConsoleApp.Models
{
    record Teacher(string School,
        string Grade,
        string Name,
        string LastName,
        int Age
    ) : RecPerson(Name, LastName, Age)
    {
        // con override significa che sovrascriamo il metodo Print
        public override void Print()
        {
            // base fa riferimento al metodo Print della classe base (RecPerson)
            base.Print();
            Console.WriteLine($"School: {School}, Grade: {Grade}");
        }
    }
}
