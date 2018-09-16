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
    public partial class VentanaAutomata : Form
    {
        private InterfazPrincipal i;
        private Automata automata;

        public VentanaAutomata(InterfazPrincipal i, Automata au)
        {
            InitializeComponent();
            this.i = i;
            automata = au;
            inicializarAutomataEnPantalla();
            
        }

        public void inicializarAutomataEnPantalla()
        {
            if (automata.Tipo.Equals("MEALY")){ lblTipoAutomata.Text = "Tabla de transiciones de máquina de estado Mealy";
                
            }
            else if (automata.Tipo.Equals("MOORE")) { lblTipoAutomata.Text = "Tabla de transiciones de máquina de estado Moore";
                
            }
            
            iniciarCombosBox();
            iniciarTabla();
        }

        public void iniciarTabla()
        {
            foreach(string estimulo in automata.Estimulos)
            {
                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = estimulo;
                columna.Width = 80;

                tabla.Columns.Add(columna);
            }
            if (automata.Tipo.Equals("MOORE"))
            {
                DataGridViewTextBoxColumn column= new DataGridViewTextBoxColumn();
                column.HeaderText = "Respuesta";
                column.Width = 80;

                tabla.Columns.Add(column);
            }
        }

        public void iniciarCombosBox()
        {
            foreach(Estado es in automata.Estados)
            {
                comboSalida.Items.Add(es.getValor());
                comboLlegada.Items.Add(es.getValor());
            }

            foreach(string est in automata.Estimulos)
            {
                comboEstimulo.Items.Add(est);
            }

            foreach (string rpta in automata.Respuestas)
            {
                comboRespuesta.Items.Add(rpta);
            };
        
        }

        

        public Automata Automata { get => automata; set => automata = value; }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            i.Visible = true;
        }
    }
}
