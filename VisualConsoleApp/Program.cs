// See https://aka.ms/new-console-template for more information

// in questo modo si importano tutte le classi del namespace System.Console
// abbiamo dovuto mettere static perchè Console è una classe statica e non un namespace
using static System.Console;
// usato per l'oggetto Marshal
// using System.Runtime.InteropServices;

namespace variables 
{
    class Program
    {   
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

            int a = 12, b = 13;
            int result = a + b;
            WriteLine(result);
            result = a - b;
            WriteLine(result);
            result = a * b;
            WriteLine(result);
            result = a / b;
            WriteLine(result);

            decimal result2 = (decimal)a / (decimal)b; // ricorda che se non metti il cast il risultato sarà un intero
            WriteLine($"risultato di divisione con decimal: {result2}");

            int remineder = b%a;
            WriteLine($"resto della divisione: {remineder}");
            Clear(); // pulisce la console

            a++; // incrementa di 1
            WriteLine(a);
            a--; // decrementa di 1
            WriteLine(a);

            ++a; // incrementa di 1
            WriteLine(a);
            --a; // decrementa di 1
            WriteLine(a);

            // la differenza tra i due è che se metti l'operatore prima dell'operando, incrementa o decrementa prima di fare l'operazione
            // quindi nel primo caso 'a' viene ritornato e poi si incrementa
            // mentre invece nel secondo caso 'a' viene incrementato e poi ritornato

            
            WriteLine($"A value is {a}");
            int x = a++;
            WriteLine($"A value is {a}, x value is {x}");
            x = ++a;
            WriteLine($"A value is {a}, x value is {x}");


        }

    }

}

