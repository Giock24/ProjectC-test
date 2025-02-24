// See https://aka.ms/new-console-template for more information

// in questo modo si importano tutte le classi del namespace System.Console
// abbiamo dovuto mettere static perchè Console è una classe statica e non un namespace
using System.Diagnostics;
using static System.Console;
// using VisualConsoleApp.Models; // in sintesi se abbiamo bisogno di una classe di un altro namespace dobbiamo importarlo
// usato per l'oggetto Marshal
// using System.Runtime.InteropServices;

namespace VisualConsoleApp
{
    using Models;
    class Program
    {
        // static è un modificatore di accesso che non ha bisogno della creazione
        // di un oggetto di questa classe (Program) per essere eseguito
        static void Main(string[] args)
        {

            /*
                byte: 8 bit, da 0 a 255.
                sbyte: 8 bit, da -128 a 127.
                short: 16 bit, da -32,768 a 32,767.
                ushort: 16 bit, da 0 a 65,535.
                int: 32 bit, da -2,147,483,648 a 2,147,483,647.
                uint: 32 bit, da 0 a 4,294,967,295.
                long: 64 bit, da -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807.
                ulong: 64 bit, da 0 a 18,446,744,073,709,551,615.

                // MORALE DELLA STORIA: non sprecare la memoria usando solo il tipo int se non ti serve
            */

            /*
                C# type/keyword    Approximate range                          Precision     Size     .NET type
                ----------------------------------------------------------------------------------------------
                float              ±1.5 x 10^-45 to ±3.4 x 10^38              ~6-9 digits   4 bytes  System.Single
                double             ±5.0 x 10^-324 to ±1.7 x 10^308            ~15-17 digits 8 bytes  System.Double
                decimal            ±1.0 x 10^-28 to ±7.9228 x 10^28           28-29 digits  16 bytes System.Decimal
            */

            // operatori logici

            /*
                && (Logical AND)
                || (Logical OR)
                ! (Logical NOT)

                    && Truth Table

                a           b           result

                false       false       false
                true        false       false
                false       true        false
                true        true        true


                  || Truth Table


                a           b           result

                false       false       false
                true        false       true
                false       true        true
                true        true        true


             */

            // Records

            Person recPerson1;
            // person1.Age = 30; non si può perchè è già stato inizializzato
            recPerson1 = new Person("Mario", "Rossi", 30);
            var recPerson2 = new Person("Mario", "Rossi", 30);
            var recPerson3 = recPerson2;
            // con i record dopo il punto ci sono gli == e !=

            WriteLine(recPerson1.Equals(recPerson2)); // true
            // ReferenceEquals confronta l'area di memoria
            WriteLine($"area memoria di recPerson1 e recPerson2 uguale? {object.ReferenceEquals(recPerson1, recPerson2)}");
            WriteLine($"area memoria di recPerson2 e recPerson3 uguale? {object.ReferenceEquals(recPerson2, recPerson3)}");
            WriteLine("-------------------------------------------");

            Person2 classPerson1 = new Person2("Mario", "Rossi", 30);
            var classPerson2 = new Person2("Mario", "Rossi", 30);
            var classPerson3 = classPerson2;
            WriteLine(classPerson1.Equals(classPerson2)); // false
            WriteLine(object.ReferenceEquals(classPerson1, classPerson2));
            WriteLine(object.ReferenceEquals(classPerson2, classPerson3));
            //person2.Age = 31; // non puoi modificare il valore dei campi

            // questo accade perchè nei record l'operatore di confronto è sovrascritto
            // in modo tale da comparare le proprietà e non l'area di memoria


        }
    }

}

