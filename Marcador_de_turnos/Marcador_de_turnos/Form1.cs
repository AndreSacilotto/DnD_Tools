using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcador_de_turnos
{
    public partial class Form1 : Form
    {

        int players, turnos, rodadas;

        public Form1()
        {
            InitializeComponent();
        }

        // Validação do começo do campo de texto para evitar erros //
        private void participantes_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            { e.Handled = true; }
        }
        private void txt_participantes_Enter(object sender, EventArgs e)
        {
            if (txt_participantes.Text == string.Empty)
            {
                txt_participantes.Text = "0";
            }
        }

        // Promação do sistema de marcação de turno //
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem certeza?","Aviso");
            reset();
            players = (int)Int64.Parse(txt_participantes.Text);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }   

        private void btn_soma_Click(object sender, EventArgs e)
        {
            turnos += 1;
            if (turnos - 1 == players) {
                turnos = 1;
                rodadas += 1;
            }

            set_txts();
        }

        private void btn_diminui_Click(object sender, EventArgs e)
        {

            if (turnos > 1 && turnos != 0)
            {
                turnos -= 1;
            }
            else if (turnos == 1 && rodadas > 0){
                turnos = players;
                rodadas -= 1;
            }

            set_txts();
        }

        // Funções auxiliares ou seja sequencias pre-feitas //
        void reset() {
            players = 0;
            turnos = 1;
            rodadas = 1;
            set_txts();
        }

        void set_txts()
        {
            txt_turnos.Text = turnos.ToString();
            txt_rodadas.Text = rodadas.ToString();
        }

    }
}
