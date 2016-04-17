using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace proyectocarlitos
{
    class datos
    {
<<<<<<< HEAD
        private static datos datingoss = new datos();
=======

        private static datos datos = new datos();


>>>>>>> origin/master

        public static datos instance
        {
            get
            {
                return datingoss;
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

            SqlCommand insert = new SqlCommand("INSERT INTO ALUMNO(registro,nombre,apaterno,amaterno,domicilio,correo,periodo,telefono,contra,contactoemergencia,numemergencia,carrera) values(@registro,@nombre,@apaterno,@amaterno,@domicilio,@correo,@periodo,@telefono,@contra,@contactoemergencia,@numemergencia,@carrera)", getConnection());
            insert.Parameters.AddWithValue("@registro", alumno.registro);
            insert.Parameters.AddWithValue("@nombre", alumno.nombre);
            insert.Parameters.AddWithValue("@apaterno", alumno.aPaterno);
            insert.Parameters.AddWithValue("@amaterno", alumno.aMaterno);
            insert.Parameters.AddWithValue("@domicilio", alumno.domicilio);
            insert.Parameters.AddWithValue("@correo", alumno.correo);
            insert.Parameters.AddWithValue("@periodo", alumno.periodo);
            insert.Parameters.AddWithValue("@correo", alumno.correo);
            insert.Parameters.AddWithValue("@periodo", alumno.periodo);
            insert.Parameters.AddWithValue("@telefono", alumno.telefono);
            insert.Parameters.AddWithValue("@contra", alumno.contrasena);
            insert.Parameters.AddWithValue("@contactoemergencia", alumno.contactoemergencia);
<<<<<<< HEAD
            insert.Parameters.AddWithValue("@numemergencia", alumno.telefonoContacto);
=======
>>>>>>> origin/master
            insert.Parameters.AddWithValue("@numemergencia", alumno.numemergencia);
            insert.Parameters.AddWithValue("@carrera", alumno.carrera);
            insert.Connection.Open();
            result = insert.ExecuteNonQuery() == 1;
            insert.Connection.Close();

            return result;
        }


    }
}
