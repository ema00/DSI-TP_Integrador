/*
Interfaz: IMapperCursada
Interfaz que debe implementar la clase de persistencia para los objetos
de la clase Cursada.
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DSI_TP_Integrador {

    interface IMapperCursada {

        Cursada getCursadaPorId(uint id);

        HashSet<Cursada> getCursadasPorFecha(DateTime fechaMenor, DateTime fechaMayor);

        Cursada cursadasActivas();

        HashSet<Cursada> cursadasActivas(uint idDocente);

        void guardarCursada(Cursada cursada);

    }

}
