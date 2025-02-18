// See https://aka.ms/new-console-template for more information

namespace variables 
{
    class Program
    {   
        static void Main(string[] args)
        {
            
            // "var" viene messo per fare si che il compilatore capisca che è un tipo di dato esistente
            var firstName = String.Empty;
            string lastName;
            string age;
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
            

            Console.WriteLine("Enter your name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = Console.ReadLine(); 

            // con concatenazione di stringhe usando l'operatore +
            //string message = "These are the data you entered: " + firstName + ", " + lastName + ", " + age + "";
            // con interpolazione di stringhe
            string message = $"Your name is {firstName}, your last name is {lastName} and you are {age} years old"; // questo è il miglior metodo da usare
            // con formattazione di stringhe, i numeri definiscono i segnaposto
            message = String.Format("Your name is {0}, your last name is {1} and you are {2} years old", firstName, lastName, age);

            Console.WriteLine(message);
            
            
        }

    }

}

