using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DSI_TP_Integrador {

    sealed class Alumno : Persona {

        /* Constructores */

        public Alumno(uint id, uint dni, string apellido, string nombre, SexoT sexo) :
            base(id, dni, apellido, nombre, sexo) { ; }

        }

}
