﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    class Conexion
    {
        static string connectionString = "Server=DESKTOP-AVR1R3H\\SQLEXPRESS;Database=ObligatorioPrimero;Trusted_Connection=True;";
        //LAPTOP-KS8F3DGA\\SQLEXPRESS
        //DESKTOP-AVR1R3H\\SQLEXPRESS (Diego)
          //  DESKTOP-O63HRQF\\SQLEXPRESS

        public static SqlConnection Conectar()
        {
            SqlConnection cnn = null;
                cnn = new SqlConnection(connectionString);

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
           
            return cnn;
        }

        public static void Desconectar(SqlConnection cnn)
        {
            if (cnn != null || cnn.State != ConnectionState.Closed)
                cnn.Close();

            cnn = null;
        }
    }
}
