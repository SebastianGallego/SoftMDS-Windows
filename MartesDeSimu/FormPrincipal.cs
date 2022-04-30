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
using System.Data.SqlClient;

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

            for (int i = 9; i < lineas.Length; i++)
            {

                var valores = lineas[i].Split(',');
                
                string strPiloto = valores[7].TrimEnd('"');    //Le saco las "" extras
                strPiloto = strPiloto.TrimStart('"');
                
                string strCategotia = valores[4].TrimEnd('"');
                strCategotia = strCategotia.TrimStart('"');

                string posicion = valores[0].TrimEnd('"');
                posicion = posicion.TrimStart('"');
                int pos = Int32.Parse(posicion);


               string cadena =pos.ToString() + " - " + strCategotia + "- " + strPiloto;

                lstArchivo.Items.Add(cadena);

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

        private void BtnGuardarBD_Click(object sender, EventArgs e)
        {
            lstArchivo.Items.Clear();

            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataReader lector;

            conexion.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = MDS_DB; integrated security = true";


            try
            {
                string cadena = "INSERT INTO TablaTorneo (Categoria, Piloto, Puntos) values ('AM','Fernando Dadamo',15)"; 

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = cadena;
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                

            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }

            conexion.Close();


        }

        private void BtnLeerBD_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataReader lector;

            conexion.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = MDS_DB; integrated security = true";


            try
            {

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from TablaTorneo";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                lstArchivo.Items.Clear();   

                while (lector.Read())
                {
                    string fila = lector["Puntos"].ToString() + " - " + lector["Categoria"].ToString() + " - " + lector["Piloto"].ToString();
                    lstArchivo.Items.Add(fila);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }

            conexion.Close();
        }
    }
}
