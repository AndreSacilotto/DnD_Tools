using System;
using System.Windows.Forms;

namespace Battle_Simulator_DnD
{
    public partial class criaturaControl : UserControl
    {
        public criaturaControl()
        {
            InitializeComponent();
        }

        public string Nome
        {
            get { return txt_Nome.Text; }
            set { txt_Nome.Text = value; }
        }
        public decimal PV
        {
            get { return nUD_PV.Value; }
            set { nUD_PV.Value = value; }
        }
        public decimal CA
        {
            get { return nUD_CA.Value; }
            set { nUD_CA.Value = value; }
        }
        public decimal INI
        {
            get { return nUD_Ini.Value; }
            set { nUD_Ini.Value = value; }
        }
        public decimal BA
        {
            get { return nUD_BA.Value; }
            set { nUD_BA.Value = value; }
        }
        public decimal DMIN
        {
            get { return nUD_Dmin.Value; }
            set { nUD_Dmin.Value = value; }
        }
        public decimal DMAX
        {
            get { return nUD_Dmax.Value; }
            set { nUD_Dmax.Value = value; }
        }

        public event KeyEventHandler KeyD;

        protected void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (KeyD != null)
                KeyD(this, e);
            //KeyD?.Invoke(this, e);
        }
    }
}
