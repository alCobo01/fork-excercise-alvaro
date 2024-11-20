using System;
namespace RefactorFork
{
    public class Program
    {

        public static bool ValidateInRange(int num, int min, int max)
        {
            return (num >= min && num <= max);
        }

        public static int CalculateProduct(int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }

        public static void Main()
        {
            //Constantes
            const string TextOne = "Escull introduir la quantitat de nombres entre 15 i 100: ";
            const string ForEachNumber = "Introdueix el seguent número, {0}: ";
            const string Product = "El producte de cada un dels números es: ";
            const string MissatgeError = "Format incorrecte";

            int numInputs = 0, productNumbers;
            bool isInRange = false;

            while (!isInRange)
            {
                Console.WriteLine(TextOne);
                try
                {
                    numInputs = Convert.ToInt32(Console.ReadLine());
                    isInRange = ValidateInRange(numInputs, 15, 100);
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
                        isInRange = ValidateInRange(numsToCatch[i], 15, 100);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(MissatgeError);
                    }
                }
            }

            Console.WriteLine(Product + CalculateProduct(numsToCatch));
        }
    }
}

