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

            List<string> listResultados = new List<string>();
            List<string> listResultadosPro = new List<string>();
            List<string> listResultadosAm = new List<string>();



            string[] lineas = File.ReadAllLines(LblRuta.Text);

            lstGeneral.Items.Clear(); //Limpio el listbox por si tiene algo

            

            for (int x = 9; x < lineas.Length; x++)  //Cargo el LstGeneral
            {
                var valores = lineas[x].Split(',');
                string strPiloto = valores[7].TrimEnd('"');    //Le saco las "" extras
                strPiloto = strPiloto.TrimStart('"');
                                
                string posicion = valores[0].TrimEnd('"');
                posicion = posicion.TrimStart('"');
                int pos = Int32.Parse(posicion);

                string cadena = pos.ToString() + " - " + strPiloto;

                lstGeneral.Items.Add(cadena);
                listResultados.Add(cadena);

            }

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            conexion.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = MDS_DB; integrated security = true";

            List<string> pilotosPro = new List<string>();
            List<string> pilotosAm = new List<string>();    


            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Piloto from Tpilotos where categoria='Pro'";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                
                while (lector.Read())
                {
                    string fila = lector["Piloto"].ToString();
                    pilotosPro.Add(fila);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }
            conexion.Close();

            try
            {
                comando.CommandText = "select Piloto from Tpilotos where categoria='Am'";
                conexion.Open ();   
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    string fila = lector["Piloto"].ToString();
                    pilotosAm.Add(fila);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }
            conexion.Close();

            int i = 0;
            int j;
            int posPro = 1;
            int posAm = 1;


            //for (i = 0; i < listResultados.Count; i++)
            //{
            //   for(j = 0; j < listResultadosPro.Count; j++)
            //    {
            //     if(listResultados[i]==listResultadosPro[j])
            //        {
                        


            //        }    




            //    }    

            //}





        }

        private void BtnGuardarBD_Click(object sender, EventArgs e)
        {
            lstGeneral.Items.Clear();

            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataReader lector;

            conexion.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = MDS_DB; integrated security = true";


            try
            {
                string cadena = "INSERT INTO TResultados (iCalendario,iCarrera, Piloto, Pos) values (1,2,'Sebastian Gallego',2)"; 

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

                lstGeneral.Items.Clear();   

                while (lector.Read())
                {
                    string fila = lector["Puntos"].ToString() + " - " + lector["Categoria"].ToString() + " - " + lector["Piloto"].ToString();
                    lstGeneral.Items.Add(fila);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }

            conexion.Close();
        }

        private void BtnPilotos_Click(object sender, EventArgs e)
        {
            FormPilotos ventana = new FormPilotos();
            ventana.Show();
            

        }
    }
}
