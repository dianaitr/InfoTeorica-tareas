using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_DianaTorres_JoseGalvis
{
    class Estado
    {
        private string valor;
        private string respuestaMoore;

        public Estado(string valor, string respuestaMoore)
        {
            this.Valor = valor;
            this.RespuestaMoore = respuestaMoore;
        }

        public string Valor { get => valor; set => valor = value; }
        public string RespuestaMoore { get => respuestaMoore; set => respuestaMoore = value; }
    }
}
