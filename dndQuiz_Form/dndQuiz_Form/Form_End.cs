using System;
using System.Drawing;
using System.Windows.Forms;

namespace dndQuiz_Form
{
    public partial class Form_End : Form
    {


        public Form_End(string _classe, string _subC)
        {
            InitializeComponent();
            txt_Classe.Text = _classe;
            txt_subClasse.Text = _subC;
            picB_Image.Image = (Image)Properties.Resources.ResourceManager.GetObject(_classe);
        }


        private void Form_End_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
