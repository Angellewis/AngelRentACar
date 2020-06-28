using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AngelRentCar
{
    class Conexion
    {
            //Cadena de Conexion
            string cadena = "Data Source=DESKTOP-03NU653\\ANGEL;Initial Catalog = AngelRentCar; Integrated Security=True";
            public SqlConnection Conectar = new SqlConnection();

            //Constructor
            public Conexion()
            {
            Conectar.ConnectionString = cadena;
            }

            //Metodo para abrir la conexion
            public void abrir()
            {
                try
                {
                    Conectar.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error al abrir BD ", ex.Message);
                }
            }

            //Metodo para cerrar la conexion
            public void cerrar()
            {
                Conectar.Close();
            }    
    }
}
