using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dndQuiz_Form
{
    class SetData
    {

        public int[][] Estados_transicao () {

            int[][] sequencias = new int[14][];
            sequencias[0] = new int[] { 1, 2 };
            sequencias[1] = new int[] { 3, 4 };
            sequencias[2] = new int[] { 5, 6 };
            sequencias[3] = new int[] { 8, 7 };
            sequencias[4] = new int[] { -1, 5 };
            sequencias[5] = new int[] { -1, 9 };
            sequencias[6] = new int[] { -1, 11, 10 };
            sequencias[7] = new int[] { -1, 12 };
            sequencias[8] = new int[] { -1, 13 };
            sequencias[9] = new int[] { -1, -1 };
            sequencias[10] = new int[] { -1, -1 };
            sequencias[11] = new int[] { -1, -1, -1 };
            sequencias[12] = new int[] { -1, -1 };
            sequencias[13] = new int[] { -1, -1 };

            return sequencias;
        }

        //enum N_Classes { Barbaro, Bardo, Bruxo, Clerigo, Druida, Feiticeiro, Guerreiro, Ladino, Mago, Monge, Paladino, Patrulheiro };

        public int[,] Estados_Desabilitador()
        {
            //Representa a transição de estados que desabilita as classes

            int[,] transDes = new int[10,3];

            //0 = opc1 | 1 = opc2 | 2 = opc3 |
            // Faça um +4 para saber a real transiçao [X+4, X]
            transDes[0, 0] = 9;

            transDes[1, 0] = 7;

            transDes[2, 0] = 5;

            transDes[3, 0] = 4;

            transDes[4, 0] = 0;

            transDes[5, 0] = 11;
            transDes[5, 1] = 1;

            transDes[6, 0] = 1;
            transDes[6, 1] = 8;

            transDes[7, 0] = 3;
            transDes[7, 1] = 2;
            transDes[7, 2] = 4;

            transDes[8, 0] = 3;
            transDes[8, 1] = 10;

            transDes[9, 0] = 6;
            transDes[9, 1] = 9;

            return transDes;
        }

    }
}
