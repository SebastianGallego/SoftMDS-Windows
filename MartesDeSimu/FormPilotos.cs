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
            actualizarListas();
            
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
                string cadena = "UPDATE TPilotos set Categoria = " + "'Am'" + " where Piloto=" + "'" + lstPro.SelectedItem + "'";

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
            if (lstPro.SelectedIndex >= 0)
            {
                BtnMoverAAm.Enabled = true;
                BtnBorrarPro.Enabled = true;
            }

        }

        private void lstAm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAm.SelectedIndex >= 0)
            {
                BtnMoverAPro.Enabled = true;
                BtnBorrarAm.Enabled = true;
            }
        }

        private void txtAgregarPro_TextChanged(object sender, EventArgs e)
        {
            BtnAddPro.Enabled = true;

        }

        private void txtAgregarAm_TextChanged(object sender, EventArgs e)
        {
            BtnAddAm.Enabled = true;

        }

        private void BtnAddPro_Click(object sender, EventArgs e)
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            //Cargo los Pilotos Pro
            conexion.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = MDS_DB; integrated security = true";

            try
            {
                string cadena = "INSERT INTO TPilotos (Categoria, Piloto) values ('Pro'," + "'" + txtAgregarPro.Text + "')";

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


            actualizarListas();
            txtAgregarPro.Text = "";
            BtnAddPro.Enabled = false;

        }

        private void BtnAddAm_Click(object sender, EventArgs e)
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            //Cargo los Pilotos Pro
            conexion.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = MDS_DB; integrated security = true";

            try
            {
                string cadena = "INSERT INTO TPilotos (Categoria, Piloto) values ('Am'," + "'" + txtAgregarAm.Text + "')";

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



            actualizarListas();
            txtAgregarAm.Text = "";
            BtnAddAm.Enabled = false;

        }





        private void actualizarListas()
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

        private void txtAgregarPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnAddPro_Click(sender, e);

            }
        }

        private void txtAgregarAm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnAddAm_Click(sender, e);

            }
        }

    }
}
