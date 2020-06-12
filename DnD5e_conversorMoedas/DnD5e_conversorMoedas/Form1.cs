using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD5e_conversorMoedas
{
    public partial class Form1 : Form
    {
        string rdo_atual;
        Button btn;

        public Form1()
        {
            InitializeComponent();
            rdo_atual = "PC";
            rdoPC.Checked = true;
            btn = btn_PC;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txtb = (TextBox)sender;

            if (txtb.Text == string.Empty) {
                txtb.Text = "0";
            }

            if (!txtb.Text.All(c => c >= '0' && c <= '9')) {
                txtb.Text = "0";
            }

        }

        private void radio_click(object sender, EventArgs e)
        {
            rdo_atual = ((RadioButton)sender).Text;
            btn_Click(btn, null);
            lbl_Dinheiro.Text = "Dinheiro: " + rdo_atual;
        }

        private void txt_Changed(object sender, EventArgs e)
        {
            btn_Click(btn, null);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            btn = (Button)sender;

            float[] num = new float[5];
            int moeda_atual = 0;

            lbl_conversor.Text = "Conversor: " + btn.Text;

            switch (rdo_atual) {
                case "PC":
                    moeda_atual = 0;
                    break;

                case "PP":
                    moeda_atual = 1;
                    break;

                case "PE":
                    moeda_atual = 2;
                    break;

                case "PO":
                    moeda_atual = 3;
                    break;

                case "PL":
                    moeda_atual = 4;
                    break;
            }

            switch (btn.Text) {
                case "PC":
                    num[0] = 1;
                    num[1] = 10;
                    num[2] = 50;
                    num[3] = 100;
                    num[4] = 1000;
                    break;

                case "PP":
                    num[0] = .1f;
                    num[1] = 1;
                    num[2] = 5;
                    num[3] = 10;
                    num[4] = 100;
                    break;

                case "PE":
                    num[0] = 0.02f;
                    num[1] = 0.2f;
                    num[2] = 1;
                    num[3] = 2;
                    num[4] = 20;
                    break;

                case "PO":
                    num[0] = 0.01f;
                    num[1] = 0.1f;
                    num[2] = 0.5f;
                    num[3] = 1;
                    num[4] = 10;
                    break;

                case "PL":
                    num[0] = 0.001f;
                    num[1] = 0.01f;
                    num[2] = 0.05f;
                    num[3] = 0.1f;
                    num[4] = 1;
                    break;
            }

            int x = Int32.Parse(txt_PX.Text);

            lbl_PX.Text = (x * num[moeda_atual]).ToString() + " " + btn.Text;
        }
    }
}
