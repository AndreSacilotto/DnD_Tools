using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roller_Calculator
{
    public partial class Form1 : Form
    {
        List<string> rollResults = new List<string>();
        Random RN = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int roll = 0, soma = 0;
            string rolagem = "";

            for (int i = 0; i < nud_vezes.Value; i++)
            {
                roll = RN.Next(1, (int)nud_lados.Value + 1);
                soma += roll;
                rolagem += $"{roll}, ";
            }

            soma += (int)nud_bonus.Value;

            rolagem += nud_bonus.Value.ToString("+0;-#;");

            rollResults.Add(rolagem);

            listBox1.Items.Add(string.Format("{0}D{1} + {2} = {3}", nud_vezes.Value, nud_lados.Value, nud_bonus.Value, soma));

            listBox1.SetSelected(listBox1.Items.Count - 1,true);

            //MessageBox.Show(listBox1.FindStringExact("1").ToString());
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            rollResults.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             txt_result.Text = rollResults[listBox1.SelectedIndex];
        }

        private void txt_Press(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
                btn_add_Click(btn_add, null);
            else if ((Keys)e.KeyChar == Keys.Escape)
                btn_limpar_Click(btn_limpar,null);
        }
    }
}
