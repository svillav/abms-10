
namespace TP9_ABSM_B
{
    partial class ABMS
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Alumno = new System.Windows.Forms.GroupBox();
            this.guardar1 = new System.Windows.Forms.Button();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.dni1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nota = new System.Windows.Forms.GroupBox();
            this.guardar2 = new System.Windows.Forms.Button();
            this.dni2 = new System.Windows.Forms.NumericUpDown();
            this._nota = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modificar1 = new System.Windows.Forms.Button();
            this.modificar2 = new System.Windows.Forms.Button();
            this.borrar1 = new System.Windows.Forms.Button();
            this.borrar2 = new System.Windows.Forms.Button();
            this.ordenarAlumnos = new System.Windows.Forms.Button();
            this.ordenarNotas = new System.Windows.Forms.Button();
            this.aparearArchivos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Alumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dni1)).BeginInit();
            this.nota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dni2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Notas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(354, 211);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(39, 414);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(354, 251);
            this.dataGridView2.TabIndex = 3;
            // 
            // Alumno
            // 
            this.Alumno.Controls.Add(this.guardar1);
            this.Alumno.Controls.Add(this.apellido);
            this.Alumno.Controls.Add(this.nombre);
            this.Alumno.Controls.Add(this.dni1);
            this.Alumno.Controls.Add(this.label5);
            this.Alumno.Controls.Add(this.label4);
            this.Alumno.Controls.Add(this.label3);
            this.Alumno.Location = new System.Drawing.Point(452, 49);
            this.Alumno.Name = "Alumno";
            this.Alumno.Size = new System.Drawing.Size(379, 311);
            this.Alumno.TabIndex = 4;
            this.Alumno.TabStop = false;
            this.Alumno.Text = "Alumno";
            // 
            // guardar1
            // 
            this.guardar1.Location = new System.Drawing.Point(123, 248);
            this.guardar1.Name = "guardar1";
            this.guardar1.Size = new System.Drawing.Size(161, 41);
            this.guardar1.TabIndex = 17;
            this.guardar1.Text = "Guardar";
            this.guardar1.UseVisualStyleBackColor = true;
            this.guardar1.Click += new System.EventHandler(this.guardar1_Click);
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(123, 196);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(200, 26);
            this.apellido.TabIndex = 16;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(123, 132);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(200, 26);
            this.nombre.TabIndex = 15;
            // 
            // dni1
            // 
            this.dni1.Location = new System.Drawing.Point(123, 66);
            this.dni1.Name = "dni1";
            this.dni1.Size = new System.Drawing.Size(200, 26);
            this.dni1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI";
            // 
            // nota
            // 
            this.nota.Controls.Add(this.guardar2);
            this.nota.Controls.Add(this.dni2);
            this.nota.Controls.Add(this._nota);
            this.nota.Controls.Add(this.label8);
            this.nota.Controls.Add(this.fecha);
            this.nota.Controls.Add(this.label7);
            this.nota.Controls.Add(this.label6);
            this.nota.Location = new System.Drawing.Point(452, 405);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(379, 335);
            this.nota.TabIndex = 5;
            this.nota.TabStop = false;
            this.nota.Text = "Nota";
            // 
            // guardar2
            // 
            this.guardar2.Location = new System.Drawing.Point(123, 271);
            this.guardar2.Name = "guardar2";
            this.guardar2.Size = new System.Drawing.Size(161, 41);
            this.guardar2.TabIndex = 18;
            this.guardar2.Text = "Guardar";
            this.guardar2.UseVisualStyleBackColor = true;
            this.guardar2.Click += new System.EventHandler(this.guardar2_Click);
            // 
            // dni2
            // 
            this.dni2.Location = new System.Drawing.Point(122, 76);
            this.dni2.Name = "dni2";
            this.dni2.Size = new System.Drawing.Size(200, 26);
            this.dni2.TabIndex = 13;
            // 
            // _nota
            // 
            this._nota.Location = new System.Drawing.Point(122, 148);
            this._nota.Name = "_nota";
            this._nota.Size = new System.Drawing.Size(200, 26);
            this._nota.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fecha";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(122, 213);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 26);
            this.fecha.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "DNI";
            // 
            // modificar1
            // 
            this.modificar1.Location = new System.Drawing.Point(71, 297);
            this.modificar1.Name = "modificar1";
            this.modificar1.Size = new System.Drawing.Size(125, 41);
            this.modificar1.TabIndex = 6;
            this.modificar1.Text = "Modificar";
            this.modificar1.UseVisualStyleBackColor = true;
            this.modificar1.Click += new System.EventHandler(this.modificar1_Click);
            // 
            // modificar2
            // 
            this.modificar2.Location = new System.Drawing.Point(75, 697);
            this.modificar2.Name = "modificar2";
            this.modificar2.Size = new System.Drawing.Size(125, 41);
            this.modificar2.TabIndex = 7;
            this.modificar2.Text = "Modificar";
            this.modificar2.UseVisualStyleBackColor = true;
            this.modificar2.Click += new System.EventHandler(this.modificar2_Click);
            // 
            // borrar1
            // 
            this.borrar1.Location = new System.Drawing.Point(222, 297);
            this.borrar1.Name = "borrar1";
            this.borrar1.Size = new System.Drawing.Size(123, 41);
            this.borrar1.TabIndex = 8;
            this.borrar1.Text = "Borrar";
            this.borrar1.UseVisualStyleBackColor = true;
            this.borrar1.Click += new System.EventHandler(this.borrar1_Click);
            // 
            // borrar2
            // 
            this.borrar2.Location = new System.Drawing.Point(226, 697);
            this.borrar2.Name = "borrar2";
            this.borrar2.Size = new System.Drawing.Size(123, 41);
            this.borrar2.TabIndex = 9;
            this.borrar2.Text = "Borrar";
            this.borrar2.UseVisualStyleBackColor = true;
            this.borrar2.Click += new System.EventHandler(this.borrar2_Click);
            // 
            // ordenarAlumnos
            // 
            this.ordenarAlumnos.Location = new System.Drawing.Point(108, 769);
            this.ordenarAlumnos.Name = "ordenarAlumnos";
            this.ordenarAlumnos.Size = new System.Drawing.Size(183, 72);
            this.ordenarAlumnos.TabIndex = 11;
            this.ordenarAlumnos.Text = "Ordenar Alumnos";
            this.ordenarAlumnos.UseVisualStyleBackColor = true;
            this.ordenarAlumnos.Click += new System.EventHandler(this.ordenarAlumnos_Click);
            // 
            // ordenarNotas
            // 
            this.ordenarNotas.Location = new System.Drawing.Point(332, 769);
            this.ordenarNotas.Name = "ordenarNotas";
            this.ordenarNotas.Size = new System.Drawing.Size(183, 72);
            this.ordenarNotas.TabIndex = 12;
            this.ordenarNotas.Text = "Ordenar Notas";
            this.ordenarNotas.UseVisualStyleBackColor = true;
            this.ordenarNotas.Click += new System.EventHandler(this.ordenarNotas_Click);
            // 
            // aparearArchivos
            // 
            this.aparearArchivos.Location = new System.Drawing.Point(556, 769);
            this.aparearArchivos.Name = "aparearArchivos";
            this.aparearArchivos.Size = new System.Drawing.Size(183, 72);
            this.aparearArchivos.TabIndex = 13;
            this.aparearArchivos.Text = "Aparear Archivos";
            this.aparearArchivos.UseVisualStyleBackColor = true;
            this.aparearArchivos.Click += new System.EventHandler(this.aparearArchivos_Click);
            // 
            // ABMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 859);
            this.Controls.Add(this.aparearArchivos);
            this.Controls.Add(this.ordenarNotas);
            this.Controls.Add(this.ordenarAlumnos);
            this.Controls.Add(this.borrar2);
            this.Controls.Add(this.borrar1);
            this.Controls.Add(this.modificar2);
            this.Controls.Add(this.modificar1);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.Alumno);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ABMS";
            this.Text = "ABMS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Alumno.ResumeLayout(false);
            this.Alumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dni1)).EndInit();
            this.nota.ResumeLayout(false);
            this.nota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dni2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox Alumno;
        private System.Windows.Forms.NumericUpDown dni1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox nota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.NumericUpDown dni2;
        private System.Windows.Forms.NumericUpDown _nota;
        private System.Windows.Forms.Button guardar1;
        private System.Windows.Forms.Button guardar2;
        private System.Windows.Forms.Button modificar1;
        private System.Windows.Forms.Button modificar2;
        private System.Windows.Forms.Button borrar1;
        private System.Windows.Forms.Button borrar2;
        private System.Windows.Forms.Button ordenarAlumnos;
        private System.Windows.Forms.Button ordenarNotas;
        private System.Windows.Forms.Button aparearArchivos;
    }
}

