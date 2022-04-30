
namespace MartesDeSimu
{
    partial class FormPilotos
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
            this.lstPro = new System.Windows.Forms.ListBox();
            this.lstAm = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgregarPro = new System.Windows.Forms.TextBox();
            this.txtAgregarAm = new System.Windows.Forms.TextBox();
            this.BtnAddPro = new System.Windows.Forms.Button();
            this.BtnAddAm = new System.Windows.Forms.Button();
            this.BtnMoverAPro = new System.Windows.Forms.Button();
            this.BtnMoverAAm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPro
            // 
            this.lstPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPro.FormattingEnabled = true;
            this.lstPro.ItemHeight = 16;
            this.lstPro.Location = new System.Drawing.Point(23, 42);
            this.lstPro.Name = "lstPro";
            this.lstPro.Size = new System.Drawing.Size(290, 484);
            this.lstPro.TabIndex = 0;
            this.lstPro.SelectedIndexChanged += new System.EventHandler(this.lstPro_SelectedIndexChanged);
            // 
            // lstAm
            // 
            this.lstAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAm.FormattingEnabled = true;
            this.lstAm.ItemHeight = 16;
            this.lstAm.Location = new System.Drawing.Point(401, 42);
            this.lstAm.Name = "lstAm";
            this.lstAm.Size = new System.Drawing.Size(290, 484);
            this.lstAm.TabIndex = 1;
            this.lstAm.SelectedIndexChanged += new System.EventHandler(this.lstAm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pilotos PRO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pilotos Am:";
            // 
            // txtAgregarPro
            // 
            this.txtAgregarPro.Location = new System.Drawing.Point(23, 547);
            this.txtAgregarPro.Name = "txtAgregarPro";
            this.txtAgregarPro.Size = new System.Drawing.Size(290, 20);
            this.txtAgregarPro.TabIndex = 4;
            // 
            // txtAgregarAm
            // 
            this.txtAgregarAm.Location = new System.Drawing.Point(401, 547);
            this.txtAgregarAm.Name = "txtAgregarAm";
            this.txtAgregarAm.Size = new System.Drawing.Size(290, 20);
            this.txtAgregarAm.TabIndex = 5;
            // 
            // BtnAddPro
            // 
            this.BtnAddPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddPro.Location = new System.Drawing.Point(23, 582);
            this.BtnAddPro.Name = "BtnAddPro";
            this.BtnAddPro.Size = new System.Drawing.Size(290, 30);
            this.BtnAddPro.TabIndex = 6;
            this.BtnAddPro.Text = "Agregar Piloto Pro";
            this.BtnAddPro.UseVisualStyleBackColor = true;
            // 
            // BtnAddAm
            // 
            this.BtnAddAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAm.Location = new System.Drawing.Point(401, 582);
            this.BtnAddAm.Name = "BtnAddAm";
            this.BtnAddAm.Size = new System.Drawing.Size(290, 30);
            this.BtnAddAm.TabIndex = 7;
            this.BtnAddAm.Text = "Agregar Piloto Am";
            this.BtnAddAm.UseVisualStyleBackColor = true;
            // 
            // BtnMoverAPro
            // 
            this.BtnMoverAPro.Enabled = false;
            this.BtnMoverAPro.Location = new System.Drawing.Point(337, 244);
            this.BtnMoverAPro.Name = "BtnMoverAPro";
            this.BtnMoverAPro.Size = new System.Drawing.Size(44, 30);
            this.BtnMoverAPro.TabIndex = 8;
            this.BtnMoverAPro.Text = "<<";
            this.BtnMoverAPro.UseVisualStyleBackColor = true;
            this.BtnMoverAPro.Click += new System.EventHandler(this.BtnMoverAPro_Click);
            // 
            // BtnMoverAAm
            // 
            this.BtnMoverAAm.Enabled = false;
            this.BtnMoverAAm.Location = new System.Drawing.Point(337, 309);
            this.BtnMoverAAm.Name = "BtnMoverAAm";
            this.BtnMoverAAm.Size = new System.Drawing.Size(44, 30);
            this.BtnMoverAAm.TabIndex = 9;
            this.BtnMoverAAm.Text = ">>";
            this.BtnMoverAAm.UseVisualStyleBackColor = true;
            this.BtnMoverAAm.Click += new System.EventHandler(this.BtnMoverAAm_Click);
            // 
            // FormPilotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 646);
            this.Controls.Add(this.BtnMoverAAm);
            this.Controls.Add(this.BtnMoverAPro);
            this.Controls.Add(this.BtnAddAm);
            this.Controls.Add(this.BtnAddPro);
            this.Controls.Add(this.txtAgregarAm);
            this.Controls.Add(this.txtAgregarPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAm);
            this.Controls.Add(this.lstPro);
            this.Name = "FormPilotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pilotos MDS";
            this.Load += new System.EventHandler(this.FormPilotos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPro;
        private System.Windows.Forms.ListBox lstAm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAgregarPro;
        private System.Windows.Forms.TextBox txtAgregarAm;
        private System.Windows.Forms.Button BtnAddPro;
        private System.Windows.Forms.Button BtnAddAm;
        private System.Windows.Forms.Button BtnMoverAPro;
        private System.Windows.Forms.Button BtnMoverAAm;
    }
}