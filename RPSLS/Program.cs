using System;
using RPSLS.Classes;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Player kevin = new Player("Kevin");
            kevin.DisplayGestures();
            kevin.ChooseGestures();
            
            
        }
    }
}
