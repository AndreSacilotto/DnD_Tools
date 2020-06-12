using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_Simulator_DnD
{
    public partial class Form_Battle : Form
    {
        Random rnd = new Random();
        GrupoAtr aliados, inimigos;
        decimal Turno;

        public Form_Battle(GrupoAtr G1, GrupoAtr G2)
        {
            aliados = G1;
            inimigos = G2;

            InitializeComponent();

            SetStartLB(LV_Aliado , aliados);
            SetStartLB(LV_Inimigos, inimigos);
        }

        private void SetStartLB(ListView _LV, GrupoAtr gr)
        {
            _LV.Items.Clear();
            for (int i = 0; i < gr.Nome.Count; i++)
            {
                _LV.Items.Add(gr.Nome[i]);
                _LV.Items[_LV.Items.Count-1].SubItems.Add(gr.Pv[i].ToString());
            }
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            (sender as Control).Visible = false;
            Batalha();
        }

        async void Batalha()
        {
            bool isEnded = false;
            int dn = 0;
            while (isEnded == false)
            {
                if (rnd.Next(1, 21) + aliados.Ini[0] > rnd.Next(1, 21) + inimigos.Ini[0])
                {
                    if (Tentativa_de_Ataque(inimigos, aliados) == true) {
                        dn = Dano(aliados);
                        inimigos.Pv[0] -= dn;
                        rtxt_Log.AppendText($"{aliados.Nome[0]} infligiu {dn} de dano\n", Color.Crimson);
                    }
                    else
                        rtxt_Log.AppendText($"{aliados.Nome[0]} errou\n", Color.DimGray);
                    if (inimigos.Pv[0] > 0)
                        if (Tentativa_de_Ataque(aliados, inimigos) == true) {
                            dn = Dano(inimigos);
                            aliados.Pv[0] -= dn;
                            rtxt_Log.AppendText($"{inimigos.Nome[0]} infligiu {dn} de dano\n", Color.Firebrick);
                        }
                    else
                        rtxt_Log.AppendText($"{inimigos.Nome[0]} errou\n", Color.DarkGray);
                }
                else
                {
                    if (Tentativa_de_Ataque(aliados, inimigos) == true)
                    {
                        dn = Dano(inimigos);
                        aliados.Pv[0] -= dn;
                        rtxt_Log.AppendText($"{inimigos.Nome[0]} infligiu {dn} de dano\n", Color.Firebrick);
                    }
                    else
                        rtxt_Log.AppendText($"{inimigos.Nome[0]} errou\n", Color.DarkGray);

                    if (aliados.Pv[0] > 0)
                        if (Tentativa_de_Ataque(inimigos, aliados) == true)
                        {
                            dn = Dano(aliados);
                            inimigos.Pv[0] -= dn;
                            rtxt_Log.AppendText($"{aliados.Nome[0]} infligiu {dn} de dano\n", Color.Crimson);
                        }
                        else
                            rtxt_Log.AppendText($"{aliados.Nome[0]} errou\n", Color.DimGray);
                }

                isEnded = NextTurn();
                await Task.Delay(1000, CancellationToken.None);
            }
        }

        bool Tentativa_de_Ataque(GrupoAtr defesa, GrupoAtr ataque)
        {
            if (defesa.Ba[0] < rnd.Next(1, 21) + ataque.Ba[0])
                return true;
            return false;
        }

        int Dano (GrupoAtr gr)
        {
            return rnd.Next(gr.Dmin[0], gr.Dmax[0] + 1);
        }

        bool NextTurn()
        {
            if (aliados.Pv[0] < 0 || inimigos.Pv[0] < 0)
            {
                if (aliados.Pv[0] < 0)
                {
                    rtxt_Log.AppendText($"{aliados.Nome[0]} Morreu\n", Color.Cyan);
                    aliados = Remover_Mortos(aliados);
                    if (aliados.Nome.Count < 1)
                    {
                        EndGame("Grupo 2 Venceu", Color.Green);
                        SetStartLB(LV_Aliado, aliados);
                        SetStartLB(LV_Inimigos, inimigos);
                        return true;
                    }
                }
                if (inimigos.Pv[0] < 0)
                {
                    rtxt_Log.AppendText($"{inimigos.Nome[0]} Morreu\n", Color.Aqua);
                    inimigos = Remover_Mortos(inimigos);
                    if (inimigos.Nome.Count < 1)
                    {
                        EndGame("Grupo 1 Venceu", Color.RoyalBlue);
                        SetStartLB(LV_Aliado, aliados);
                        SetStartLB(LV_Inimigos, inimigos);
                        return true;
                    }
                }
            }
            else
            {
                aliados = Roda(aliados);
                inimigos = Roda(inimigos);
            }

            SetStartLB(LV_Aliado, aliados);
            SetStartLB(LV_Inimigos, inimigos);

            Turno++;
            lbl_Turno.Text = Turno.ToString();
            return false;
        }    

        private void EndGame(string txt, Color cor)
        {
            lbl_winner.Visible = true;
            lbl_winner.Text = txt;
            lbl_winner.ForeColor = cor;
        }

        GrupoAtr Remover_Mortos (GrupoAtr gr)
        {
            gr.Nome.RemoveAt(0);
            gr.Pv.RemoveAt(0);
            gr.Ca.RemoveAt(0);
            gr.Ba.RemoveAt(0);
            gr.Dmin.RemoveAt(0);
            gr.Dmax.RemoveAt(0);
            return gr;
        }

        GrupoAtr Roda(GrupoAtr gr)
        {
            gr.Nome = Fila(gr.Nome);
            gr.Pv = Fila(gr.Pv);
            gr.Ca = Fila(gr.Ca);
            gr.Ba = Fila(gr.Ba);
            gr.Dmin = Fila(gr.Dmin);
            gr.Dmax = Fila(gr.Dmax);
            return gr;
        }

        List<T> Fila<T> (List<T> lista)
        {
            var temp = lista[0];
            lista.RemoveAt(0);
            lista.Add(temp);
            return lista;
        }
    }
}
