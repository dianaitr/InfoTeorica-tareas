using System;
using System.Collections;
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

        private Hashtable rowsNames;

        public VentanaAutomata(InterfazPrincipal i, Automata au)
        {
            InitializeComponent();
            this.i = i;
            automata = au;
            inicializarAutomataEnPantalla();
            columnasTabla();

            btn_automataMinimo.Enabled = false;

        }

        private Hashtable columnsNames;
        public void columnasTabla()
        {
            columnsNames = new Hashtable();
            for (int i = 0; i < tabla.ColumnCount; i++)
            {
                columnsNames.Add(tabla.Columns[i].HeaderText + "", i);
            }
        }


        public void inicializarAutomataEnPantalla()
        {
            if (automata.Tipo.Equals("MEALY"))
            {
                lblTipoAutomata.Text = "Tabla de transiciones de máquina de estado Mealy";

            }
            else if (automata.Tipo.Equals("MOORE"))
            {
                lblTipoAutomata.Text = "Tabla de transiciones de máquina de estado Moore";

            }

            iniciarCombosBox();
            iniciarTabla();
        }

        public void iniciarTabla()
        {
            foreach (string estimulo in automata.Estimulos)
            {
                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = estimulo;
                columna.Width = 80;

                tabla.Columns.Add(columna);
            }
            if (automata.Tipo.Equals("MOORE"))
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = "Respuesta";
                column.Width = 80;

                tabla.Columns.Add(column);
            }

            rowsNames = new Hashtable();
            int i = 0;
            foreach (Estado estado in automata.Estados)
            {
                tabla.Rows.Add(estado.getValor());

                //para hash de filas
                rowsNames.Add(estado.getValor(), i);
                i++;
            }
        }

        public void iniciarCombosBox()
        {
            foreach (Estado es in automata.Estados)
            {
                comboSalida.Items.Add(es.getValor());
                comboLlegada.Items.Add(es.getValor());
            }

            foreach (string est in automata.Estimulos)
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

        private void btnAgregarTransicion_Click(object sender, EventArgs e)
        {
            try
            {
                Hashtable transiciones = automata.Transiciones;
                if (transiciones.ContainsKey(comboSalida.Text))
                {
                    string[] valoresT = transiciones[comboSalida.Text].ToString().Split(',');
                    string est = columnsNames[comboEstimulo.Text].ToString();
                    int indexEstimulo = Int32.Parse(est);

                    string salida = rowsNames[comboSalida.Text].ToString();
                    int indexSalida = Int32.Parse(salida);

                    Boolean estaLlena = false;
                    if (tabla.Rows[indexSalida].Cells[indexEstimulo].Value != null)
                    {
                        estaLlena = true;
                        throw new Exception("Ya existe una transición con estimulo " + comboEstimulo.Text + " desde " + comboSalida.Text);
                    }
                    else if (estaLlena == false)
                    {

                        Boolean igual = false;
                        //for (int i = 0; i < valoresT.Length; i++)
                        //{
                        //    if (valoresT[0].Equals(comboLlegada.Text))
                        //    {
                        //        igual = true;
                        //        throw new Exception("La transición ya existe. Cambie el estado de llegada.");
                        //    }
                        //    break;
                        //}

                        if (igual == false)
                        {
                            //agrega transicion a hash de transiciones en el mundo
                            string llegadas = transiciones[comboSalida] + "," + comboLlegada.Text;
                            transiciones[comboSalida] = llegadas;

                            agregarTransicionTabla(comboLlegada.Text);




                        }
                    }


                }
                else
                {
                    transiciones.Add(comboSalida.Text, comboLlegada.Text);
                    agregarTransicionTabla(comboLlegada.Text);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //}







        public void agregarTransicionTabla(string llegada)
        {
            if (automata.Tipo.Equals("MEALY"))
            {
                //agrega a tabla

                string est = columnsNames[comboEstimulo.Text].ToString();
                int indexEstimulo = Int32.Parse(est);

                string salida = rowsNames[comboSalida.Text].ToString();
                int indexSalida = Int32.Parse(salida);

                tabla.Rows[indexSalida].Cells[indexEstimulo].Value = llegada + " " + comboRespuesta.Text;
                //falta concatenar con rptas respectivas





            }
            else if (automata.Tipo.Equals("MOORE"))
            {
                string est = columnsNames[comboEstimulo.Text].ToString();
                int indexEstimulo = Int32.Parse(est);

                string salida = rowsNames[comboSalida.Text].ToString();
                int indexSalida = Int32.Parse(salida);

                //rpta
                string respuesta = columnsNames["Respuesta"].ToString();
                int indexrespuesta = Int32.Parse(respuesta);

                if (tabla.Rows[indexSalida].Cells[indexrespuesta].Value != null && !tabla.Rows[indexSalida].Cells[indexrespuesta].Value.Equals(comboRespuesta.Text))
                {
                    throw new Exception("En Moore, la respuesta no varía. Ingrese una transición válida");

                }
                else
                {
                    //agrega a tabla

                    tabla.Rows[indexSalida].Cells[indexEstimulo].Value = llegada;

                    tabla.Rows[indexSalida].Cells[indexrespuesta].Value = comboRespuesta.Text;



                }


            }
        }

        public void actualizarAutomataTabla()
        {
            tabla.Rows.Clear();

            foreach (Estado e in automata.Estados)
            {

                int n = tabla.Rows.Add(e.getValor());
                if (automata.Tipo.Equals("MEALY"))
                {
                    string valor = e.getValor();
                    string transi = automata.Transiciones[valor] + "";
                    string resp = automata.EstadosConRespuestas[valor] + "";

                    string[] transiciones = transi.Split(',');
                    string[] respuestas = resp.Split(',');

                    for (int j = 1; j < automata.Estimulos.Count + 1; j++)
                    {
                        tabla.Rows[n].Cells[j].Value = transiciones[j - 1] + " " + respuestas[j - 1];
                    }


                }
                else
                {
                    string valor = e.getValor();
                    string transi = automata.Transiciones[valor] + "";
                    string respuesta = automata.EstadosConRespuestas[valor] + "";

                    string[] transiciones = transi.Split(',');


                    for (int j = 1; j < automata.Estimulos.Count + 2; j++)
                    {
                        if (j < automata.Estimulos.Count + 1)
                        {
                            tabla.Rows[n].Cells[j].Value = transiciones[j - 1];
                        }
                        else
                        {
                            tabla.Rows[n].Cells[j].Value = respuesta;
                        }

                    }
                }

            }
        }

        private void btnAutomataConexo_Click(object sender, EventArgs e)
        {
            btnAgregarTransicion.Enabled = false;
            automata.BFS();
            actualizarAutomataTabla();
            //asignarEstadosConRespuestas();
            btn_automataMinimo.Enabled = true;
        }

        private void btnCompletarAutomata_Click(object sender, EventArgs e)
        {

            Hashtable hTransiciones = new Hashtable();
            Hashtable hRespuestas = new Hashtable();


            for (int i = 0; i < automata.Estados.Count; i++)
            {
                string estado = tabla.Rows[i].Cells[0].Value + "";
                string transi = "";
                string resp = "";
                for (int j = 1; j < tabla.Rows[i].Cells.Count; j++)
                {

                    if (automata.Tipo.Equals("MOORE"))
                    {
                        if (j != tabla.Rows[i].Cells.Count - 1)
                        {
                            transi += tabla.Rows[i].Cells[j].Value + "";
                            if (j < tabla.Rows[i].Cells.Count - 2)
                            {
                                transi += ",";
                            }
                        }
                        else
                        {
                            resp = tabla.Rows[i].Cells[j].Value + "";
                        }
                    }
                    else
                    {
                        string d = tabla.Rows[i].Cells[j].Value + "";

                        string[] datos = d.ToString().Split(' ');
                        transi += datos[0];
                        resp += datos[1];

                        if (j < tabla.Rows[i].Cells.Count - 1)
                        {
                            transi += ",";
                            resp += ",";
                        }
                    }


                }

                hTransiciones.Add(estado, transi);
                hRespuestas.Add(estado, resp);


            }

            automata.EstadosConRespuestas = hRespuestas;
            automata.Transiciones = hTransiciones;

            btnAutomataConexo.Show();
        }

        private void btn_automataMinimo_Click(object sender, EventArgs e)
        {
            List<List<string>> particionFinal = automata.particionamiento();

            string partic = "";
            string conjunt = "";
            foreach (List<string> conjunto in particionFinal)
            {
                partic += conjunt;
                conjunt = "";
                conjunt += "{";
                for (int i = 0; i < conjunto.Count; i++)
                {
                    string estado = conjunto[i];
                    conjunt += estado + ",";
                }
                conjunt += "}";
            }

            particionamientoFinal.Text = partic;

        }
    }
}
