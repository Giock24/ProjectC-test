using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualConsoleApp.Models
{
    // un record può estendere un'altro record ma non una classe
    record RecPerson(string FirstName, string LastName, int Age)
    {
        // con virtual diciamo che il metodo può essere sovrascritto
        virtual public void Print()
        {
            Console.WriteLine($"First Name: {FirstName}, LastName: {LastName}, Age: {Age}");
        }
    }
}
