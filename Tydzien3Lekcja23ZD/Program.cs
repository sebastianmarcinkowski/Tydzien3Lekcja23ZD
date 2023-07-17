using System;

namespace Tydzien3Lekcja23ZD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var range = 100;
                var number = 0;

                var game = new Game(range);

                Console.WriteLine("Witaj w grze \"Zgadnij liczbę!\"");

                while (!game.GameStatus)
                {
                    Console.Write($"TURA {game.Counter} | Podaj liczbę z przedziału [0 - {range}]: ");

                    while (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > range)
                    {
                        Console.Clear();
                        Console.WriteLine("Podana wartość jest nieprawidłowa, spróbuj jeszcze raz!");
                        Console.Write($"TURA {game.Counter} | Podaj liczbę z przedziału [0 - {range}]: ");
                    }

                    Console.Clear();

                    switch (game.Play(number))
                    {
                        case 0:
                            Console.WriteLine($"Brawo, wylosowana liczba to {number}! Wygrałeś w {game.Counter} turach.");
                            break;
                        case 1:
                            Console.WriteLine("Podana liczba jest za duża, próbuj dalej!");
                            break;
                        case 2:
                            Console.WriteLine("Podana liczba jest za mała, próbuj dalej!");
                            break;
                        default:
                            throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Występił nieoczekiwany błąd, aplikacja zostanie zamknięta!");
            }
            finally
            {
                Console.Write("Aby zamknąć aplikację naciśnij dowolny kawisz...");
                Console.ReadKey();
            }
        }
    }
}
