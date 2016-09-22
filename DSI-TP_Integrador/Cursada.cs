using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_TP_Integrador
{
    class Cursada
    {

        private int id;
        private int cupoMin;
        private int cupoMax;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private byte aula;

        public Cursada() {

        GeneradorID generadorID = new GeneradorID();

            this.id = generadorID.getNuevaId();
            this.cupoMin = cupoMin;
            this.cupoMax = cupoMax;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.aula = aula;


        }
    }
}
