using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_XP_Encontro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soma;

        private void TXT_Change(object sender, EventArgs e)
        {
            MessageBox.Show("aaa");
            for (int x = 1; x < 9; x++) {
                TextBox _nd = (TextBox)this.Controls["ND" + x.ToString()];
                TextBox _quant = (TextBox)this.Controls["quant" + x.ToString()];
                soma += Int32.Parse(_quant.Text);

                MessageBox.Show("aaa");

                if (!IsDigits(_nd.Text)) { MessageBox.Show("aaa"); }
                if (IsDigits(_quant.Text)) { MessageBox.Show("aaa"); }
                difi_txt.Text = soma.ToString();
            }
           
        }

        void difi_calc() {
            int aaa = 
        }

        bool IsDigits(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

    }
}
