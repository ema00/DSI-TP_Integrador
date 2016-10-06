/*
Clase: Persona
Representa una persona. Tiene toda la información referente a una persona.
El identificador único id se usa para la persistencia.
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DSI_TP_Integrador {

    public abstract class Persona {

        /* Variables de instancia */

        private readonly uint id;
        private uint dni;
        private string apellido;
        private string nombre;
        private SexoT sexo;



        /* Constructores */

        public Persona(uint id, uint dni, string apellido, string nombre, SexoT sexo) {
            if(id < 0) {
                throw new ArgumentException("Persona: Valor no válido para el parámetro.", "Id");
            }
            this.id = id;
            this.DNI = dni;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Sexo = sexo;
        }
        


        /* Accessors y Mutators */

        public uint Id {
            get { return id; }
        }


        public uint DNI {
            get { return dni; }
            set {
                if(value < 0) {
                    throw new ArgumentException("Persona: Valor no válido para el parámetro.", "DNI");
                }
                else { dni = value; }
            }
        }


        public string Apellido {
            get { return apellido; }
            set { apellido = value; }
        }


        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }


        public SexoT Sexo {
            get { return sexo; }
            set {
                if(value != SexoT.FEMENINO || value != SexoT.MASCULINO) {
                    throw new ArgumentException("Persona: Valor no válido para el parámetro.", "Sexo");
                }
                else { sexo = value; }
            }
        }



        /* Tipos internos de la clase */

        public enum SexoT { MASCULINO, FEMENINO };
    }
}
