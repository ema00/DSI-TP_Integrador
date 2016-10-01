using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_TP_Integrador
{
    public class Cursada
    {

        private ulong id;
        private ulong cupoMin;
        private ulong cupoMax;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private byte aula;
     //   private Curso curso;    //  Referencia a la clase Curso. Hay que definir clase Curso.
      //  private List<Clase> clases; //  Lista de clases de la cursada. Hay que definir la clase Clase.
        private Estado estado;
        private Docente docente;
     //   private List<Alumno> inscriptos; //  Lista de alumnos inscriptos de la cursada. Hay que definir la clase Alumno.
        private List<Evaluacion> evaluaciones;

        //  Constructor de una cursada en particular.
        //  Alternativa: En lugar de pasarle la lista de clases a la cursada en el constructor,
        //  también podría añadirse una a una las clases a la lista de la cursada particular con un método addClase().
        public Cursada(ulong id, ulong cupoMin, ulong cupoMax, DateTime fechaInicio, DateTime fechaFin, byte aula/*, Curso curso, List<Clase> clases*/, Docente docente)
        {
            this.id = id;
            this.cupoMin = cupoMin;
            this.cupoMax = cupoMax;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.aula = aula;
        //    this.curso = curso;
         //   this.clases = clases;
            this.estado.estadoActual = (int)Estado.EstadoCursada.NO_INICIADO;
            this.docente = docente;
        }

        public void cambiarEstado(int estado)
        {
            this.estado.estadoActual = estado;
        }

   /*     public void addAlumno(Alumno alumno)
        {
            this.inscriptos.Add(alumno);
        }*/

        public void addEvaluacion(Evaluacion evaluacion)
        {
            this.evaluaciones.Add(evaluacion);
        }
    }
}
