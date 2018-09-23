using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_DianaTorres_JoseGalvis

    
{
   public  class Estado
    {
        /// <summary>
        /// ////////
        /// </summary>


        private Boolean estaVisitado;


        private String valor;

        private int indiceConjunto;

        public int IndiceConjunto { get => indiceConjunto; set => indiceConjunto = value; }

        public Estado(String valor)
        {
            estaVisitado = false;
            this.valor = valor;
            indiceConjunto = 0;
        }

        public Boolean isEstaVisitado()
        {
            return estaVisitado;
        }

        public void setEstaVisitado(Boolean vi)
        {
            estaVisitado = vi;
        }

        public String getValor()
        {
            return valor;
        }
    }
}
