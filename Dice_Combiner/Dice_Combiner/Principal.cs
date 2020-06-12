using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Combiner
{
    class Principal
    {
        int descobrir;
        List<string> lista = new List<string>();

        public void Run() {

            int[] Dnormal = { 4, 6, 8, 10, 12, 20 }; //6
            int[] Dextra = { 2, 3, 4, 5, 6, 8, 10, 12, 20}; //ou 9

            var fake_List = new List<string>();

            Start();

            #region Faz todas as verificações e atribue
            //if (!Array.Exists(Dnormal, x => descobrir == x))
            //{
                result_ver(verifica_Div(Dnormal), "Divisores:");
                result_ver(verifica_Mult(Dnormal), "\nMultiplicados:");
                result_ver(total_Verification_V2(Dnormal), "\nEmbaralhamento com 2 dados:");
                result_ver(total_Verification_V3(Dnormal), "\nEmbaralhamento com 3 dados:");
                result_ver(total_Verification_VE(Dextra), "\nEmbaralhamento com D(2,3,5):");
            //}
           // else
                //lista.Add($"D{descobrir} = D{descobrir}");
            #endregion

            foreach (var x in lista)
                Console.WriteLine(x);
        }

        void Start()
        {
            inicio:
            Console.WriteLine("Qual dado você quer descobrir?");
            if (!Int32.TryParse(Console.ReadLine(), out descobrir))
            {
                Console.Clear();
                goto inicio;
            }
            Console.WriteLine();
        }
        void result_ver(List<string> str, string texto)
        {
            if (str.Any())
            {
                lista.Add(texto);
                lista.AddRange(str);
            }
        }

        List<string> verifica_Div(int[] arr)
        {
            var rol = new List<string>();

            for (int i = 2; i <= 20; i++) //divisor
                for (int e = 0; e < arr.Length; e++) //todos dados
                    if (arr[e] % i == 0) {
                        if (arr[e] / i == descobrir)
                            rol.Add($"D{arr[e]}/{i} = D{arr[e] / i}");
                    }

            return rol;
        }

        List<string> verifica_Mult(int[] arr)
        {
            var rol = new List<string>();

            for (int i = 1; i <= 5; i++) //divisor
                for (int e = 0; e < arr.Length; e++) //todos dados
                    {
                        int temp = arr[e] * i - (i - 1);
                        if (temp == descobrir)
                        rol.Add($"{i}D{arr[e]} -{i - 1}\t= D{temp}");
                    }

            return rol;
        }

        List<string> total_Verification_V2(int[] arr)
        {
            var rol = new List<string>();

            int d1 = 0, d2 = 1;

            reset:

            #region Combinação            

            int count = 0, conta;
            bool direitaSoma = false;
            int l1 = 1, l2 = 1; //d1 =/= d2

            while (l1 + l2 <= 5)
            {

                if (count == 1)
                {
                    if (direitaSoma == false)
                        l2++;
                    else
                        l1++;
                    direitaSoma = !direitaSoma;
                }
                else if (count == 2)
                {
                    int temp = l1;
                    l1 = l2;
                    l2 = temp;
                    count = 0;
                }
                if (l1 + l2 <= 5)
                {
                    conta = l1 * arr[d1] + l2 * arr[d2] - (l1 + l2 - 1);
                    if (conta == descobrir)
                        rol.Add($"{l1}D{arr[d1]} + {l2}D{arr[d2]} -{l1 + l2 - 1}\t= D{conta}");
                }
                count++;
            }

            l1 = 2; l2 = 2;
            while (l1 + l2 <= 5)
            {
                conta = l1 * arr[d1] + l2 * arr[d2] - (l1 + l2 - 1);

                if (conta == descobrir)
                    rol.Add($"{l1}D{arr[d1]} + {l2}D{arr[d2]} -{l1 + l2 - 1}\t= D{conta}");

                if (l1 == 3 && l2 == 2)
                {
                    int temp = l1;
                    l1 = l2;
                    l2 = temp;
                }
                else
                    l1++;
            }

            #endregion

            d2++;           
            if (d2 == arr.Length)
            {
                d1++;
                if (d1 == arr.Length - 1)
                    goto final;
                d2 = d1 + 1;
            }
            goto reset;

            final:
            return rol;
        }

        List<string> total_Verification_V3(int[] arr)
        {
            var listar = new List<string>();



            return listar;
        }

        List<string> total_Verification_VE(int[] arr)
        {
            var listar = new List<string>();


            return listar;
        }

    }
}
