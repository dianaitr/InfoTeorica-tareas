using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1_DianaTorres_JoseGalvis
{
    public partial class InterfazPrincipal : Form
    {
        private VentanaAutomata ventana;

        private Automata automata;
        public InterfazPrincipal()
        {
            InitializeComponent();
        }

        //se crean los estados y estimulos/rpta del automata
        private void btnDefinirAutomata_Click(object sender, EventArgs e)
        {
            List<Estado> estados = new List<Estado>();           
            string[] esta = txtEstados.Text.Split(',');
            foreach (string a in esta) { estados.Add(new Estado(a)); }

            List<string> estimulos = new List<string>();
            string[] es = txtEstimulos.Text.Split(',');
            foreach (string a in es) {estimulos.Add(a); }

            List<string> rpa = new List<string>();
            string[] r = txtRpta.Text.Split(',');
            foreach (string rp in r) { rpa.Add(rp); }

            automata = new Automata(boxTipo.Text, estados, estimulos, rpa);

            ventana = new VentanaAutomata(this, automata);
            ventana.Visible = true;
            this.Visible = false;
        }
    }
}
