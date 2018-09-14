using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_DianaTorres_JoseGalvis

    
{
    class Estado
    {



        private Boolean estaVisitado;


        private String valor;


        public Estado(String valor)
        {
            estaVisitado = false;
            this.valor = valor;
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
