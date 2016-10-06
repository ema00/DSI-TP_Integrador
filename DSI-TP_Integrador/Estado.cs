/*
Clase: Estado
Representa el estado de una clase de una cursada.
Esto se usa para reconocer si el curso está pendiente de inicio, cancelado,
iniciado, o terminado.
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DSI_TP_Integrador {

    public class Estado {

        /* Variables de Instancia */

        private EstadoCursada estado;



        /* Constructores */

        
        
        
        /* Métodos */

        
        

        /* Tipos internos de la clase */

        public enum EstadoCursada {
            NO_INICIADO,
            CANCELADO,
            INICIADO,
            TERMINADO
        };

    }
}
