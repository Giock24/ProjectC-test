﻿// See https://aka.ms/new-console-template for more information

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
            var recPerson1 = new RecPerson("Peter", "Parker", 25);
            recPerson1.Print();

            // destrutturare un record significa proprio scomporlo
            // quindi nel caso volessimo ottenere i valori di un record
            // in variabili differenti, si può fare in questo modo:
            var (name, lastName, age) = recPerson1; // destrutturazione in una tupla
            WriteLine(name); WriteLine(lastName); WriteLine(age);
            // i record hanno già di base la funzione Deconstruct


            var teacher = new Teacher("University", "second", "Mirko", "Viroli", 55);
            teacher.Print();

            // object initializer
            var classPerson = new Classperson {
                Name = "Peter",
                LastName = "Parker",
                Age = 25
            };

            var (name1, lastName1, age1) = classPerson;
            WriteLine(name1); WriteLine(lastName1); WriteLine(age1);



        }
    }

}

