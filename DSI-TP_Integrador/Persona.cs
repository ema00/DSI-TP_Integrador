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

        public int id { set; get; }
        public long dni { set; get; }
        public string apellido { set; get; }
        public string nombre { set; get; }
        public string sexo { set; get; }


    }
}
