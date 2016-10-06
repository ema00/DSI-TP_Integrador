/*
Clase: UsuarioSecretaria
Representa a un usuario de la Secretaría de Extensión. Desciende de la clase abstracta Persona.
Extiende la clase Persona, agregando un nombre de usuario y un password que
se usan para el acceso al sistema.
Este usuario es el encargado de dar de alta los alumnos, docentes, cursos cursadas y toma asistencia.
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DSI_TP_Integrador {

    sealed class UsuarioSecretaria : Persona {

        /* Variables de instancia */

        private string usuario;
        private string password;



        /* Constructores */

        public UsuarioSecretaria(uint id, uint dni, string apellido, string nombre, SexoT sexo, string usuario, string password) :
            base(id, dni, apellido, nombre, sexo) {
            this.Usuario = usuario;
            this.Password = password;
        }



        /* Accessors y Mutators */

        public string Usuario {
            get { return usuario; }
            set {
                if (string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentException("Nombre de usuario no válido", "Usuario");
                }
                usuario = value;
            }
        }


        public string Password {
            get { return password; }
            set {
                if (string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentException("Password no válido", "Password");
                }
                password = value;
            }
        }
    }

}
