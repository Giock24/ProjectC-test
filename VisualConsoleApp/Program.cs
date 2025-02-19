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

            float floatNumber = 3.14159265355897932384626f;
            double doubleNumber = 3.14159265355897932384626;
            decimal decimalNumber = 3.14159265355897932384626m; // se c'è qualcosa relativo alla banca usare decimal

            // In questo modo vedo quando tronca il numero
            WriteLine($"float: {floatNumber} \ndouble: {doubleNumber} \ndecimal: {decimalNumber}");

            doubleNumber = floatNumber;
            decimalNumber = (decimal)floatNumber; // la conversione implicita potrebbe portare a una perdita di precisione

            decimal result = decimalNumber + 300;
            WriteLine(result);

            double result2 = doubleNumber + 300;
            WriteLine(result2);

            float result3 = floatNumber + 300;
            WriteLine(result3);

            result = 400 + (decimal)doubleNumber;

            // posso fare operazione tra interi e float o double o decimal; però non posso fare operazioni tra i numeri mobili perchè hanno una precisione diversa

            // vediamo come funzionano le uguaglianze con float, double e decimal (SOLO CON I DECIMAL SI è POSSIBILE FARLO)
            float val1 = 0.1f, val2 = 0.2f;
            WriteLine($"valore somma non messo in variabile: {val1 + val2}");
            float res = val1 + val2;
            WriteLine(res == 0.3f);

            double val3 = 0.1, val4 = 0.2;
            WriteLine($"valore somma non messo in variabile: {val3 + val4}" );
            double res2 = val1 + val2;
            WriteLine(res2 == 0.3);

            decimal val5 = 0.1m, val6 = 0.2m;
            WriteLine($"valore somma non messo in variabile: {val5 + val6}");
            decimal res3 = val5 + val6;
            WriteLine(res3 == 0.3m);



        }

    }

}

