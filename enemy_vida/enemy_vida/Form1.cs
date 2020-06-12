using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enemy_vida
{
    public partial class Form1 : Form
    {
        bool[] _ids = new bool[16]; //false = removido / true = com labels

        public Form1()
        {
            InitializeComponent();
            blank_all();
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int valuer = Int32.Parse(id_to_put.Value.ToString());

            if (verifica_texto() == true)
                for (int x = 1; x < 16; x++)
                    if (_ids[x] == false && id_to_put.Value == 0)
                    {
                        submit_count(x);
                        break;
                    }

            if (_ids[valuer] == false && id_to_put.Value != 0)
            {    submit_count(valuer); }
        }
        //-----------------------------------------------------------------------------------------------------
        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int x = 1; x < 16; x++)
                if (num_to_remove.Value == x && _ids[x] == true && num_to_remove.Value != 0)
                {
                    DialogResult result = MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == result) {
                        Label _Name = (Label)this.Controls["Name" + x.ToString()];
                        Label _VidaM = (Label)this.Controls["VidaM" + x.ToString()];
                        Label _VidaA = (Label)this.Controls["VidaA" + x.ToString()];
                        Label _CD = (Label)this.Controls["CD" + x.ToString()];
                        Label _Percep = (Label)this.Controls["Percep" + x.ToString()];
                        _Name.Text = "";
                        _VidaM.Text = "";
                        _VidaA.Text = "";
                        _CD.Text = "";
                        _Percep.Text = "";
                        _ids[x] = false;
                        break;}break;
                }
        }
        //-----------------------------------------------------------------------------------------------------
        private void btnChange_Click(object sender, EventArgs e)
        {
            int valuer = Convert.ToInt32(id_change.Value.ToString());

            if (_ids[valuer] == true && valuer != 0)
            {
                Label _VidaA = (Label)this.Controls["VidaA" + valuer.ToString()];
                Label _CD = (Label)this.Controls["CD" + valuer.ToString()];
                _CD.Text = CD_change.Text ;
                _VidaA.Text = VidaA_change.Text;
            }
        }

        //-----------------------------------------------------------------------------------------------------
        private void btn_ajuda_Click(object sender, EventArgs e)
        {
            Form_help ajuda_form = new Form_help();
            ajuda_form.Show();
        }
        //-----------------------------------------------------------------------------------------------------
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo);

            if (DialogResult.Yes == result) {
                MessageBox.Show("Tem certeza mesmo?", "Confirmação da Confirmação", MessageBoxButtons.YesNo); blank_all(); }
        }
        //-----------------------------------------------------------------------------------------------------
        private void id_change_ValueChanged(object sender, EventArgs e)
        {
                int valuer = Convert.ToInt32(id_change.Value.ToString());

            if (valuer > 0)
            {
                Label _VidaA = (Label)this.Controls["VidaA" + valuer.ToString()];
                Label _CD = (Label)this.Controls["CD" + valuer.ToString()];
                CD_change.Text = _CD.Text;
                if(VidaA_change.Text == "")
                VidaA_change.Text = _VidaA.Text;
            }
        }
        //-----------------------------------Label.Clicks------------------------------------------------------
        void ValidationEvent(object sender, EventArgs e)
        {
            Label id_cliked = sender as Label;      
            num_to_remove.Value = Int32.Parse(id_cliked.Text);
            id_change.Value = Int32.Parse(id_cliked.Text);
            id_to_put.Value = Int32.Parse(id_cliked.Text);
        }

        private void IDT_Click(object sender, EventArgs e)
        {num_to_remove.Value = 0;id_change.Value = 0;id_to_put.Value = 0;}

        //------------------------Enter'n'Leave----------------------------------------------------------------
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Nome") { txtName.Text = string.Empty; txtName.TextAlign = HorizontalAlignment.Left; }
        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty) { txtName.Text = "Nome"; txtName.TextAlign = HorizontalAlignment.Center; }
        }
        private void txtVidaA_Enter(object sender, EventArgs e)
        {
            if (txtVidaA.Text == "Vida Atual") { txtVidaA.Text = ""; txtVidaA.TextAlign = HorizontalAlignment.Left; }
        }
        private void txtVidaA_Leave(object sender, EventArgs e)
        {
            if (txtVidaA.Text == "") { txtVidaA.Text = "Vida Atual"; txtVidaA.TextAlign = HorizontalAlignment.Center; }
        }

        //--------------------------------Funções--------------------------------------


        private void blank_all() {
            //opção 1
            for (int x = 1; x < 16; x++) {
                Label _Name = (Label)this.Controls["Name" + x.ToString()];
                Label _VidaM = (Label)this.Controls["VidaM" + x.ToString()];
                Label _VidaA = (Label)this.Controls["VidaA" + x.ToString()];
                Label _CD = (Label)this.Controls["CD" + x.ToString()];
                Label _Percep = (Label)this.Controls["Percep" + x.ToString()];
                _Name.Text = "";
                _VidaM.Text = "";
                _VidaA.Text = "";
                _CD.Text = "";
                _Percep.Text = "";

                _ids[x] = false; //coisa do codigo
            }

            //opção 2 
            /*
            Label[] names = { Name1, Name2, Name3, Name4, Name5, Name6, Name7, Name8, Name9, Name10, Name11, Name12, Name13, Name14, Name15 };
            foreach (Label day in names) { day.Text = ""; }

            Label[] vidasmaximas = { VidaM1, VidaM2, VidaM3, VidaM4, VidaM5, VidaM6, VidaM7, VidaM8, VidaM9, VidaM10, VidaM11, VidaM12, VidaM13, VidaM14, VidaM15 };
            foreach (Label day in vidasmaximas) { day.Text = ""; }

            Label[] vidasatuais = { VidaA1, VidaA2, VidaA3, VidaA4, VidaA5, VidaA6, VidaA7, VidaA8, VidaA9, VidaA10, VidaA11, VidaA12, VidaA13, VidaA14, VidaA15 };
            foreach (Label day in vidasatuais) { day.Text = ""; }

            Label[] cds = { CD1, CD2, CD3, CD4, CD5, CD6, CD7, CD8, CD9, CD10, CD11, CD12, CD13, CD14, CD15 };
            foreach (Label day in cds) { day.Text = ""; }

            Label[] percepcao = { Percep1, Percep2, Percep3, Percep4, Percep5, Percep6, Percep7, Percep8, Percep9, Percep10, Percep11, Percep12, Percep13, Percep14, Percep15 };
            foreach (Label day in percepcao) { day.Text = ""; }
            */
        }
        private void submit_count(int x) {
            Label _Name = (Label)this.Controls["Name" + x.ToString()];
            Label _VidaM = (Label)this.Controls["VidaM" + x.ToString()];
            Label _VidaA = (Label)this.Controls["VidaA" + x.ToString()];
            Label _CD = (Label)this.Controls["CD" + x.ToString()];
            Label _Percep = (Label)this.Controls["Percep" + x.ToString()];

            _Name.Text = txtName.Text;
            _VidaA.Text = txtVidaA.Text;
            _VidaM.Text = numericVidaMax.Value.ToString();
            _CD.Text = numericCD.Value.ToString();
            _Percep.Text = numericPercep.Value.ToString();

            if (_CD.Text == "0") _CD.Text = "--";
            if (_Percep.Text == "0") _Percep.Text = "--";

            _ids[x] = true;
            txtName.Text = "Nome"; txtName.TextAlign = HorizontalAlignment.Center;
            txtVidaA.Text = "Vida Atual"; txtVidaA.TextAlign = HorizontalAlignment.Center;

            NumericUpDown[] numerics = { id_to_put, numericVidaMax, numericCD, numericPercep };
            foreach (NumericUpDown num in numerics) { num.Value = 0; }
        }

        private bool verifica_texto() {
            string named = txtName.Text, vida_A = txtVidaA.Text;

            if (txtName.Text != "Nome" && txtName.Text != "" && txtVidaA.Text != "" && txtVidaA.Text != "Vida Atual")
            {  return true;  }
            else
            { return false; }
        }
        //----------------------------------------Botão fechar do form -------------------------------------------
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {/*
            DialogResult result;

            result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação 2", MessageBoxButtons.YesNo);
            if (DialogResult.No == result)  e.Cancel = true;
            */
        }
        //-----------------------------------------------------------------------------------------------------

    }
}
