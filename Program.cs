using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            Random rnd = new Random();
            int number=rnd.Next(1,7);
            int option=rnd.Next(0,3);
            switch (option)
            {
                case 0:
                    Console.WriteLine("The player stays in the same position");
                    break;
                case 1:
                    Console.WriteLine($"The player moves ahead = {position} + {number}" );
                    break;
                case 2:
                    Console.WriteLine($"The player moves behind = {position} - {number}" );
                    break;
            }
            Console.WriteLine($"player rolls the dice to get a number = {number}");
            Console.WriteLine($"current position of player = {number}");
            Console.ReadLine();
           
        }
    }
}
