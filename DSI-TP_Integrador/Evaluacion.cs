/*
Clase: Evaluacion
Representa una evaluación de un determinado curso (cursada) en particular.
Cada evaluación tiene un identificador único (para persistencia), una fecha, y un diccionario
en el cual están todos los alumnos que cursan; en este diccionario, cuya clave es un objeto
persona, el valor es un byte que indica la nota de la evaluación.
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DSI_TP_Integrador {

    class Evaluacion {

        /* Variables de Instancia */

        private readonly uint id;
        private readonly DateTime fecha;
        private Dictionary<Persona,byte> notas;



        /* Constructores */

        Evaluacion(uint id, DateTime fecha) {
            this.id = id;
            this.fecha = fecha;
        }



        /* Accessors y Mutators */

        public uint Id {
            get { return id; }
        }


        public DateTime Fecha {
            get { return fecha; }
        }



        /* Métodos */

        /// <summary>
        /// Actualiza las notas de un grupo de alumnos.
        /// </summary>
        public void actualizar(Dictionary<Persona, byte> notas) {
            foreach(Persona alumno in notas.Keys) {
                actualizar(alumno, notas[alumno]);
            }
        }



        /// <summary>
        /// Actualiza la nota de un alumno.
        /// </summary>
        public void actualizar(Persona alumno, byte nota) {
            if (this.notas.Keys.Contains(alumno)) {
                this.notas[alumno] = nota;
            }
            else {
                throw new KeyNotFoundException("El alumno no está en la lista de alumnos del curso.");
            }
        }

    }

}
