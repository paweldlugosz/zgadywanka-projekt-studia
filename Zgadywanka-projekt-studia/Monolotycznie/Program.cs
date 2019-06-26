using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monolotycznie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            Console.WriteLine("Wylosowałem pewną liczbę od 1 do 100. Odgadnij ;)");
            bool correctAnswer = false;

            while (!correctAnswer)
            {
                Console.WriteLine("Podaj liczbę lub wpisz 'p' aby poddać się");
                string input = Console.ReadLine();
                if (input.ToLower() == "p")
                {
                    Console.WriteLine($"Poddałeś się :/ Wylosowana liczba to {number}.");
                    Console.WriteLine("Naciśnij dowolny klawisz aby wyjść");
                    Console.ReadKey();
                    break;
                }

                int proposition = 0;
                try
                {
                    proposition = Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("To nie jest liczba");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba nie mieści się w rejestrze");
                    continue;
                }

                if (proposition < number) Console.WriteLine("Za mało");
                else if (proposition > number) Console.WriteLine("Za dużo");
                else
                {
                    Console.WriteLine("Trafiono");
                    Console.WriteLine("Naciśnij dowolny klawisz aby wyjść");
                    Console.ReadKey();
                    correctAnswer = true;
                }
            }
        }
    }
}
