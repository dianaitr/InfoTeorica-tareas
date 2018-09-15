using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_DianaTorres_JoseGalvis
{
    class Automata
    {
        
        private string tipo; //va a ser : MEALY | MOORE
        private Hashtable estadosConRespuestas;
        private Hashtable transiciones;

        private List<Estado> estados;
        private List<String> rptas;


        //getters & setters
        public Hashtable EstadosConRespuestas { get => estadosConRespuestas; set => estadosConRespuestas = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public Hashtable Transiciones { get => transiciones; set => transiciones = value; }
        public List<Estado> Estados { get => estados; set => estados = value; }


        //constructor
        public Automata(string tipo, List<Estado> estados)
        {
            this.Tipo = tipo;
            estadosConRespuestas = new Hashtable();
            transiciones = new Hashtable();
            this.Estados = estados;
        }

        //metodo organizar estadosConRespuestas segun tipo
        public void inicializarEstadosConRespuestas( String estado, String respuesta)
        {
            switch (tipo)
            {
                case "MEALY":
                    if (estadosConRespuestas[estado].Equals(null))
                    {
                        List<string> lista = new List<string>();
                        lista.Add(respuesta);
                        estadosConRespuestas.Add(estado, lista);
                        
                    }

                    //List<string> listMealy = estadosConRespuestas[estado];

                        //estadosConRespuestas.Add(estado, listMealy);
                    
                    break;
                case "MOORE":

                    //estadosConRespuestas.Add(respuesta, estado);
                    break;
            }
        }


        


        //
        public void BFS()
        {
            //grafo.reestablecerNodos();

            //if (grafo.existeNodo(n))
            //{

            //    LinkedList<N> cola = new LinkedList<N>();
            //    cola.add(n);
            //    grafo.buscarNodo(n).setEstaVisitado(true);
            //    ArrayList<N> array = new ArrayList<N>();
            //    while (!cola.isEmpty())
            //    {
            //        N actual = cola.poll();
            //        array.add(actual);
            //        ArrayList<N> aux = grafo.darAdyacentes(actual);
            //        for (int i = 0; i < aux.size(); i++)
            //        {
            //            N sig = aux.get(i);
            //            if (grafo.buscarNodo(sig).isEstaVisitado() == false)
            //            {
            //                grafo.buscarNodo(sig).setEstaVisitado(true);
            //                cola.add(sig);
            //            }
            //      



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

            
        }



        public Estado buscarEstado(string valor)
        {
            return estados.Where(v => v.Equals(valor)).First();
        }






        //Este metodo reestablece el atributo de estaVisitado a false 
        //para todos los estados del automata
        public void reestablecerEstados()
        {
            for(int i = 0; i < estados.Count; i++)
            {
                estados.ElementAt(i).setEstaVisitado(false);
            }
        }


        






    }
}
