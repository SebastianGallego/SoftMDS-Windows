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
            this.lstGeneral = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.LblRuta = new System.Windows.Forms.Label();
            this.BtnGuardarBD = new System.Windows.Forms.Button();
            this.BtnLeerBD = new System.Windows.Forms.Button();
            this.BtnPilotos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CBoxCalendario = new System.Windows.Forms.ComboBox();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.lblPro = new System.Windows.Forms.Label();
            this.lstPro = new System.Windows.Forms.ListBox();
            this.lstAm = new System.Windows.Forms.ListBox();
            this.lblAm = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstGeneral
            // 
            this.lstGeneral.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGeneral.FormattingEnabled = true;
            this.lstGeneral.ItemHeight = 16;
            this.lstGeneral.Location = new System.Drawing.Point(30, 207);
            this.lstGeneral.Name = "lstGeneral";
            this.lstGeneral.Size = new System.Drawing.Size(223, 596);
            this.lstGeneral.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1003, 872);
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
            this.BtnGuardarBD.Location = new System.Drawing.Point(859, 379);
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
            this.BtnLeerBD.Location = new System.Drawing.Point(620, 34);
            this.BtnLeerBD.Name = "BtnLeerBD";
            this.BtnLeerBD.Size = new System.Drawing.Size(127, 42);
            this.BtnLeerBD.TabIndex = 6;
            this.BtnLeerBD.Text = "Leer en BD";
            this.BtnLeerBD.UseVisualStyleBackColor = false;
            this.BtnLeerBD.Click += new System.EventHandler(this.BtnLeerBD_Click);
            // 
            // BtnPilotos
            // 
            this.BtnPilotos.Location = new System.Drawing.Point(854, 34);
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
            this.groupBox1.Location = new System.Drawing.Point(774, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 157);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha / Carrera";
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
            this.CBoxCalendario.Location = new System.Drawing.Point(80, 36);
            this.CBoxCalendario.Name = "CBoxCalendario";
            this.CBoxCalendario.Size = new System.Drawing.Size(173, 24);
            this.CBoxCalendario.TabIndex = 9;
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneral.Location = new System.Drawing.Point(27, 189);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(137, 16);
            this.lblGeneral.TabIndex = 10;
            this.lblGeneral.Text = "Resultado General";
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPro.Location = new System.Drawing.Point(256, 189);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(106, 16);
            this.lblPro.TabIndex = 12;
            this.lblPro.Text = "Resultado Pro";
            // 
            // lstPro
            // 
            this.lstPro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPro.FormattingEnabled = true;
            this.lstPro.ItemHeight = 16;
            this.lstPro.Location = new System.Drawing.Point(259, 207);
            this.lstPro.Name = "lstPro";
            this.lstPro.Size = new System.Drawing.Size(223, 596);
            this.lstPro.TabIndex = 11;
            // 
            // lstAm
            // 
            this.lstAm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAm.FormattingEnabled = true;
            this.lstAm.ItemHeight = 16;
            this.lstAm.Location = new System.Drawing.Point(488, 207);
            this.lstAm.Name = "lstAm";
            this.lstAm.Size = new System.Drawing.Size(223, 596);
            this.lstAm.TabIndex = 13;
            // 
            // lblAm
            // 
            this.lblAm.AutoSize = true;
            this.lblAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAm.Location = new System.Drawing.Point(485, 189);
            this.lblAm.Name = "lblAm";
            this.lblAm.Size = new System.Drawing.Size(104, 16);
            this.lblAm.TabIndex = 14;
            this.lblAm.Text = "Resultado Am";
            // 
            // FrmCargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 912);
            this.Controls.Add(this.lblAm);
            this.Controls.Add(this.lstAm);
            this.Controls.Add(this.lblPro);
            this.Controls.Add(this.lstPro);
            this.Controls.Add(this.lblGeneral);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnPilotos);
            this.Controls.Add(this.BtnLeerBD);
            this.Controls.Add(this.BtnGuardarBD);
            this.Controls.Add(this.LblRuta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstGeneral);
            this.Name = "FrmCargar";
            this.Text = "Cargar Resultados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstGeneral;
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
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.ListBox lstPro;
        private System.Windows.Forms.ListBox lstAm;
        private System.Windows.Forms.Label lblAm;
    }
}

