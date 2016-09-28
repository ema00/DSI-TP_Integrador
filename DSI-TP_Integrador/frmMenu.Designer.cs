namespace DSI_TP_Integrador
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdministrarCursos = new System.Windows.Forms.Button();
            this.btnAdministrarCursadas = new System.Windows.Forms.Button();
            this.btnAdministrarDocentes = new System.Windows.Forms.Button();
            this.btnAsistencias = new System.Windows.Forms.Button();
            this.btnEvaluaciones = new System.Windows.Forms.Button();
            this.btnAdministrarAlumnos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdministrarCursos
            // 
            this.btnAdministrarCursos.Location = new System.Drawing.Point(92, 59);
            this.btnAdministrarCursos.Name = "btnAdministrarCursos";
            this.btnAdministrarCursos.Size = new System.Drawing.Size(143, 23);
            this.btnAdministrarCursos.TabIndex = 0;
            this.btnAdministrarCursos.Text = "Administrar cursos";
            this.btnAdministrarCursos.UseVisualStyleBackColor = true;
            // 
            // btnAdministrarCursadas
            // 
            this.btnAdministrarCursadas.Location = new System.Drawing.Point(92, 88);
            this.btnAdministrarCursadas.Name = "btnAdministrarCursadas";
            this.btnAdministrarCursadas.Size = new System.Drawing.Size(143, 23);
            this.btnAdministrarCursadas.TabIndex = 1;
            this.btnAdministrarCursadas.Text = "Administrar cursadas";
            this.btnAdministrarCursadas.UseVisualStyleBackColor = true;
            // 
            // btnAdministrarDocentes
            // 
            this.btnAdministrarDocentes.Location = new System.Drawing.Point(92, 117);
            this.btnAdministrarDocentes.Name = "btnAdministrarDocentes";
            this.btnAdministrarDocentes.Size = new System.Drawing.Size(143, 23);
            this.btnAdministrarDocentes.TabIndex = 2;
            this.btnAdministrarDocentes.Text = "Administrar docentes";
            this.btnAdministrarDocentes.UseVisualStyleBackColor = true;
            // 
            // btnAsistencias
            // 
            this.btnAsistencias.Location = new System.Drawing.Point(92, 175);
            this.btnAsistencias.Name = "btnAsistencias";
            this.btnAsistencias.Size = new System.Drawing.Size(143, 23);
            this.btnAsistencias.TabIndex = 3;
            this.btnAsistencias.Text = "Asistencias";
            this.btnAsistencias.UseVisualStyleBackColor = true;
            // 
            // btnEvaluaciones
            // 
            this.btnEvaluaciones.Location = new System.Drawing.Point(92, 204);
            this.btnEvaluaciones.Name = "btnEvaluaciones";
            this.btnEvaluaciones.Size = new System.Drawing.Size(143, 23);
            this.btnEvaluaciones.TabIndex = 4;
            this.btnEvaluaciones.Text = "Evaluaciones";
            this.btnEvaluaciones.UseVisualStyleBackColor = true;
            // 
            // btnAdministrarAlumnos
            // 
            this.btnAdministrarAlumnos.Location = new System.Drawing.Point(92, 146);
            this.btnAdministrarAlumnos.Name = "btnAdministrarAlumnos";
            this.btnAdministrarAlumnos.Size = new System.Drawing.Size(143, 23);
            this.btnAdministrarAlumnos.TabIndex = 5;
            this.btnAdministrarAlumnos.Text = "Administrar alumnos";
            this.btnAdministrarAlumnos.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(244, 341);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 376);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAdministrarAlumnos);
            this.Controls.Add(this.btnEvaluaciones);
            this.Controls.Add(this.btnAsistencias);
            this.Controls.Add(this.btnAdministrarDocentes);
            this.Controls.Add(this.btnAdministrarCursadas);
            this.Controls.Add(this.btnAdministrarCursos);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdministrarCursos;
        private System.Windows.Forms.Button btnAdministrarCursadas;
        private System.Windows.Forms.Button btnAdministrarDocentes;
        private System.Windows.Forms.Button btnAsistencias;
        private System.Windows.Forms.Button btnEvaluaciones;
        private System.Windows.Forms.Button btnAdministrarAlumnos;
        private System.Windows.Forms.Button btnSalir;
    }
}

