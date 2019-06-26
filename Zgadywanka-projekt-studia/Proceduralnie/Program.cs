using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proceduralnie
{
    class Program
    {
        private static readonly Random random = new Random();
        private static int number = 0;

        static void Main(string[] args)
        {

            bool newGame = true;

            while (true)
            {
                if (newGame)
                {
                    number = GetRandom();
                    newGame = false;
                }

                string rate;
                try
                {
                    rate = Rate(Load());
                }
                catch(OperationCanceledException)
                {
                    Exit();
                    return;
                }

                if (rate == "trafiono")
                {
                    Console.WriteLine("Udało Ci się trafić liczbę");
                    if (Continue())
                    {
                        newGame = true;
                        Console.Clear();
                    }
                    else Exit();
                }
                else Console.WriteLine(rate);

            }
        }

        static int GetRandom()
        {
            int s = Load("Podaj dolny zakres: ");
            int e = Load("Podaj górny zakres: ");

            if (s > e)
            {
                int tempS = s;
                s = e;
                e = tempS;
            }
            return random.Next(s, e + 1);
        }

        static int Load(string prompt = "Podaj liczbę (lub x aby zakończyć)")
        {
            Console.WriteLine(prompt);
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "p") throw new OperationCanceledException("Gracz zakończył grę");

                try
                {
                    return Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("To nie jest liczba! Spróbuj jeszcze raz.");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba nie mieści się w rejestrze!");
                    continue;
                }
            }
        }

        static string Rate(int proposition)
        {
            if (proposition == number) return "trafiono";
            else return proposition < number ? "Za mało" : "Za dużo";
        }

        static void Exit()
        {
            Console.WriteLine("Zakończono grę. \nNaciśnij dowolny klawisz aby wyjść");
            Console.ReadKey();
        }

        static bool Continue(string prompt = "Czy chcesz zagrać jeszcze raz? (T/N)")
        {
            Console.WriteLine(prompt);
            while (true)
            {
                char yesNo = Char.ToLower(Console.ReadKey().KeyChar);
                if (yesNo == 't') return true;
                else if (yesNo == 'n') return false;
            }
        }
    }
}
