using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_DianaTorres_JoseGalvis
{
    public class Automata
    {

        private string tipo; //va a ser : MEALY | MOORE
        private Hashtable estadosConRespuestas;
        private Hashtable transiciones;

        private List<Estado> estados;
        private List<String> estimulos;
        private List<String> respuestas;


        //getters & setters
        public Hashtable EstadosConRespuestas { get => estadosConRespuestas; set => estadosConRespuestas = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public Hashtable Transiciones { get => transiciones; set => transiciones = value; }
        public List<Estado> Estados { get => estados; set => estados = value; }
        public List<string> Estimulos { get => estimulos; set => estimulos = value; }
        public List<string> Respuestas { get => respuestas; set => respuestas = value; }


        //constructor
        public Automata(string tipo, List<Estado> estados, List<String> estimulos, List<string> rpta)
        {
            this.Tipo = tipo;
            
            transiciones = new Hashtable();
            this.Estados = estados;
            this.Estimulos = estimulos;
            this.Respuestas = rpta;

            inicializarEstadosConRespuestas();
        }

        
        public void inicializarEstadosConRespuestas()
        {
            estadosConRespuestas = new Hashtable();
            switch (tipo)
            {
                case "MEALY":
                    foreach(Estado est in estados)
                    {
                        estadosConRespuestas.Add(est, "");
                    }
                    break;
                case "MOORE":

                    foreach(string res in respuestas)
                    {
                        estadosConRespuestas.Add(res, "");
                    }
                    break;
            }
        }





        //
        public void BFS()
        {
            //try
            //{
                reestablecerEstados();

                Estado estadoInicial = estados.First();
                estadoInicial.setEstaVisitado(true);
                Queue<string> cola = new Queue<string>();
                cola.Enqueue(estadoInicial.getValor());
                List<string> lista = new List<string>();

                while (cola.Count != 0)
                {
                    string actual = cola.Dequeue();
                    lista.Add(actual);
                    List<string> aux = new List<string>();

                    string t = transiciones[actual] + "";
                    string[] transActuales = t.Split(',');
                    for (int i = 0; i < transActuales.Length; i++)
                    {
                        aux.Add(transActuales[i]);
                    }

                    for (int i = 0; i < aux.Count; i++)
                    {
                        string sig = aux.ElementAt(i);
                        if (buscarEstado(sig).isEstaVisitado() == false)
                        {
                            buscarEstado(sig).setEstaVisitado(true);
                            cola.Enqueue(sig);
                        }


                    }
                }

                //for(int i=0;i<estados.Count;i++)
                //{
                    
                //    if (!estados.ElementAt(i).isEstaVisitado())
                //    {
                //        estados.RemoveAt(i);
                //    }
                //}

                List<Estado> e1 = estados.Where(e => e.isEstaVisitado() == true).ToList();
                estados = e1;
        //}
        //    catch (Exception ex)
        //    {
        //        throw new Exception("No se pudo encontrar el automata conexo equivalente. Intente de nuevo. ");
        //    }








        }



        public Estado buscarEstado(string valor)
        {
            
            return estados.Where(v => v.getValor().Equals(valor)).First();
        }






        //Este metodo reestablece el atributo de estaVisitado a false 
        //para todos los estados del automata
        public void reestablecerEstados()
        {
            for (int i = 0; i < estados.Count; i++)
            {
                estados.ElementAt(i).setEstaVisitado(false);
            }
        }


        /// <summary>
        /// PARTICIONAMIENTO
        /// </summary>
        /// <returns></returns>
        public List<List<string>> particionamiento()
        {
            List<List<string>> particion = new List<List<string>>();
            particion = particion1();

            ////Hash donde cada estado tiene el indice del conjunto en donde está 
            ////o cada uno tiene su indice guardado(atributo, ver clase Estado)
            //Hashtable estadosIndiceConjunto = new Hashtable();
            //foreach(Estado e in estados)
            //{
            //    int indiceEstado = buscarConjunto(e.getValor());
            //    estadosIndiceConjunto.Add(e.getValor(), indiceEstado);
            //}

            List<List<string>> particionAnterior = new List<List<string>>(); 
           

            //ver while
            while (particionAnterior != particion)
            {
                //recorro cada conjunto del particionamiento
                //i es el indice del conjunto actual
                for (int i = 0; i < particion.Count; i++)
                {
                    particionAnterior = particion;

                    particionUnConjunto(particion[i]);
                    particion = actualizarParticion(particion);
                }

                
            }
           


            return particion;
        }

        //Actualiza la particion en la lista de listas segun los indices de los conjuntos
        //donde pertenecen los estados
        public List<List<String>> actualizarParticion(List<List<String>> lista)
        {
            List<List<String>> particion = new List<List<string>>();


            for (int i=0; i < lista.Count; i++)
            {
                List<string> conjunto = new List<string>();
                int j = 0;

                foreach (Estado e in estados)
                {
                    if (e.IndiceConjunto == i)
                    {                        
                        conjunto[j] = e.getValor();
                        j++;
                    }

                }
            }
            return particion;
            
        }

        //Particiona 1 conjunto especifico de estados segun sus transiciones
        private void particionUnConjunto(List<string> conjunto)
        {
            
            foreach(string eActual in conjunto)
            {
                
                String[] tActual = transiciones[eActual].ToString().Split(',');

                foreach(string eSiguiente in conjunto)
                {
                    
                    String[] tSiguiente = transiciones[tActual].ToString().Split(',');

                    for(int i=0; i < estimulos.Count; i++)
                    {
                        Estado estadoActual = buscarEstado(tActual[i]);
                        Estado estadoSiguiente = buscarEstado(tSiguiente[i]);

                        if (estadoActual.IndiceConjunto != estadoSiguiente.IndiceConjunto)
                        {
                            estadoSiguiente.IndiceConjunto += 1;
                            break;
                        }
                    }
                    
                }
            }
            
        }

        
        //este metodo hace la particion 1
        //agrupa los estados segun sus respuestas
        //varía dependiendo del tipo de la maquina de estado
        public List<List<string>> particion1()
        {
            List<List<string>> particion = new List<List<string>>();

            if (tipo.Equals("MEALY"))
            {
                int i = 0;
                foreach(string eActual in EstadosConRespuestas)
                {
                    string resActual = estadosConRespuestas[eActual].ToString();
                    int j = 0;
                    foreach(string eSiguiente in EstadosConRespuestas)
                    {
                        if (EstadosConRespuestas[eActual].Equals(estadosConRespuestas[eSiguiente]))
                        {
                            particion[i][j] = eSiguiente;
                            buscarEstado(eSiguiente).IndiceConjunto = i;
                         j++;      
                        }
                    }
                    i++;
                }
            }else if (tipo.Equals("MOORE"))
            {
                int i = 0;
                foreach(string respuesta in EstadosConRespuestas)
                {
                    string[] esta = EstadosConRespuestas[respuesta].ToString().Split(',');
                    int j = 0;
                    foreach (string e in esta)
                    {

                        particion[i][j] = e;
                        buscarEstado(e).IndiceConjunto = i;
                        j++;
                    }
                    i++;
                }
            }

            return particion;
        }






    }
}
