using System;

namespace SnakeAndLadders
{
    public class SnakeAndLadder
    {
        
        public void Input()
        {

            Console.WriteLine("Snake and Ladder Game Problem");

            Random random = new Random(); 
            int dice = random.Next(1,7);

         
            Console.WriteLine(" number after die rolled " + dice);
            
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
                Console.WriteLine("single player with 0th position");
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