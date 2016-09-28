using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSI_TP_Integrador
{

    /* Esta clase define el formulario visible al usuario que le permitirá tomar asistencia
     * en las clases    */
    public partial class frmAsistencias : Form
    {
        public frmAsistencias()
        {
            InitializeComponent();
        }

        private void frmAsistencias_Load(object sender, EventArgs e)
        {
            //  Conectar a la base de datos
            //  Obtener lista de cursadas
            //  Mostrar la lista de cursadas
        }

        private void lstCursadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Obtener la cursada seleccionada
            string cursadaSeleccionada = (string)lstCursadas.SelectedItem;
            //  Buscar la cursada en la lista de cursadas
            //  Obtener las clases de la cursada
            //  Mostrar la lista de clases en la cursada
        }

        private void lstClases_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Obtener la cursada seleccionada
            object cursadaSeleccionada = lstCursadas.SelectedItem;
            //  Buscar la cursada en la lista de cursadas
            //  Obtener los alumnos inscriptos en la cursada
        }

        private void btnTomarAsistencia_Click(object sender, EventArgs e)
        {
            //  Obtener todos los alumnos seleccionados de la lista de alumnos
            //  Registrar en la clase los alumnos presentes
            //  Enviar a la base de datos los cambios
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //  Cerrar la conexión a la base de datos
            //  Abrir Menú
            //  Cerrar Asistencias
            this.Close();
        }
    }
}
