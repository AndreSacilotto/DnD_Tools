using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitiativeTracker
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        int turno, rodada;
        //List<int> iniciativas = new List<int>();

        public Form1()
        {
            InitializeComponent();
            rodada = 1;
            turno = 1;
            if (ListBox1.Items.Count > -1)
                ListBox1.SetSelected(0, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();

            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 2500;
            toolTip.ReshowDelay = 1000;

            //listViewButtons
            toolTip.SetToolTip(btn_del, "Deleta a criatura selecionada");
            toolTip.SetToolTip(btn_up, "Sobe a criatura na ordem de iniciativa");
            toolTip.SetToolTip(btn_down, "Desce a criatura na ordem de iniciativa");
            //txt
            toolTip.SetToolTip(btn_add, "Adiciona nova criatura");
            toolTip.SetToolTip(btn_alterar, "Altera o nome da criatura");
            toolTip.SetToolTip(btn_clear, "Apaga as caixas de texto");
            //Turno e Reset
            toolTip.SetToolTip(btn_next, "Proximo Turno");
            toolTip.SetToolTip(btn_newCombat, "Recomeça/Apaga o combate");

        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
                btn_add_Click(btn_add, null);
            else if ((Keys)e.KeyChar == Keys.Escape)
                btn_Clear_Click(btn_clear, null);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string new_criatura;

            new_criatura = txt_nome.Text + "\t" + txt_time.Text + "\t" + nud_ini.Value;

            if (txt_nome.Text != string.Empty)
            {
                ListBox1.Items.Add(new_criatura);

                if (turno > 1) {
                    for (int i = ListBox1.Items.Count - 1; i > 0; i--)
                    {
                        Object aux = ListBox1.Items[i];
                        ListBox1.Items[i] = ListBox1.Items[i - 1];
                        ListBox1.Items[i - 1] = aux;
                    }
                }

                //iniciativas.Add((int)nud_ini.Value);
                //iniciativa_automatica(true);
            }
        }

        /*
        private void iniciativa_automatica(bool isNew) {
            if (turno == 1 && rodada == 1 && ListBox1.SelectedIndex > -1)
            {
                int posicao_inicial = 0;
                int posicao_alvo = 1;

                while (posicao_alvo != posicao_inicial)
                {
                    if (isNew)
                        posicao_alvo = posicao_inicial = ListBox1.Items.Count - 1;
                    else
                        posicao_alvo = posicao_inicial = ListBox1.SelectedIndex;

                    //comparar iniciativas
                    for (int i = 0; i < iniciativas.Count; i++)
                    {
                        if (iniciativas[posicao_inicial] > iniciativas[i])
                        {
                            posicao_alvo = i;
                            break;
                        }
                    }

                    if (posicao_alvo != posicao_inicial)
                    {
                        Object aux = ListBox1.Items[posicao_inicial];
                        ListBox1.Items[posicao_inicial] = ListBox1.Items[posicao_alvo];
                        ListBox1.Items[posicao_alvo] = aux;

                        int temp = iniciativas[posicao_inicial];
                        iniciativas[posicao_inicial] = iniciativas[posicao_alvo];
                        iniciativas[posicao_alvo] = temp;
                    }
                    //MessageBox.Show("Pos " + posicao_alvo.ToString() + "\nIni " + iniciativas[posicao_alvo].ToString(), "Pos " + posicao_inicial.ToString() + " Ini " + iniciativas[posicao_inicial].ToString());
                }
                ListBox1.SetSelected(posicao_alvo, true);
            }
        }
        */

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex > -1)
            {
                string new_criatura;

                new_criatura = txt_nome.Text + "\t" + txt_time.Text + "\t" + nud_ini.Value;

                ListBox1.Items[ListBox1.SelectedIndex] = new_criatura;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_nome.Text = string.Empty;
            txt_time.Text = string.Empty;
            nud_ini.Value = 10;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Remove(ListBox1.SelectedItem);
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex > -1)
            {
                int num = ListBox1.SelectedIndex;

                if (num != 0)
                {
                    Object aux = ListBox1.Items[num];

                    ListBox1.Items[num] = ListBox1.Items[num - 1];

                    ListBox1.Items[num - 1] = aux;

                    ListBox1.SetSelected(num - 1, true);
                }
            }
            /* Segredo da troca de posições
            aux = selecionado;
            selecionado = alvo;
            alvo = aux;
            */
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex > -1)
            {
                int num = ListBox1.SelectedIndex;

                if (num != ListBox1.Items.Count - 1)
                {
                    Object aux = ListBox1.Items[num];

                    ListBox1.Items[num] = ListBox1.Items[num + 1];

                    ListBox1.Items[num + 1] = aux;

                    ListBox1.SetSelected(num + 1, true);
                }
            }
        }

        private void btn_nextTurno_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex > -1)
            {
                turno++;
                txt_turnoAtual.Text = turno.ToString();

                if (turno == ListBox1.Items.Count + 1)
                {
                    rodada++;
                    txt_rodadaAtual.Text = rodada.ToString();
                    turno = 1;
                    txt_turnoAtual.Text = turno.ToString();
                }

                Object save = ListBox1.Items[0].ToString();

                ListBox1.Items.RemoveAt(0);
                ListBox1.Items.Add(save);

                ListBox1.SetSelected(0, true);
            }

        }

        private void btn_newCombat_Click(object sender, EventArgs e)
        {
            DialogResult resultLimpar = MessageBox.Show(" Sim - Nova tabela sem texto \n Não - Nova tabelo com texto \n Cancelar - Clicou sem querer", "Pergunta!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (resultLimpar == DialogResult.Yes)
            {
                ListBox1.Items.Clear();
                //iniciativas.Clear();
            }
            else if (resultLimpar == DialogResult.No && ListBox1.SelectedIndex > -1)
                ListBox1.SetSelected(0, true);
            else if (resultLimpar == DialogResult.Cancel)
                return;

            rodada = 1;
            turno = 1;
            txt_turnoAtual.Text = turno.ToString();
            txt_rodadaAtual.Text = rodada.ToString();
        }
    }
}
