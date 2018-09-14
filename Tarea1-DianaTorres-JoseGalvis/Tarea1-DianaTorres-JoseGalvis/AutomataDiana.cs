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

        //metodo organizar estadosConRespuestas segun tipo
        public void inicializarEstadosConRespuestas()
        {
            switch (tipo)
            {
                case "MEALY":

                    break;
                case "MOORE":

                    break;
            }
        }
      






    }
}
