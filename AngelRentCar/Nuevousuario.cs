using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AngelRentCar
{
    class Nuevousuario
    {
        /*
        public static int Crearcuentas(string pnombre, string pUsuario, string pConstrasena, string ptipousr)
        {
            int resultado = 0;
            Conexion cone = new Conexion();
            cone.abrir();

            string sql = "insert into Usuarios(Nombre, Usuario, Clave, Tipo_usuario) values " +
                "(@Nombre, @usuario, @clave, @tipo_usuario)";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add(new SqlCommand("@Nombre") { Value = pnombre });
            cmd.Parameters.Add(new SqlCommand("@usuario") { Value = pUsuario });
            cmd.Parameters.Add(new SqlCommand("@clave") { Value = pConstrasena });
            cmd.Parameters.Add(new SqlCommand("@tipo_usuario") { Value = ptipousr });

            con.Open();
            resultado = cmd.ExecuteNonQuery();
            con.Close();

            return resultado;
        } */
    } 
}
