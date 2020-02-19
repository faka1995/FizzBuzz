using System;

namespace BuzzFizz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesi broj");
            int brojkorisnika = int.Parse(Console.ReadLine());

            for (int broj = 0; broj <= brojkorisnika; broj++)
            {
                if ((broj % 3 == 0) && (broj % 5 == 0))
                {
                    Console.WriteLine(broj + "fizzBuzz");
                }

                else if (broj % 3 == 0)
                {
                    Console.WriteLine(broj + "Fizz");
                }
                else if (broj % 5 == 0)
                {
                    Console.WriteLine(broj + "buzz");
                }
                else
                {
                    Console.WriteLine(broj);
                }

            }
            Console.ReadKey();

        }


    }
}
