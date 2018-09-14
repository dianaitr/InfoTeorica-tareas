using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_DianaTorres_JoseGalvis
{
    class AutomataDiana
    {

        private string tipo; //va a ser : MEALY | MOORE
        private Hashtable estadosConRespuestas;
        private Hashtable transiciones;

        //getters & setters
        public Hashtable EstadosConRespuestas { get => estadosConRespuestas; set => estadosConRespuestas = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public Hashtable Transiciones { get => transiciones; set => transiciones = value; }


        //constructor
        public AutomataDiana(string tipo)
        {
            this.Tipo = tipo;
            estadosConRespuestas = new Hashtable();
            transiciones = new Hashtable();
        }

        //
        public List<String> BFS()
        {
            //grafo, n


            //grafo.reestablecerNodos();

            //		if (grafo.existeNodo(n)) {

            //			LinkedList<N> cola = new LinkedList<N>();
            //        cola.add(n);
            //			grafo.buscarNodo(n).setEstaVisitado(true);
            //        ArrayList<N> array = new ArrayList<N>();
            //			while (!cola.isEmpty()) {
            //				N actual = cola.poll();
            //        array.add(actual);
            //				ArrayList<N> aux = grafo.darAdyacentes(actual);
            //				for (int i = 0; i<aux.size(); i++) {
            //					N sig = aux.get(i);
            //					if (grafo.buscarNodo(sig).isEstaVisitado() == false) {
            //						grafo.buscarNodo(sig).setEstaVisitado(true);
            //        cola.add(sig);
            //					}
            return null;
        }



    }
}
