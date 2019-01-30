using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EntidadesCompartidas;

namespace Persistencia
{
    public class perUsuario
    {
        public int Baja(string pUsername)
        {
            Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("EliminarUsuario", Conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("userName", pUsername));

            SqlParameter r = new SqlParameter();
            r.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(r);

            cmd.ExecuteNonQuery();

            Conexion.Desconectar();

            return Convert.ToInt32(r.Value);
        }
    }
}
