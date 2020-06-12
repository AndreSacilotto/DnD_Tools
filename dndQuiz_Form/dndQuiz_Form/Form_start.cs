using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace dndQuiz_Form
{
    public partial class Form_start : Form
    {

        //enum n_Classes { Barbaro, Bardo, Bruxo, Clerigo, Druida, Feiticeiro, Guerreiro, Ladino, Mago, Monge, Paladino, Patrulheiro };

        bool[] Classes = new bool[12]; //new bool[n_Classes.GetValues(typeof(n_Classes)).Length];

        struct ListElement
        {
            public int id;
            public string palavra;
        }
        
        List<string> quiz_Perg = new List<string>();
        List<ListElement> quiz_Resp = new List<ListElement>();

        int numPerguntas;
        bool endP1;

        public Form_start()
        {
            InitializeComponent();
            Ler_Arquivo("Perguntas");
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //see_values();
            new_quiz();
        }

        void question_end(int slcOpc)
        {
            SetData seter = new SetData();
            int[][] sequencias = seter.Estados_transicao();
            int[,] transDes = seter.Estados_Desabilitador();

            endP1 = false;
            bool alreadyDone = false;
            for (int i = 0; i < sequencias.Length; i++)
            {
                alreadyDone = PergSelector(i, sequencias[i], slcOpc);
                if (alreadyDone == true)
                    break;
            }

            if (endP1 == true)
            {
                Classes[transDes[numPerguntas-4, slcOpc]] = true;
                Ler_Arquivo("SubPerguntas");
                numPerguntas = Array.FindIndex(Classes, x => x == true);
                new_quiz();
            }
            else
                new_quiz();
        }

        bool PergSelector (int numPer, int[] Next, int slcOpc){

            if (numPer == numPerguntas)
                for (int i = 0; i < Next.Length; i++)
                    if (slcOpc == i)
                    {
                        if (Next[i] != -1)
                            numPerguntas = Next[i];
                        else
                            endP1 = true;
                        return true;
                    }
             return false;
        }

        void see_values()
        {
            string lista = string.Empty;

            for (int i = 0; i < quiz_Perg.Count; i++)
            {
                lista += $"{i} {quiz_Perg[i]}\n";

                foreach (var x in quiz_Resp)
                {
                    if (x.id == i)
                        lista += $"{x.id} {x.palavra}\n";
                }
                lista += '\n';
            }
            MessageBox.Show(lista);
        }

        void Ler_Arquivo(string arquivo)
        {
            int maxPerguntas = 0;
            numPerguntas = 0;

            quiz_Perg.Clear();
            quiz_Resp.Clear();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load($"{arquivo}.xml");

            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                quiz_Perg.Add(node.Attributes[0].InnerText); //adiciona a chave
                foreach (XmlNode chield in node.ChildNodes)
                {
                    ListElement save = new ListElement();
                    save.id = maxPerguntas;
                    save.palavra = chield.InnerText;
                    quiz_Resp.Add(save); //adiciona os outros
                }
                maxPerguntas++;
            }
        }

        void new_quiz() {

            List<string> toPass = new List<string>();
            foreach (var x in quiz_Resp) {
                if (x.id == numPerguntas)
                    toPass.Add(x.palavra);
            }

            Form_Asks f = new Form_Asks(quiz_Perg[numPerguntas], toPass.ToArray());
            this.Hide();

            f.ShowDialog();

            if (endP1 == false)
                question_end(f.ReturnValue);
            else
                last_question(f.ReturnValue);
        }

        void last_question(int slcOpc)
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load($"endQuiz.xml");

            string txtClasse = string.Empty, txtSub = string.Empty;

            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                if (node.Attributes[0].InnerText == string.Concat(numPerguntas, slcOpc+1))
                {
                    txtClasse = node.FirstChild.InnerText;
                    txtSub = node.LastChild.InnerText;
                }
            }

            Form_End end = new Form_End(txtClasse, txtSub);
            end.Show();
        }
    }
}
