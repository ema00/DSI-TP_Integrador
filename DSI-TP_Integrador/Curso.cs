﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DSI_TP_Integrador {

    public class Curso {

        /* Variables de instancia */

        private uint id;
        private string nombre;
        private string descripcion;
        private string tipo;



        /* Constructores */

        Curso(uint id, string nombre, string descripcion, string tipo) {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.tipo = tipo;
        }



        /* Accessors y Mutators */

        public uint Id {
            get { return id; }
            set { id = value; }
        }


        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }


        public string Descripcion {
            get { return descripcion; }
            set { descripcion = value; }
        }


        public string Tipo {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
