using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player1position = 0;
            int player2position = 0;
            int count = 0;
            while (player1position < 100 && player2position < 100)
            {
                Console.WriteLine($"Dice count: {count++}");
                Console.WriteLine($"Player1 is currently at position {player1position}. Press Enter to simulate a player's turn.");
                int x1 = Diceroll();
                Console.WriteLine($"Dice gave: {x1}");
                Console.ReadLine();
                Playerposition(ref player1position, x1, count);
                if (player1position == 100)
                {
                    Console.WriteLine("Player1 reached the winning position (100)!");
                    break;
                }
                Console.WriteLine($"Player 2 is currently at position {player2position}. Press Enter to simulate a player's turn.");
                Console.ReadLine();
                int x2 = Diceroll();
                Console.WriteLine($"Dice gave: {x2}");

                Playerposition(ref player2position, x2, count);

                if (player2position == 100)
                {
                    Console.WriteLine("Player 2 reached the winning position (100)!");
                    break; // Player 2 won, exit the loop
                }
            }
            Console.WriteLine("Game Over!");
            Console.ReadLine();
        }
        static void Playerposition(ref int playposition, int x, int c)
        {
            Random rand = new Random();
            int options = rand.Next(0, 3);
            switch (options)
            {
                case 0:
                    Console.WriteLine("Player found a ladder! Move forward.");
                    playposition += x;
                    int a = rand.Next(playposition, 101);
                    Console.WriteLine($"Player moved from {playposition} to {a}");
                    playposition = a;
                    break;
                case 1:
                    Console.WriteLine("Its a Snake, Move backward");
                    playposition += x;
                    int b = rand.Next(2, playposition);
                    Console.WriteLine($"Player moved from {playposition} to {b}.");
                    playposition = b;
                    break;
                case 2:
                    int previous = playposition;
                    playposition += x;
                    Console.WriteLine($"Player moved from {previous} to {playposition}.");
                    break;
            }


            if (playposition < 0)
            {
                playposition = 0;
            }
            else if (playposition == 100)
            {
                Console.WriteLine("Total die count " + c);
                Console.WriteLine("Player reached the winning position (100)!");
            }
            else if (playposition > 100)
            {
                Console.WriteLine($"Player is in the same position {playposition - Diceroll()}!");
            }
        }
        static int Diceroll()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }

    }
}