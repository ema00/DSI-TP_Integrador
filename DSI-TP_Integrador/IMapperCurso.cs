/*
Interfaz: IMapperCurso
Interfaz que debe implementar la clase de persistencia para los objetos
de la clase Curso.
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DSI_TP_Integrador {

    interface IMapperCurso {

        Curso getCursoPorId(uint id);

        HashSet<Curso> getCursosPorTema(string tema);

        HashSet<Curso> getCursosPorNombre(string nombre);

        void guardarCurso(Curso curso);

    }

}
