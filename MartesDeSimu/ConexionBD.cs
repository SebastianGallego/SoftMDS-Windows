using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;




namespace MartesDeSimu
{
    internal class ConexionBD
    {

        public SqlConnection Conectarbd = new SqlConnection();

        //Constructor
        public ConexionBD()
        {
            Conectarbd.ConnectionString = "data source = .\\SQLEXPRESS; initial catalog = MDS_DB; integrated security = true" ;
        }

        //Metodo para abrir la conexion
        public void Abrir()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void Cerrar()
        {
            Conectarbd.Close();
        }





    }
}
