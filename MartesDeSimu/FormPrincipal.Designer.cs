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
            this.btnLeer = new System.Windows.Forms.Button();
            this.lstArchivo = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.LblRuta = new System.Windows.Forms.Label();
            this.BtnGuardarBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnLeer.Location = new System.Drawing.Point(30, 149);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(123, 42);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer Archivo";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.BtnLeer_Click);
            // 
            // lstArchivo
            // 
            this.lstArchivo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstArchivo.FormattingEnabled = true;
            this.lstArchivo.Location = new System.Drawing.Point(30, 216);
            this.lstArchivo.Name = "lstArchivo";
            this.lstArchivo.Size = new System.Drawing.Size(1382, 602);
            this.lstArchivo.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(927, 845);
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
            this.LblRuta.Location = new System.Drawing.Point(219, 110);
            this.LblRuta.Name = "LblRuta";
            this.LblRuta.Size = new System.Drawing.Size(86, 13);
            this.LblRuta.TabIndex = 4;
            this.LblRuta.Text = "Ruta del Archivo";
            // 
            // BtnGuardarBD
            // 
            this.BtnGuardarBD.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnGuardarBD.Location = new System.Drawing.Point(178, 149);
            this.BtnGuardarBD.Name = "BtnGuardarBD";
            this.BtnGuardarBD.Size = new System.Drawing.Size(127, 42);
            this.BtnGuardarBD.TabIndex = 5;
            this.BtnGuardarBD.Text = "Guardar en BD";
            this.BtnGuardarBD.UseVisualStyleBackColor = false;
            this.BtnGuardarBD.Click += new System.EventHandler(this.BtnGuardarBD_Click);
            // 
            // FrmCargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 885);
            this.Controls.Add(this.BtnGuardarBD);
            this.Controls.Add(this.LblRuta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstArchivo);
            this.Controls.Add(this.btnLeer);
            this.Name = "FrmCargar";
            this.Text = "Cargar Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.ListBox lstArchivo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label LblRuta;
        private System.Windows.Forms.Button BtnGuardarBD;
    }
}

