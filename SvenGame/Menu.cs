using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvenGame
{
    public class Menu
    {
        public void Run()
        {
            Console.WriteLine("Start");
            Console.WriteLine("Nastavení");
            Console.WriteLine("Konec");

            string odpoved = Console.ReadLine();
            if (odpoved == "start")
            {
                Console.Clear();
                Game hra = new Game();
                hra.Play();

                //string restart = "ano"
                //while (restart == "ano")
                //Console.něcocospustíhru
                //Game mojeHra = new Game()
                //mojeHra.Start();
            }
            else if (odpoved == "nastaveni")
            {
                Console.WriteLine("Overkill");
                Console.WriteLine("Hard");
                Console.WriteLine("Medium");
                Console.WriteLine("Easy");
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
            }
            else if (odpoved == "konec")
            {
                Console.WriteLine("Mějte se hezky, nashledanou");
                Console.ReadKey();
                return;
            }
            else
                Console.WriteLine("Špatná volba");
            Console.ReadKey();

            //u easy to bude X červených X šedých X modrých
            //u medium to bude -%-
            //u hard -%-
            //u overkill -%-        }
        }
    }
}
