using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] celsiusTemps = new double[5];
            double[] fahrenheitTemps = new double[5];
            string[] categories = new string[5];

            Console.WriteLine("Enter 5 temperatures in Celsius:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Temperature {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out celsiusTemps[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write($"Temperature {i + 1}: ");
                }
                
                fahrenheitTemps[i] = celsiusTemps[i] * 9 / 5 + 32;
               
                if (celsiusTemps[i] < 15)
                    categories[i] = "Cold";
                else if (celsiusTemps[i] <= 30)
                    categories[i] = "Warm";
                else
                    categories[i] = "Hot";
            }
            Console.WriteLine("\nResults:");
            Console.WriteLine("Celsius\tFahrenheit\tCategory");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{celsiusTemps[i]:0.0}\t{fahrenheitTemps[i]:0.0}\t\t{categories[i]}");
            }
        }
    }
}
