// See https://aka.ms/new-console-template for more information
using System;
using Microsoft.VisualBasic.FileIO;

namespace MyApplication
{
  class Cat
  {
    public int CatSpeed;

    static void Sleep()
    {
        Console.WriteLine("The kitty went to sleep.");
    }

    public void Eat(Mouse myMouse)
    {
        CatSpeed = Lucky.GetLuck();
        Console.WriteLine($"Cat Speed: {CatSpeed}");

        if (!myMouse.Escape(CatSpeed))
        {
            Console.WriteLine("The kitty is full.");
            Sleep();
        }
    }
  }

  class Mouse
    {
        public int MouseSpeed;

        public bool Escape(int CatSpeed)
        {
            MouseSpeed = Lucky.GetLuck();
            Console.WriteLine($"Mouse Speed: {MouseSpeed}");


            if (CatSpeed < MouseSpeed)
            {
                Console.WriteLine("The mouse was too fast for the cat!");
            }
            else if (CatSpeed == MouseSpeed)
            {
                Console.WriteLine("Both animals are quick. The chase goes on and on.");
                Escape(CatSpeed); // Recursive function to call Escape until one is faster
            }
            else
            {
                Console.WriteLine("The mouse wasn't fast enough to escape...");
            }
            return CatSpeed < MouseSpeed;
        }
    }

    class Lucky
    {
        public static int GetLuck()
        {
            Random luck = new();
            return luck.Next(10);
        }
    }

    class MainProgram
    {
        static void Main(string[] args)
        {
            Cat myCat = new();
            Mouse myMouse = new();

            myCat.Eat(myMouse);
        } 
    }
}