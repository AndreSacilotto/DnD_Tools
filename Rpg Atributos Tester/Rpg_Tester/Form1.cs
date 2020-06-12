using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rpg_Tester
{
    public partial class Form1 : Form
    {

        int pontos;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            string zero = Valor_ini.Text;
            input_num1.Text = zero;
            input_num2.Text = zero;
            input_num3.Text = zero;
            input_num4.Text = zero;
            input_num5.Text = zero;
            input_num6.Text = zero;

            lbl_Gastar.Text = input_Trans.Text;
            Int32.TryParse(lbl_Gastar.Text, out pontos);                         
        }

        private void btn_plus1_Click(object sender, EventArgs e) { plus_btn(input_num1); }
        private void btn_plus2_Click(object sender, EventArgs e) { plus_btn(input_num2); }
        private void btn_plus3_Click(object sender, EventArgs e) { plus_btn(input_num3); }
        private void btn_plus4_Click(object sender, EventArgs e) { plus_btn(input_num4); }
        private void btn_plus5_Click(object sender, EventArgs e) { plus_btn(input_num5); }
        private void btn_plus6_Click(object sender, EventArgs e) { plus_btn(input_num6); }
        
        private void btn_minus1_Click(object sender, EventArgs e) { minus_btn(input_num1); }
        private void btn_minus2_Click(object sender, EventArgs e) { minus_btn(input_num2); }
        private void btn_minus3_Click(object sender, EventArgs e) { minus_btn(input_num3); }
        private void btn_minus4_Click(object sender, EventArgs e) { minus_btn(input_num4); }
        private void btn_minus5_Click(object sender, EventArgs e) { minus_btn(input_num5); }
        private void btn_minus6_Click(object sender, EventArgs e) { minus_btn(input_num6); }

        private void mod_change1(object sender, EventArgs e) { mod1.Text = modificador_conta(input_num1); }
        private void mod_change2(object sender, EventArgs e) { mod2.Text = modificador_conta(input_num2); }
        private void mod_change3(object sender, EventArgs e) { mod3.Text = modificador_conta(input_num3); }
        private void mod_change4(object sender, EventArgs e) { mod4.Text = modificador_conta(input_num4); }
        private void mod_change5(object sender, EventArgs e) { mod5.Text = modificador_conta(input_num5); }
        private void mod_change6(object sender, EventArgs e) { mod6.Text = modificador_conta(input_num6); }

        void plus_btn(TextBox plus) {
            int x = Int32.Parse(plus.Text);

            if (x < 18 && pontos != 0)
            {
                x += 1;
                pontos -= 1;
            }


            plus.Text = x.ToString();
            lbl_Gastar.Text = pontos.ToString();
        }

        void minus_btn(TextBox minus) {
            int x = Int32.Parse(minus.Text);

            if (x > Int32.Parse(Valor_ini.Text))
            {
                x -= 1;
                pontos += 1;
            }

            minus.Text = x.ToString();
            lbl_Gastar.Text = pontos.ToString();
        }

        string modificador_conta(TextBox atributo) {
            int x = Int32.Parse(atributo.Text);
            double conta = Math.Floor((x - 10) * 0.5f);

            if (conta >= 0)
                return "+" + conta.ToString();
            else if (conta < 0)
                return "-" + conta.ToString();

            return "";
        }
    }
}
