using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DSI_TP_Integrador {

    interface IMapperAlumno {

        Alumno getAlumnoPorDNI(uint DNI);

        Alumno getAlumnoPorId(uint id);

        HashSet<Alumno> getAlumnosPorApellido(string apellido);

        void guardarAlumno(Alumno alumno);

    }

}
