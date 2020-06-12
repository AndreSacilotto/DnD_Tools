using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados_roll
{

    public partial class Form1 : Form
    {
        //dados e seus nº | 1 D20 | 2 D16 | 3 D12 | 4 D10 | 5 D8 | 6 D6 | 7 D4 | 8 D2 |
        public int dado, botton_clicked;     
        public int V, M, O, N_R;
        public string equa_show;

        public Form1()
        {
            InitializeComponent();
        }

        private void T_TextChanged(object sender, EventArgs e) {

            Num.Text = T.Text;
            conta.Text = T.Text;
        }

        private void dado20_Click(object sender, EventArgs e) {

            botton_clicked = 1;
            N_R = 21;
            V = (int)V20.Value; O = (int)M20.Value; M = (int)O20.Value;
            equation();
        }

        private void dado16_Click(object sender, EventArgs e) {

            botton_clicked = 2;
            N_R = 17;
            V = (int)V16.Value; O = (int)M16.Value; M = (int)O16.Value;
            equation();
        }

        private void dado12_Click(object sender, EventArgs e) {

            botton_clicked = 3; 
            N_R = 13;
            V = (int)V12.Value; O = (int)M12.Value; M = (int)O12.Value;
            equation();
        }

        private void dado10_Click(object sender, EventArgs e) {

            botton_clicked = 4; 
            N_R = 11;
            V = (int)V10.Value; O = (int)M10.Value; M = (int)O10.Value;
            equation();
        }

        private void dado8_Click(object sender, EventArgs e) {

            botton_clicked = 5; 
            N_R = 9;
            V = (int)V8.Value; O = (int)M8.Value; M = (int)O8.Value;
            equation();
        }

        private void dado6_Click(object sender, EventArgs e) {

            botton_clicked = 6;
            N_R = 7;
            V = (int)V6.Value; O = (int)M6.Value; M = (int)O6.Value;
            equation();
        }

        private void dado4_Click(object sender, EventArgs e) {

            botton_clicked = 8;
            N_R = 5;
            V = (int)V4.Value; O = (int)M4.Value; M = (int)O4.Value;
            equation();
        }

        private void dado2_Click(object sender, EventArgs e) {
            botton_clicked = 9;
            N_R = 3;
            V = (int)V2.Value; O = (int)M2.Value; M = (int)O2.Value;
            equation();

        }

        private void equation()
        {
            Random RN = new Random();
            int total_rolagem = 0;
            
                    if (vezes.Text != "") { vezes.Text = String.Empty; }

                    for (int i = 0; i < V; i++)
                    {
                        int roda = RN.Next(1, N_R);
                        total_rolagem += roda;
                        if (i == 0) vezes.Text += roda + "";
                        else vezes.Text += ", " + roda;
                    }
                    Num.Text = Convert.ToString(total_rolagem + M + O);
                    conta.Text = total_rolagem + " + " + M + " + " + O;
            // MessageBox.Show(Convert.ToString(M20.Value));
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Test_form newform = new Test_form();
            newform.ShowDialog();
        }

        public void convert_updown() {
            // NOME antigo mais C no final (convertido)
            int V20C = (int)V20.Value;
            int V16C = (int)V16.Value;
            int V12C = (int)V12.Value;
            int V10C = (int)V10.Value;
            int V8C = (int)V8.Value;
            int V6C = (int)V6.Value;
            int V4C = (int)V4.Value;
            int V2C = (int)V2.Value;

            int M20C = (int)M20.Value;
            int M16C = (int)M16.Value;
            int M12C = (int)M12.Value;
            int M10C = (int)M10.Value;
            int M8C = (int)M8.Value;
            int M6C = (int)M6.Value;
            int M4C = (int)M4.Value;
            int M2C = (int)M2.Value;

            int O20C = (int)O20.Value;
            int O16C = (int)O16.Value;
            int O12C = (int)O12.Value;
            int O10C = (int)O10.Value;
            int O8C = (int)O8.Value;
            int O6C = (int)O6.Value;
            int O4C = (int)O4.Value;
            int O2C = (int)O2.Value;

        }

    }
}
