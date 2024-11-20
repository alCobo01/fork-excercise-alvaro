using System;
using Fork;

namespace RefactorFork
{
    public class Program
    {

        public static void Main()
        {
            //Constantes
            const string TextOne = "Escull introduir la quantitat de nombres entre 15 i 100: ";
            const string ForEachNumber = "Introdueix el seguent número, {0}: ";
            const string Product = "El producte de cada un dels números es: ";
            const string MissatgeError = "Format incorrecte";

            int numInputs = 0;
            bool isInRange = false;

            while (!isInRange)
            {
                Console.WriteLine(TextOne);
                try
                {
                    numInputs = Convert.ToInt32(Console.ReadLine());
                    isInRange = ForkMethods.ValidateInRange(numInputs, 15, 100);
                }
                catch (FormatException)
                {
                    Console.WriteLine(MissatgeError);
                }
            }
            int[] numsToCatch = new int[numInputs];

            isInRange = false;
            // recompte de numeros introduits per l'usuari
            for (int i = 0; i < numInputs; i++)
            {
                while (!isInRange)
                {
                    Console.WriteLine(ForEachNumber, i + 1);
                    try
                    {
                        numsToCatch[i] = Convert.ToInt32(Console.ReadLine());
                        isInRange = ForkMethods.ValidateInRange(numsToCatch[i], 15, 100);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(MissatgeError);
                    }
                }
            }

            Console.WriteLine(Product + ForkMethods.CalculateProduct(numsToCatch));
        }
    }
}

