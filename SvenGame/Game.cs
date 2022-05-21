using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvenGame
{
    public class Game
    {
        //public void Play()
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.Write("▄");


        //    while(true)
        //    {
        //        ConsoleKeyInfo myKey = Console.ReadKey();
        //        Console.Clear();
        //        Console.Write("▄");
        //        if (myKey.Key == ConsoleKey.DownArrow)
        //        {                   
        //            Console.SetCursorPosition(0, 1);
        //            Console.ForegroundColor = ConsoleColor.Red;
        //        }
        //        if (myKey.Key == ConsoleKey.UpArrow)
        //        {                    
        //            Console.SetCursorPosition(0, 0);
        //            Console.ForegroundColor = ConsoleColor.Green;
        //        }
        //        if (myKey.Key == ConsoleKey.LeftArrow)
        //        {                   
        //            Console.SetCursorPosition(0, 0);
        //            Console.ForegroundColor = ConsoleColor.Green;
        //        }
        //        if (myKey.Key == ConsoleKey.RightArrow)
        //        {                  
        //            Console.SetCursorPosition(1, 0);
        //            Console.ForegroundColor = ConsoleColor.Green;
        //        }

        //    }

        //}

        public void Play()
        {
            Ctverec hrac1 = new Ctverec(4,4,ConsoleColor.Green);
            Ctverec hrac2 = new Ctverec(5,10,ConsoleColor.Red);

            while (true)
            {
                hrac1.Vykreslit();
                hrac2.Vykreslit();

                ConsoleKeyInfo myKey = Console.ReadKey();
                Console.Clear();

                if (myKey.Key == ConsoleKey.RightArrow)
                {
                    hrac1.Pohybdoprava();
                }
                if (myKey.Key == ConsoleKey.LeftArrow)
                {
                    hrac1.Pohybdoleva();
                }
                if (myKey.Key == ConsoleKey.DownArrow)
                {
                    hrac1.Pohybdolu();
                }
                if (myKey.Key == ConsoleKey.UpArrow)
                {
                    hrac1.Pohybnahoru();
                }

            }

        }
    }
}
