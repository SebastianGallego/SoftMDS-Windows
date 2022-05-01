namespace MartesDeSimu
{
    partial class FrmCargar
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
            this.lstArchivo = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.LblRuta = new System.Windows.Forms.Label();
            this.BtnGuardarBD = new System.Windows.Forms.Button();
            this.BtnLeerBD = new System.Windows.Forms.Button();
            this.BtnPilotos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBoxCalendario = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstArchivo
            // 
            this.lstArchivo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstArchivo.FormattingEnabled = true;
            this.lstArchivo.Location = new System.Drawing.Point(30, 216);
            this.lstArchivo.Name = "lstArchivo";
            this.lstArchivo.Size = new System.Drawing.Size(602, 602);
            this.lstArchivo.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(513, 845);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(30, 96);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 41);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar Archivo de Resultados";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblRuta
            // 
            this.LblRuta.AutoSize = true;
            this.LblRuta.Location = new System.Drawing.Point(235, 110);
            this.LblRuta.Name = "LblRuta";
            this.LblRuta.Size = new System.Drawing.Size(86, 13);
            this.LblRuta.TabIndex = 4;
            this.LblRuta.Text = "Ruta del Archivo";
            // 
            // BtnGuardarBD
            // 
            this.BtnGuardarBD.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnGuardarBD.Location = new System.Drawing.Point(745, 389);
            this.BtnGuardarBD.Name = "BtnGuardarBD";
            this.BtnGuardarBD.Size = new System.Drawing.Size(197, 42);
            this.BtnGuardarBD.TabIndex = 5;
            this.BtnGuardarBD.Text = "Guardar en BD";
            this.BtnGuardarBD.UseVisualStyleBackColor = false;
            this.BtnGuardarBD.Click += new System.EventHandler(this.BtnGuardarBD_Click);
            // 
            // BtnLeerBD
            // 
            this.BtnLeerBD.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnLeerBD.Location = new System.Drawing.Point(505, 149);
            this.BtnLeerBD.Name = "BtnLeerBD";
            this.BtnLeerBD.Size = new System.Drawing.Size(127, 42);
            this.BtnLeerBD.TabIndex = 6;
            this.BtnLeerBD.Text = "Leer en BD";
            this.BtnLeerBD.UseVisualStyleBackColor = false;
            this.BtnLeerBD.Click += new System.EventHandler(this.BtnLeerBD_Click);
            // 
            // BtnPilotos
            // 
            this.BtnPilotos.Location = new System.Drawing.Point(736, 735);
            this.BtnPilotos.Name = "BtnPilotos";
            this.BtnPilotos.Size = new System.Drawing.Size(202, 50);
            this.BtnPilotos.TabIndex = 7;
            this.BtnPilotos.Text = "ABM Pilotos";
            this.BtnPilotos.UseVisualStyleBackColor = true;
            this.BtnPilotos.Click += new System.EventHandler(this.BtnPilotos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.CBoxCalendario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(656, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 157);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha / Carrera";
            // 
            // CBoxCalendario
            // 
            this.CBoxCalendario.FormattingEnabled = true;
            this.CBoxCalendario.Items.AddRange(new object[] {
            "Fecha 1",
            "Fecha 2",
            "Fecha 3",
            "Fecha 4",
            "Fecha 5",
            "Fecha 6"});
            this.CBoxCalendario.Location = new System.Drawing.Point(80, 34);
            this.CBoxCalendario.Name = "CBoxCalendario";
            this.CBoxCalendario.Size = new System.Drawing.Size(173, 24);
            this.CBoxCalendario.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(40, 86);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(194, 20);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Carrera 1 (Clasificatoria)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(40, 122);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(137, 20);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Carrera 2 (Final)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // FrmCargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 885);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnPilotos);
            this.Controls.Add(this.BtnLeerBD);
            this.Controls.Add(this.BtnGuardarBD);
            this.Controls.Add(this.LblRuta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstArchivo);
            this.Name = "FrmCargar";
            this.Text = "Cargar Resultados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstArchivo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label LblRuta;
        private System.Windows.Forms.Button BtnGuardarBD;
        private System.Windows.Forms.Button BtnLeerBD;
        private System.Windows.Forms.Button BtnPilotos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox CBoxCalendario;
    }
}

