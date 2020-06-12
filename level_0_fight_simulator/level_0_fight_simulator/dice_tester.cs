using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_0_fight_simulator
{
    class dice_tester
    {
        Random rnd = new Random();

        public void Inicio()
        {
            double tot = 0;

            //for (int k = 0; k < 2; k++) {
                var atr = new double[6];
                double trys = Math.Pow(1, 5);

                for (int i = 0; i < trys; i++)
                    for (short e = 0; e < atr.Length; e++)
                        atr[e] += Roller();


                double t = 0;
                foreach (var x in atr)
                {
                    t += x;
                }

                tot += (int)Math.Abs(((60 - t / trys) * 1000));
                
                Console.WriteLine(
                    $"\nTentativas: {trys}\n" +
                    $"\nFOR = {(atr[0] / trys).ToString("#.##0")}" +
                    $"\nDES = {(atr[1] / trys).ToString("#.##0")}" +
                    $"\nCON = {(atr[2] / trys).ToString("#.##0")}" +
                    $"\nINT = {(atr[3] / trys).ToString("#.##0")}" +
                    $"\nSAB = {(atr[4] / trys).ToString("#.##0")}" +
                    $"\nCAR = {(atr[5] / trys).ToString("#.##0")}" +
                    $"\n\nToTaL = {(t / trys).ToString("#.##0")}"
                    );     
                 
            //}

            Console.WriteLine($"Faltou = {tot}");
        }

        double Roller() {
            double sum = 0;

            double[] m = {
                Rolador(6),
                Rolador(6)
            };

            //m[Array.FindIndex(m, x => x == m.Min())] *= 2;

            //sum += m[Array.FindIndex(m, x => x == m.Max ())];
            //sum += m[Array.FindIndex(m, x => x == m.Min())];

            //sum -= m[Array.FindIndex(m, x => x == m.Max())];
            //sum -= m[Array.FindIndex(m, x => x == m.Min())];

            foreach (var x in m) sum += x;

            //sum /= 2;

            //if (sum > 12) sum = 12;            

            sum += 2;
            //sum -= 5;

            return sum;
        }

        public int Rolador (int lado) {
           return rnd.Next(1, lado+1);
        }
        public double Rolador(int lado, int div)
        {
            return Math.Ceiling((double) rnd.Next(1, lado + 1) / div);
        }
    }
}
