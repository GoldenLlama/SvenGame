using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvenGame
{
    public class Game
    {
        public void Play() //ty ses tady snažil o hru pro dva? :D
        {
            Ctverec hrac1 = new Ctverec(4,4,ConsoleColor.Green);
            //Ctverec hrac2 = new Ctverec(5,10,ConsoleColor.Red);

            while (true)
            {
                hrac1.Vykreslit();
                //hrac2.Vykreslit();

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
                if (myKey.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Menu mojeMenu = new Menu();
                    mojeMenu.Run();
                    return;
                }
            }
        }
    }
}
