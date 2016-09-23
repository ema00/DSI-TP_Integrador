using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_TP_Integrador
{
    public enum sexo {MASCULINO, FEMENINO};

    class Persona
    {
        public ulong id { set; get; }
        public ulong dni { set; get; }
        public string apellido { set; get; }
        public string nombre { set; get; }
        public string sexo { set; get; }
    }
}
