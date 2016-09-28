namespace DSI_TP_Integrador
{
    partial class frmAsistencias
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
            this.lstCursadas = new System.Windows.Forms.ListBox();
            this.lstClases = new System.Windows.Forms.ListBox();
            this.btnTomarAsistencia = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lstAlumnos = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lstCursadas
            // 
            this.lstCursadas.FormattingEnabled = true;
            this.lstCursadas.Location = new System.Drawing.Point(31, 66);
            this.lstCursadas.Name = "lstCursadas";
            this.lstCursadas.Size = new System.Drawing.Size(209, 199);
            this.lstCursadas.TabIndex = 0;
            this.lstCursadas.SelectedIndexChanged += new System.EventHandler(this.lstCursadas_SelectedIndexChanged);
            // 
            // lstClases
            // 
            this.lstClases.FormattingEnabled = true;
            this.lstClases.Location = new System.Drawing.Point(255, 66);
            this.lstClases.Name = "lstClases";
            this.lstClases.Size = new System.Drawing.Size(209, 199);
            this.lstClases.TabIndex = 1;
            this.lstClases.SelectedIndexChanged += new System.EventHandler(this.lstClases_SelectedIndexChanged);
            // 
            // btnTomarAsistencia
            // 
            this.btnTomarAsistencia.Location = new System.Drawing.Point(482, 315);
            this.btnTomarAsistencia.Name = "btnTomarAsistencia";
            this.btnTomarAsistencia.Size = new System.Drawing.Size(109, 23);
            this.btnTomarAsistencia.TabIndex = 3;
            this.btnTomarAsistencia.Text = "Tomar Asistencia";
            this.btnTomarAsistencia.UseVisualStyleBackColor = true;
            this.btnTomarAsistencia.Click += new System.EventHandler(this.btnTomarAsistencia_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(637, 315);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.Location = new System.Drawing.Point(482, 66);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(209, 199);
            this.lstAlumnos.TabIndex = 5;
            // 
            // frmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 350);
            this.Controls.Add(this.lstAlumnos);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnTomarAsistencia);
            this.Controls.Add(this.lstClases);
            this.Controls.Add(this.lstCursadas);
            this.Name = "frmAsistencias";
            this.Text = "frmAsistencias";
            this.Load += new System.EventHandler(this.frmAsistencias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCursadas;
        private System.Windows.Forms.ListBox lstClases;
        private System.Windows.Forms.Button btnTomarAsistencia;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.CheckedListBox lstAlumnos;
    }
}