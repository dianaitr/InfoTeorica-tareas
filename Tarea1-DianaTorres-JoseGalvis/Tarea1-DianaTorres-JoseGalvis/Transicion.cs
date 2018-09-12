using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_DianaTorres_JoseGalvis
{
    class Transicion
    {
        private string estimulo;
        private string respuesta;

        private Estado llegada;
        private Estado salida;

        public Transicion(string estimulo, string respuesta, Estado llegada, Estado salida)
        {
            this.Estimulo = estimulo;
            this.Respuesta = respuesta;
            this.Llegada = llegada;
            this.Salida = salida;
        }

        public string Estimulo { get => estimulo; set => estimulo = value; }
        public string Respuesta { get => respuesta; set => respuesta = value; }
        internal Estado Salida { get => salida; set => salida = value; }
        internal Estado Llegada { get => llegada; set => llegada = value; }
    }
}
