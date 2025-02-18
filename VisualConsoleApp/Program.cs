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

            
            // "var" viene messo per fare si che il compilatore capisca che è un tipo di dato esistente
            var firstName = "Gianluca";
            string lastName = "Palmieri";
            string age = "25";
            var bio = 
            """
                Lorem ipsum dolor sit amet, consectetur 
                adipiscing elit \n, sed do  \t eiusmod "tempor" incididunt \t ut labore et dolore magna aliqua.
            """;

            bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit \n, sed do eiusmod \"tempor\" incididunt \t ut labore et dolore magna aliqua.";
            // Caratteri speciali nelle stringhe
            // \n = new line va a capo
            // \t = tab mette uno spazio
            // mettendo tre virgolette si può scrivere una stringa su più righe senza usare il +
            // la stringa viene considerata come verbatim string (vuol dire così com'è scritta)
            // ATTENZIONE: se dentro la stringa ci sono 3 virgolette, bisogna iniziare la stringa con 4 virgolette
            
            // Ricorda, ogni metodo che modifica una stringa, restituisce una nuova stringa
            firstName = firstName.ToLower();

            WriteLine("Enter your first name: ");
            firstName = ReadLine().Trim(); // Trim è un metodo che elimina gli spazi bianchi all'inizio e alla fine della stringa

            WriteLine("Enter your last name: ");
            lastName = ReadLine().Trim();

            WriteLine($"Parameters: {firstName}: {firstName.Length}, {lastName}: {lastName.Length}");
            
            
        }

    }

}

