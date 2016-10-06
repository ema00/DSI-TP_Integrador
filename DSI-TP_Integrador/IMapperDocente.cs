/*
Interfaz: IMapperDocente
Interfaz que debe implementar la clase de persistencia para los objetos
de la clase Docente.
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DSI_TP_Integrador {

    interface IMapperDocente {

        Docente getDocentePorDNI(uint DNI);

        Docente getDocentePorId(uint id);

        HashSet<Docente> getDocentesPorApellido(string apellido);

        void guardarDocente(Docente docente);

    }

}
