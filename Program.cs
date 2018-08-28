using System;

namespace Loto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ana's Lotery!\nPlease enter a number from 1 to 5.\nGood Luck!\n ");
            
            Player player1 = new Player();
            Console.Write("Player 1: ");
            int numar = int.Parse(Console.ReadLine());
            Console.Write("Player 2: ");
            int numar2 = int.Parse(Console.ReadLine());
            Console.Write("------------------------------------------\n");
            Random rnd = new Random();
            int dice = rnd.Next(1, 5);
            Console.WriteLine("\nThe winning number is: " + dice);
            if (numar == dice)
                Console.WriteLine("\nCongratulations Player 1!!!!!");
            else if (numar2 == dice)
                Console.WriteLine("\nCongratulations Player 2!!!!!");
            else
                Console.WriteLine("\nNo winners :(");
            Console.ReadKey();

        }
            
    }
    }

