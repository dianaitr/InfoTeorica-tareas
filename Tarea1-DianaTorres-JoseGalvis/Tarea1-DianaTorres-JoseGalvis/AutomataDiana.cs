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


        //A PASAR
        
        //metodo organizar estadosConRespuestas segun tipo
        public void inicializarEstadosConRespuestas(List<Estado> estado, List<String> respuesta)
        {
            switch (tipo)
            {
                case "MEALY":

                    foreach(var est in estado)
                    {
                        estadosConRespuestas.Add(est, respuesta);
                    }
                    

                    break;
                case "MOORE":

                    estadosConRespuestas.Add(respuesta, estado);
                    break;
            }
        }
      






    }
}
