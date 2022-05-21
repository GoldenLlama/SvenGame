using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvenGame
{
    class Nastaveni
    {
        public void Moznosti()
        {
            Console.WriteLine("Overkill");
            Console.WriteLine("Hard");
            Console.WriteLine("Medium");
            Console.WriteLine("Easy");
            Console.WriteLine("Zpět");
                
            string obtiznost = Console.ReadLine();
            if (obtiznost == "hard")
            {
                //Console.Give -0 speed
                //Console.Spawn 30x20
            }

            if (obtiznost == "medium")
            {
                //Console.Give -10 Speed
                //Console.spawn 30x20
            }

            if (obtiznost == "easy")
            {
                //Console.Give -20 speed
                //Console.Spawn 30x20
            }

            if (obtiznost == "overkill")
            {
                //Console.Give 10 speed
                //Console.Spawn 50x40
            }
            if (obtiznost == "zpet")
            {
                Console.Clear();
                Menu mojeMenu = new Menu();
                mojeMenu.Run();
            }
        }
    }    
}
