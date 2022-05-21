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
            Console.WriteLine("Start 2P");
            Console.WriteLine("Nastavení");
            Console.WriteLine("Konec");

            string odpoved = Console.ReadLine();
            if (odpoved == "start")
            {
                Console.Clear();
                Game hra = new Game();
                hra.Play();               
                //Game mojeHra = new Game()
                //mojeHra.Start();
            }
            else if (odpoved == "nastaveni")
            {
                Console.Clear();
                Nastaveni obtiznost = new Nastaveni();
                obtiznost.Moznosti();                
            }    
            else if (odpoved == "konec")
            {
                Console.WriteLine("Mějte se hezky, nashledanou");
                Console.ReadKey();
                return;
            }
            else if (odpoved == "2p")
            {
                Console.Clear();
                MultGame hraprodva = new MultGame();
                hraprodva.Play2();
            }
            else
            {
                Console.WriteLine("Špatná volba");
                Console.ReadKey();
            }               
            //u easy to bude X červených X šedých X modrých
            //u medium to bude -%-
            //u hard -%-
            //u overkill -%-        
        }
    }
}
