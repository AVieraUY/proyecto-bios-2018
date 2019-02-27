using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    class Conexion
    {
        static string connectionString = "Server=LAPTOP-KS8F3DGA\\SQLEXPRESS;Database=ObligatorioPrimero;Trusted_Connection=True;";
        //LAPTOP-KS8F3DGA\SQLEXPRESS
          //  DESKTOP-O63HRQF\\SQLEXPRESS
        public static SqlConnection cnn = null;

        public static Conexion Conectar()
        {
            Conexion c = new Conexion();
           // if (cnn == null)
                cnn = new SqlConnection(connectionString);

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            return c;
        }

        public static void Desconectar(Conexion c)
        {
            if (cnn != null || cnn.State != ConnectionState.Closed)
                cnn.Close();

            cnn = null;
        }
    }
}
