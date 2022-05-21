using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvenGame
{
    public class Ctverec
    {
        private ConsoleColor barva;
        private int pozicex;
        private int pozicey;

        public Ctverec(int x, int y, ConsoleColor color)
        {
            barva = color;
            pozicex = x;
            pozicey = y;
        }

        public void Vykreslit()
        {
            Console.ForegroundColor = barva;
            Console.SetCursorPosition(pozicex, pozicey);
            Console.Write("▄");           
        }
        public void Pohybdoprava()
        {
            pozicex = pozicex + 1;
            //if (pozicex == -1)
            //{
            //    pozicex == 20;
            //}
        }
        public void Pohybdoleva()
        {
            pozicex = pozicex - 1;
            if (pozicex == -1)
            {
                pozicex = 20;
            }
        }
        public void Pohybdolu()
        {
            pozicey = pozicey + 1;
            //if (pozicey == -1)
            //{
            //    pozicey = 20;
            //}
        }
        public void Pohybnahoru()
        {
            pozicey = pozicey - 1;
            if (pozicey == -1)
            {
                pozicey = 20;
            }
        }
    }
}
