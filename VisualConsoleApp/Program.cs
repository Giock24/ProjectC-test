// See https://aka.ms/new-console-template for more information

namespace variables 
{
    class Program
    {   
        static void Main(string[] args)
        {
            
            string firstName;
            string lastName;
            string age;

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

