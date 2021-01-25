using System;

namespace Celciusomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            {
                double fahrenheit;

                double celcius = 20;
                Console.WriteLine("Celcius: " + celcius);

                fahrenheit = (celcius = 20) * 1.8 + 32;
                Console.WriteLine("Fahrenheit: " + fahrenheit);
            }
        }
    }
}
