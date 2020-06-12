using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atr_Mod_dnd5e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nUD_ValueChanged(object sender, EventArgs e)
        {
            if (rb_Atr.Checked)
                lbl.Text = Math.Floor((nUD.Value - 10) / 2).ToString("+0;-#");            
            else
                lbl.Text = Math.Floor((nUD.Value + 10) * 2).ToString("+0;-#");
        }
    }
}
