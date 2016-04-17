using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace proyectocarlitos
{
    class datos
    {

        private static datos datingos = new datos();



        public static datos instance
        {
            get
            {
                return datingos;
            }
        }
        
       MySqlConnection connection;


       public MySqlConnection getConnection()
       {
           if (connection == null)
           {
               connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["myConn"].ConnectionString);
           }
           return connection;
       }
        public bool alumno(alumno alumno){
        

            bool result = false;
            try
            {
                MySqlCommand insert = new MySqlCommand("INSERT INTO alumno(registro,nombre,apaterno,amaterno,domicilio,correo,periodo,telefono,contra,contactoemergencia,numemergencia,carrera) values(@registro,@nombre,@apaterno,@amaterno,@domicilio,@correo,@periodo,@telefono,@contra,@contactoemergencia,@numemergencia,@carrera)", getConnection());
                insert.Parameters.AddWithValue("@registro", alumno.registro);
                insert.Parameters.AddWithValue("@nombre", alumno.nombre);
                insert.Parameters.AddWithValue("@apaterno", alumno.aPaterno);
                insert.Parameters.AddWithValue("@amaterno", alumno.aMaterno);
                insert.Parameters.AddWithValue("@domicilio", alumno.domicilio);
                insert.Parameters.AddWithValue("@correo", alumno.correo);
                insert.Parameters.AddWithValue("@periodo", alumno.periodo);
                insert.Parameters.AddWithValue("@telefono", alumno.telefono);
                insert.Parameters.AddWithValue("@contra", alumno.contrasena);
                insert.Parameters.AddWithValue("@contactoemergencia", alumno.contactoemergencia);
                insert.Parameters.AddWithValue("@numemergencia", alumno.numemergencia);
                insert.Parameters.AddWithValue("@carrera", alumno.carrera);
                insert.Connection.Open();
                result = insert.ExecuteNonQuery() == 1;
                insert.Connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.Out.Write(ex.Message);
            }

            return result;
        }
    }
}
