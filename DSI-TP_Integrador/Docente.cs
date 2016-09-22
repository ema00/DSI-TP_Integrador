﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_TP_Integrador
{
    class Docente : Persona
    {

        private string usuario;
        private string password;

        public Docente(int dni, string apellido, string nombre, string sexo, string usuario, string password)
        {

            GeneradorID generadorID = new GeneradorID();

            this.id = generadorID.getNuevaId();
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
            this.sexo = sexo;
            this.usuario = usuario;
            this.password = password;
        }

    }
}