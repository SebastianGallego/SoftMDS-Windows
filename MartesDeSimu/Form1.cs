using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MartesDeSimu
{
    public partial class FrmCargar : Form
    {
        public FrmCargar()
        {
            InitializeComponent();

            


        }

        

        private void BtnLeer_Click(object sender, EventArgs e)
        {

            string[] lineas = File.ReadAllLines(LblRuta.Text);

            for (int i = 0; i < lineas.Length; i++)
            {
                lstArchivo.Items.Add(lineas[i]);

            }





        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos csv|*.csv";
            open.Title = "Archivos csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                LblRuta.Text = open.FileName;

            }
            open.Dispose(); 


            //prueba commit Version 02  10:40


        }
    }
}
