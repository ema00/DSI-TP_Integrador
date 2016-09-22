using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_TP_Integrador
{
    class GeneradorID
    {

        private int idActual;

        public GeneradorID()
        {
            //  Conectar a la persistencia
            //  Recibir el ID de la última persona registrada y guardarlo
        }


        public int getNuevaId()
        {
            //  Obtener el ID para una nueva persona y devolverlo
            this.idActual++;
            return idActual;
        }

    }
}
