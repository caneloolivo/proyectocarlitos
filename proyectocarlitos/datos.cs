using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace proyectocarlitos
{
    class datos
    {
        private static datos datos =
            new datos();

        public static datos instance
        {
            get
            {
                return datos;
            }
        }
        
        SqlConnection connection;


        public SqlConnection getConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConn"].ConnectionString);
            }
            return connection;
        }

        public bool alumno(alumno alumno)
        {
            bool result = false;

            SqlCommand insert = new SqlCommand("INSERT INTO ALUMNO(registro,nombre,apaterno,amaterno,domicilio,correo,periodo,telefono,contra,contacto,status) values(@registro,@nombre,@apaterno,@amaterno,@domicilio,@correo,@periodo,@telefono,@contra,@contacto,@status)", getConnection());
            insert.Parameters.AddWithValue("@registro", alumno.registro);
            insert.Parameters.AddWithValue("@nombre", alumno.registro);
            insert.Connection.Open();
            result = insert.ExecuteNonQuery() == 1;
            insert.Connection.Close();

            return result;
        }


    }
}
