using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Battle_Simulator_DnD
{
    public class Criatura
    {
        public string Nome { get; set; }
        public int PV { get; set; }
        public decimal CA { get; set; }
        public decimal INI { get; set; }
        public decimal BA { get; set; }
        public decimal DMIN { get; set; }
        public decimal DMAX { get; set; }
    }

    public class GrupoAtr
    {
        private List<string> nome = new List<string>();
        private List<int> pv = new List<int>();
        private List<int> ca = new List<int>();
        private List<int> ini = new List<int>();
        private List<int> ba = new List<int>();
        private List<int> dmin = new List<int>();
        private List<int> dmax = new List<int>();

        public List<string> Nome { get => nome; set => nome = value; }
        public List<int> Pv { get => pv; set => pv = value; }
        public List<int> Ca { get => ca; set => ca = value; }
        public List<int> Ini { get => ini; set => ini = value; }
        public List<int> Ba { get => ba; set => ba = value; }
        public List<int> Dmin { get => dmin; set => dmin = value; }
        public List<int> Dmax { get => dmax; set => dmax = value; }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            //box.SelectionColor = box.ForeColor;
        }
    }


}
