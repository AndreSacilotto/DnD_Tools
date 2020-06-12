using System;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Battle_Simulator_DnD
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            custom.KeyD += new KeyEventHandler(UserControl_KeyDown);
        }

        ListViewItem itemSelecionado = null;

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Set_Escrita(new string[] { "", "15", "10", "2", "2", "2", "10" });
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (custom.Nome != string.Empty)
            {
                var listViewItem = new ListViewItem(escrita_ToString());

                if (chkBox_grp.CheckState == CheckState.Unchecked)
                    LV_Aliado.Items.Add(listViewItem);
                else
                    LV_Inimigo.Items.Add(listViewItem);
            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            var forma = new Help_Form();
            forma.Show();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            var G1 = ListView_to_Group(LV_Aliado);
            var G2 = ListView_to_Group(LV_Inimigo);

            if (G1.Nome.Count > 0 && G2.Nome.Count > 0)
            {
                //var forma = new Form_Battle(G1, G2);
                var forma = new Form_Battle_Random(G1, G2, (int)nUD_delay.Value, chkBox_auto.Checked);
                forma.Show();
            }
            else
                MessageBox.Show("Um dos lados está sem combatentes");
        }

        GrupoAtr ListView_to_Group(ListView _LV)
        {
            var gr = new GrupoAtr();
            var lista = new List<string>();

            for (int i = 0; i < _LV.Items.Count; i++)
                for (int k = 0; k < _LV.Items[i].SubItems.Count; k++)
                    lista.Add(_LV.Items[i].SubItems[k].Text);

            for (int i = 0; i < lista.Count;)
            {
                gr.Nome.Add(lista[i++]);
                gr.Pv.Add(int.Parse(lista[i++]));
                gr.Ca.Add(int.Parse(lista[i++]));
                gr.Ini.Add(int.Parse(lista[i++]));
                gr.Ba.Add(int.Parse(lista[i++]));
                gr.Dmin.Add(int.Parse(lista[i++]));
                gr.Dmax.Add(int.Parse(lista[i++]));
            }

            return gr;
        }

        private void LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListView).SelectedItems.Count > 0 &&
                 (sender as ListView).SelectedItems[0] != null)
                itemSelecionado = (sender as ListView).SelectedItems[0];
        }

        private void chkBox_grp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_grp.Checked)
                chkBox_grp.Text = $"= Grupo {2}";
            else
                chkBox_grp.Text = $"= Grupo {1}";
        }

        private void chkBox_grp_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(chkBox_grp.BackColor), 0, 0, 14, 14);
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, 15, 15);

            if (chkBox_grp.CheckState == CheckState.Unchecked)
            {
                e.Graphics.FillRectangle(Brushes.DarkBlue, 2, 2, 12, 12);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.DarkRed, 2, 2, 12, 12);
            }
        }


        protected void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                chkBox_grp.Checked = !chkBox_grp.Checked;
                Thread.Sleep(150);
            }
        }

        private void LV_KeyDown(object sender, KeyEventArgs e)
        {
            if (itemSelecionado != null)
            {
                if (e.KeyCode == Keys.Delete)
                    itemSelecionado.Remove();
                else if (e.KeyCode == Keys.Insert)
                    sender = Set_tabela(sender as ListView, escrita_ToString());
                else if (e.KeyCode == Keys.F2)
                    itemSelecionado.SubItems[0].Text = custom.Nome;
                else if (e.KeyCode == Keys.D && e.Modifiers == Keys.Control)
                    (sender as ListView).Items.Add(new ListViewItem(ItemTabela_ToString(itemSelecionado)));
                else if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
                    Set_Escrita(ItemTabela_ToString(itemSelecionado));
                Thread.Sleep(200);
            }
        }

        void Set_Escrita(string[] str)
        {
            custom.Nome = str[0];
            custom.PV =   decimal.Parse(str[1]);
            custom.CA =   decimal.Parse(str[2]);
            custom.INI =  decimal.Parse(str[3]);
            custom.BA =   decimal.Parse(str[4]);
            custom.DMIN = decimal.Parse(str[5]);
            custom.DMAX = decimal.Parse(str[6]);
        }
        string[] escrita_ToString()
        {
            return new string[] {
                    custom.Nome,
                    custom.PV.ToString(),
                    custom.CA.ToString(),
                    custom.INI.ToString(),
                    custom.BA.ToString(),
                    custom.DMIN.ToString(),
                    custom.DMAX.ToString()
           };
        }

        ListView Set_tabela(ListView lv, string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                itemSelecionado.SubItems[i].Text = str[i];
            }
            return lv;
        }
        string[] ItemTabela_ToString(ListViewItem lv)
        {
            var str = new string[lv.SubItems.Count];
            for (int i = 0; i < str.Length; i++)
                str[i] = lv.SubItems[i].Text;
            return str;
        }

    }
}
