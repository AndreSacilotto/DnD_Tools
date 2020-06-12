using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace dndQuiz_Form
{
    public partial class Form_Asks : Form
    {
        List<RadioButton> radio = new List<RadioButton>();

        string PerguntaAtual = string.Empty;
        string[] RespostaAtual;

        public int ReturnValue { get; set; }

        bool isBtn;

        public Form_Asks(string Pergunta, string[] Respostas)
        {
            PerguntaAtual = Pergunta;
            RespostaAtual = (string[]) Respostas.Clone();

            InitializeComponent();

            create_controls();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            RadioButton selected = null;

            foreach (RadioButton rb in radio) {
                if (rb.Checked) {
                    selected = rb;
                }
            }

            if (selected != null) {
                this.ReturnValue = (int)selected.Tag;
                isBtn = true;
                Close();
            }
            else
                MessageBox.Show("Selecione uma opção");
        }

        void create_controls() {

            lbl_Ask.Text = PerguntaAtual;

            int rLong = RespostaAtual.Length;

            for (int i = 0; i < rLong; i++) {
                RadioButton rdB = new RadioButton();
                //rdB.Name = $"rdB{i+1}";
                rdB.Tag = i;
                rdB.Text = RespostaAtual[i];

                rdB.AutoSize = true;
                rdB.Location = new Point(30, 30 * (i+1) + 20);

                this.Controls.Add(rdB);
                radio.Add(rdB);
            }

            btn_Next.Location = new Point(30, 30 * rLong + 60);
            this.AutoSize = true;
        }

        private void Form_Asks_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtn == false)
            {
                DialogResult result = Create_formDialog();
                switch (result)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true; break;

                    case DialogResult.Abort:
                        Environment.Exit(0); break;
                }
            }
        }

        DialogResult Create_formDialog() {

            Form forma = new Form();

            forma.FormBorderStyle = FormBorderStyle.FixedDialog;
            forma.StartPosition = FormStartPosition.CenterParent;
            forma.ControlBox = false;
            forma.Text = "Escolha o que deseja fazer";
            forma.Size = new Size(195, 100);

            create_btn(forma, "Cancelar", 10, DialogResult.Cancel);
            create_btn(forma, "Sair", 90, DialogResult.Abort);

            return forma.ShowDialog();
        }

        void create_btn(Form forma, string nome, int pos, DialogResult DR) {
            Button btn = new Button();
            btn.Size = new Size(75, 25);
            btn.Location = new Point(pos, 15);
            btn.Text = nome;
            btn.Name = $"btn{nome}";
            btn.DialogResult = DR;
            forma.Controls.Add(btn);
        }
    }
}
