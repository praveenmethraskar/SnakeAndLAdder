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

            int Check_Snake_or_Ladder = random.Next(0, 2);


            int position = 0;
            if (position == 0)
            {
                Console.WriteLine("single plyer with 0th position");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SnakeAndLadder_Child obj = new SnakeAndLadder_Child();
            obj.display();
        }
    }
}