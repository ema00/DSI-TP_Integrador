using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DSI_TP_Integrador {

    internal sealed class Clase {

        /* Variables de instancia */

        private readonly ulong id;
        private readonly DateTime fecha;
        private readonly byte numero;
        private Dictionary<Persona, bool> presentes;



        /* Constructores */

        public Clase(ulong id, DateTime fecha, byte numero) {
            this.id = id;
            this.fecha = fecha;
            this.numero = numero;
            presentes = new Dictionary<Persona, bool>();
        }



        /* Accessors y Mutators */

        public ulong Id {
            get { return id; }
        }


        public DateTime Fecha {
            get { return fecha; }
        }


        public byte Numero {
            get { return numero; }
        }


        internal Dictionary<Persona, bool> Presentes {
            get { return presentes; }
            set { presentes = value; }
        }
    }
}
