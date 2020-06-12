using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_0_fight_simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                new dice_tester().Inicio();
                //new Battle().Inicio();
                Console.ReadLine();
            }
        }
    }
}
