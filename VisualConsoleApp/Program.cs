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
            
            int myInt = 42;
            // da l'errore perchè stiamo cercando di convertire un tipo di dato più grande in uno più piccolo
            //byte myByte = myInt; // errore: non si può fare un cast implicito da int a byte
            byte myByte = (byte) myInt; // cast esplicito da int a uint
            myByte = 45;
            WriteLine($"myByte: {myByte}, myInt: {myInt}");

            // la conversione non da errore perchè stiamo convertendo un tipo di dato più piccolo in uno più grande
            long myLong = myInt; // cast implicito da int a long

        }

    }

}

