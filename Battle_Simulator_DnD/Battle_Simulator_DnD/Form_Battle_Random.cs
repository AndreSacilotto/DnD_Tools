using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_Simulator_DnD
{
    public partial class Form_Battle_Random : Form
    {
        public Form_Battle_Random(GrupoAtr G1, GrupoAtr G2, int delay_miliseconds, bool auto_iniciar)
        {
            aliados = G1;
            inimigos = G2;
            delay = delay_miliseconds;
            InitializeComponent();
            Set_tables();
            if (auto_iniciar == true)
                btn_iniciar_Click(btn_iniciar, null);
        }

        GrupoAtr aliados, inimigos;
        decimal Turno;
        int delay;

        private void SetStartLB(ListView _LV, GrupoAtr gr)
        {
            _LV.Items.Clear();
            for (int i = 0; i < gr.Nome.Count; i++)
            {
                _LV.Items.Add(gr.Nome[i]);
                _LV.Items[_LV.Items.Count - 1].SubItems.Add(gr.Pv[i].ToString());
            }
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            (sender as Button).Visible = false;
            rtxt_Log.Select();
            Batalha();
        }

        async void Batalha()
        {

            #region Iniciativa
            int ini_G1 = 0, ini_G2 = 0;
            bool aliados_ini = true;
            while (ini_G1 == ini_G2)
            {
                ini_G1 = Iniciativa_grupo(aliados);
                ini_G2 = Iniciativa_grupo(inimigos);
                if (Iniciativa_grupo(aliados) < Iniciativa_grupo(inimigos))
                    aliados_ini = false;
            }
            Log($"A iniciativa do Grupo 1: {ini_G1}", Color.Fuchsia);
            Log($"A iniciativa do Grupo 2: {ini_G2}", Color.DeepPink);
            #endregion

            #region COMBATE
            bool isEnded = false;
            while (isEnded == false)
            {
                if (aliados_ini)
                {
                    try
                    {
                        await Atacando(aliados, inimigos, true);
                        await Atacando(inimigos, aliados, false);
                    }
                    catch { return; }
                }
                else
                {
                    try
                    {
                        await Atacando(inimigos, aliados, false);
                        await Atacando(aliados, inimigos, true);
                    }
                    catch { return; }
                }
                isEnded = NextRound();
            }
            #endregion

        }

        int Iniciativa_grupo(GrupoAtr gr)
        {
            if (gr.Ini.Count > 0)
            {
                int soma = 0;
                foreach (var x in gr.Ini)
                {
                    soma += Roller(1, 20) + x;
                }
                return soma / gr.Ini.Count;
            }
            return 0;
        }

        async Task Atacando(GrupoAtr ataque, GrupoAtr defesa, bool isAtaqueAliado)
        {
            # region Escolher Cores
            Color dano_C = Color.Red, erro_C = Color.Green;
            if (!isAtaqueAliado)
            {
                dano_C = Color.Firebrick;
                erro_C = Color.DarkGreen;
            }
            #endregion

            for (int i = 0; i < ataque.Nome.Count && defesa.Nome.Count != 0; i++)
            {
                int def_idx = Roller(0, defesa.Nome.Count - 1);
                bool can = Tentativa_de_Ataque(ataque, defesa, i, def_idx);

                if (can)
                {
                    int dn = Dano(ataque, i);
                    defesa.Pv[def_idx] -= dn;
                    Log($"{ataque.Nome[i]} infligiu {dn} de dano em {defesa.Nome[def_idx]}", dano_C);
                }
                else
                    Log($"{ataque.Nome[i]} errou o ataque em {defesa.Nome[def_idx]}", erro_C);

                Remover_Corpos(isAtaqueAliado);
                Set_tables();
                await Task.Delay(delay);
            }
        }

        bool Tentativa_de_Ataque(GrupoAtr ataque, GrupoAtr defesa, int Ata_index, int Def_index)
        {
            if (Roller(1, 20) + ataque.Ba[Ata_index] < defesa.Ca[Def_index])
                return false;
            return true;
        }

        int Dano(GrupoAtr atacante, int index)
        {
            return Roller(atacante.Dmin[index], atacante.Dmax[index]);
        }

        void Remover_Corpos(bool isAtaqueAliado)
        {
            if (!isAtaqueAliado)
            {
                if (!aliados.Pv.TrueForAll(x => x > 0))
                    aliados = Multi_Removedor(aliados, Color.Blue);
            }
            else
            {
                if (!inimigos.Pv.TrueForAll(x => x > 0))
                    inimigos = Multi_Removedor(inimigos, Color.DarkBlue);
            }
        }

        GrupoAtr Multi_Removedor(GrupoAtr gr, Color Death)
        {
            for (int i = 0; i < gr.Pv.Count; i++)
                if (gr.Pv[i] < 1)
                {
                    Log($"{gr.Nome[i]} morreu", Death);
                    gr.Nome.RemoveAt(i);
                    gr.Pv.RemoveAt(i);
                    gr.Ca.RemoveAt(i);
                    gr.Ba.RemoveAt(i);
                    gr.Ini.RemoveAt(i);
                    gr.Dmin.RemoveAt(i);
                    gr.Dmax.RemoveAt(i);
                }
            return gr;
        }

        bool NextRound()
        {
            Set_tables();

            if (inimigos.Nome.Count < 1)
            {
                EndGame("Grupo 1 venceu", Color.Gold);
                return true;
            }
            else if (aliados.Nome.Count < 1)
            {
                EndGame("Grupo 2 venceu", Color.Indigo);
                return true;
            }

            Turno++;
            lbl_Turno.Text = Turno.ToString();
            return false;
        }

        void EndGame(string txt, Color cor)
        {
            lbl_winner.Visible = true;
            lbl_winner.Text = txt;
            lbl_winner.ForeColor = cor;
        }

        void Set_tables()
        {
            SetStartLB(LV_Aliado, aliados);
            SetStartLB(LV_Inimigos, inimigos);
        }
        int Roller(int min, int max)
        {
            return new Random().Next(min, max + 1);
        }

        private void lbl_winner_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(lbl_winner.BackColor), 0, 0, 14, 14);
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, 15, 15);
        }

        void Log(string str, Color cor)
        {
            rtxt_Log.AppendText($"{str}\n", cor);
        }
    }
}
