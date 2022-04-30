using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MartesDeSimu
{
    public partial class FormPilotos : Form
    {
        public FormPilotos()
        {
            InitializeComponent();
        }

        private void FormPilotos_Load(object sender, EventArgs e)
        {

            lstPro.Items.Clear();
            lstAm.Items.Clear();    

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            
            //Cargo los Pilotos Pro
            conexion.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = MDS_DB; integrated security = true";

            try
            {
                string cadena = "SELECT Piloto from TPilotos where Categoria='Pro'";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = cadena;
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    lstPro.Items.Add(lector.GetString(0));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }
            conexion.Close();

            //Cargo los Pilotos AM
            conexion.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = MDS_DB; integrated security = true";

            try
            {
                string cadena = "SELECT Piloto from TPilotos where Categoria='Am'";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = cadena;
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    lstAm.Items.Add(lector.GetString(0));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }

            conexion.Close();





        }

        private void BtnMoverAPro_Click(object sender, EventArgs e)
        {
            lstPro.Items.Add(lstAm.SelectedItem);
            BtnMoverAPro.Enabled = false;

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            //Cargo los Pilotos Pro
            conexion.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = MDS_DB; integrated security = true";

            try
            {
                string cadena = "UPDATE TPilotos set Categoria = " + "'Pro'" + " where Piloto=" + "'" + lstAm.SelectedItem + "'";

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

            lstAm.Items.Remove(lstAm.SelectedItem);

        }

        private void BtnMoverAAm_Click(object sender, EventArgs e)
        {
            lstAm.Items.Add(lstPro.SelectedItem);
            BtnMoverAAm.Enabled = false;
            

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            //Cargo los Pilotos Pro
            conexion.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = MDS_DB; integrated security = true";

            try
            {
                string cadena = "UPDATE TPilotos set Categoria = " + "'Am'" + " where Piloto=" + "'" +lstPro.SelectedItem + "'";

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




            lstPro.Items.Remove(lstPro.SelectedItem);


        }

       
          private void lstPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPro.SelectedIndex >= 0) BtnMoverAAm.Enabled = true;
            
        }

        private void lstAm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAm.SelectedIndex >= 0) BtnMoverAPro.Enabled = true;
        }
    }



}
