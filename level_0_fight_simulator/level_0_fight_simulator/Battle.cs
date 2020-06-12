using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_0_fight_simulator
{
    class Battle
    {
        public void Inicio()
        {

            Criatura[] cs =
            {
                new Criatura("Level 0", 4, 10, 2, 4, 0),
                new Criatura("Plebeu", 4, 10, 2, 4, 0)
            };

            int l1 = 0, l2 = 0, g1, g2;
            int vezes = 1000;
            for (int i = 0; i < vezes; i++)
            {
                foreach (var x in cs)
                {
                    x.PV = x.pvMax;
                }

                do
                {
                    g1 = new dice_tester().Rolador(20) + cs[0].Ini;
                    g2 = new dice_tester().Rolador(20) + cs[1].Ini;
                } while (g1 == g2);

                int turnos = 0;
                int turn = g1 > g2 ? 1 : 0;

                do
                {
                    turnos++;
                    short ataca, recebe;
                    bool acerto = false;

                    if (turn == 1)
                    {
                        ataca = 0;
                        recebe = 1;
                        if (cs[0].BA >= cs[1].CA)
                            acerto = true;
                        turn = 0;
                    }
                    else
                    {
                        ataca = 1;
                        recebe = 0;
                        if (cs[1].BA >= cs[0].CA)
                            acerto = true;
                        turn = 1;
                    }

                    if (acerto == true)
                    {
                        int dn = cs[ataca].Dano;
                        cs[recebe].PV -= dn;
                        //Console.WriteLine($"{cs[ataca].Nome} infligiu -{dn} em {cs[recebe].Nome} que está com {cs[recebe].PV} PV\t| Turno {turnos}");
                    }
                    else
                    {
                        //Console.WriteLine($"{cs[ataca].Nome} errou o golpe em {cs[recebe].Nome}\t| Turno {turnos}");
                    }

                } while (cs[0].PV > 0 && cs[1].PV > 0);

                if (cs[1].PV <= 0)
                {
                    //Console.WriteLine($"Criatura \"{cs[1].Nome}\" venceu\n");
                    l1++;
                }
                else
                {
                    //Console.WriteLine($"Criatura \"{cs[0].Nome}\" venceu\n");
                    l2++;
                }
            }

            Console.WriteLine($"\n{cs[0].Nome} venceu {(float)l1/vezes * 100}%\n{cs[1].Nome} venceu {(float)l2 /vezes * 100}%");
        }
    }

    class Criatura
    {
        Random rnd = new Random();

        public Criatura(string _nome, int pv, int ca,int bonusAcerto,int danoMax, int iniciativa)
        {
            Nome = _nome;
            PV = pv;
            pvMax = pv;
            CA = ca;
            BA = bonusAcerto;
            Dano = danoMax;
            Ini = iniciativa;
        }
        public int PV;

        public string Nome;
        public int pvMax;
        public int CA;
        public int Ini;

        private int ba;
        public int BA
        {
            get { return rnd.Next(1, 20)+ba; }
            set { ba = value + 1; }
        }

        private int dano;
        public int Dano
        {
            get { return rnd.Next(1, dano); }
            set { dano = value + 1; }
        }

    }
}
