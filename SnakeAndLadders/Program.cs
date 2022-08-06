using System;

namespace SnakeAndLadders
{
    public class SnakeAndLadder
    {
        
        public void Input()
        {

            Console.WriteLine("Snake and Ladder Game Problem");


            
        }
        
    }

    public class SnakeAndLadder_Child : SnakeAndLadder
    {
        public void display()
        {
            Random random = new Random();

            int position = 0;

            //int count = 0;
            int n = 100;

            while (position < n)
            {
                int Check_Snake_or_Ladder = random.Next(0, 3);

                int dice = random.Next(1, 7);

                 
                    if (Check_Snake_or_Ladder == 1)
                    {
                        Console.WriteLine("Ladder");
                        position = position + dice;
                        Console.WriteLine("postion moved " +position);
                        if(position > n)
                        {
                            position = position - dice;
                        }
                        else if(position == 100)
                        {
                        Console.WriteLine("Player has won");
                        }
                    }
                    else if (Check_Snake_or_Ladder == 2)
                    {
                        Console.WriteLine("Snake");

                        position = position - dice;
                        Console.WriteLine("Position drops " + position);
                        if (position < 0)
                        {
                            position = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No play");
                    }
               
 

               // count++;

            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SnakeAndLadder_Child obj = new SnakeAndLadder_Child();
            obj.Input();
            obj.display();

        }
    }
}