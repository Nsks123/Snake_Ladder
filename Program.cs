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
            Random rnd = new Random();
            int position = 0;
            int last_position = 100;
            int count = 0;
            
            while(position<last_position) 
            {
                int number = rnd.Next(1, 7);
                count+=1;
                int option = rnd.Next(0, 3);

                switch (option)
                {
                    case 0:
                        Console.WriteLine($"The player stays in the same position = {position}");
                        
                        break;
                    case 1:
                        
                        if (position + number <= last_position)
                        {
                            position +=number; 
                        }
                        else
                        {
                            position = last_position;
                        }
                       
                        Console.WriteLine($"The player moves ahead = {position}");
                        
                        break;
                    case 2:
                        position -= number;
                        if (position < 0)
                        {
                            position = 0;

                        }

                        Console.WriteLine($"The player moves behind = {position}");
                        break;

                        

                }
                Console.WriteLine($"Number of times the dice was roll to win = {count} times");
                Console.WriteLine($"position of the player after every dice roll = {position}");

            }
           
            Console.ReadLine();
           
        }
    }
}
