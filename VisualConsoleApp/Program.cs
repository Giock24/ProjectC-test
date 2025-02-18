// See https://aka.ms/new-console-template for more information

// in questo modo si importano tutte le classi del namespace System.Console
// abbiamo dovuto mettere static perchè Console è una classe statica e non un namespace
using static System.Console;

namespace variables 
{
    class Program
    {   
        static void Main(string[] args)
        {

            
            char myKey = 'A'; // char occupa meno byte di una stringa
            char myChar = '\u0061'; // carattere unicode
            WriteLine(++myChar);

            for(char c = 'A'; c <= 'Z'; c++)
            {
                Write($"{c} ");
            }
            WriteLine("\n");

            WriteLine("Please, press A, W, S or Z\n");
            // ReadKey() è un metodo che ritorna più informazioni sul tasto premuto dall'utente
            char k = ReadKey().KeyChar;
            WriteLine($"You pressed {k}");

            string command = k.ToString();
            
        }

    }

}

