using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace proyectocarlitos
{
    class Datos
    {
        private static Datos datos =
            new Datos();

        public static Datos instance
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
                connection = new SqlConnection(
                    ConfigurationManager.ConnectionStrings["myConn"].ConnectionString);
            }
            return connection;
        }

        public bool alumno(alumno alumno)
        {
            bool result = false;

                SqlCommand insert = new SqlCommand("INSERT INTO alumno(registro,nombre,apaterno,amaterno,domicilio,correo,periodo,telefono,contra,contactoemergencia,numemergencia,carrera) values(@registro,@nombre,@apaterno,@amaterno,@domicilio,@correo,@periodo,@telefono,@contra,@contactoemergencia,@numemergencia,@carrera)", getConnection());
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
                return result;
            }

        public bool carrera(carrera carrera)
        {
            bool result = false;

            SqlCommand insert = new SqlCommand("INSERT INTO carrera(director,nombre,totalperiodo,facultad,periodo,estado) values(@director,@nombre,@totalperiodo,@facultad,@periodo,@estado)", getConnection());
            insert.Parameters.AddWithValue("@director", carrera.director);
            insert.Parameters.AddWithValue("@nombre", carrera.nombre);
            insert.Parameters.AddWithValue("@totalperiodo", carrera.totalPeriodo);
            insert.Parameters.AddWithValue("@facultad", carrera.facultad);
            insert.Parameters.AddWithValue("@periodo", carrera.tipoPeriodos);
            insert.Parameters.AddWithValue("@estado", carrera.estado);
            insert.Connection.Open();
            result = insert.ExecuteNonQuery() == 1;
            insert.Connection.Close();
            return result;
        }

        public bool empresa(empresa empresa)
        {
            bool result = false;

            SqlCommand insert = new SqlCommand("INSERT INTO empresa(rfc,nombre,giro,representantelegal,direccion,telefono,areastrabajo,horario,descripcion,status) values(@rfc,@nombre,@giro,@representantelegal,@direccion,@telefono,@areastrabajo,@horario,@descripcion,@status)", getConnection());
            insert.Parameters.AddWithValue("@rfc", empresa.rfc);
            insert.Parameters.AddWithValue("@nombre", empresa.nombre);
            insert.Parameters.AddWithValue("@giro", empresa.giro);
            insert.Parameters.AddWithValue("@representantelegal", empresa.representantelegal);
            insert.Parameters.AddWithValue("@direccion", empresa.direccion);
            insert.Parameters.AddWithValue("@telefono", empresa.telefono);
            insert.Parameters.AddWithValue("@areastrabajo", empresa.areastrabajo);
            insert.Parameters.AddWithValue("@horario", empresa.horario);
            insert.Parameters.AddWithValue("@descripcion", empresa.descripcion);
            insert.Parameters.AddWithValue("@status", empresa.status);
            insert.Connection.Open();
            result = insert.ExecuteNonQuery() == 1;
            insert.Connection.Close();
            return result;
        }

        public List<alumno> buscarAlumnos()
        {
            List<alumno> alumno = new List<alumno>();

            SqlCommand sqlCommand = new SqlCommand("SELECT registro,nombre,apaterno,amaterno,domicilio,correo,periodo,telefono,contra,contactoemergencia,numemergencia,carrera FROM alumno", getConnection());
            sqlCommand.Connection.Open();

            try
            {
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    alumno security = new alumno();
                    security.registro = dataReader.GetInt32(0);
                    security.nombre = dataReader.GetString(1);
                    security.aPaterno = dataReader.GetString(2);
                    security.aMaterno = dataReader.GetString(3);
                    security.domicilio = dataReader.GetString(4);
                    security.correo = dataReader.GetString(5);
                    security.periodo= dataReader.GetInt32(6);
                    security.telefono = dataReader.GetInt32(7);
                    security.contrasena = dataReader.GetString(8);
                    security.contactoemergencia = dataReader.GetString(9);
                    security.numemergencia = dataReader.GetInt32(10);
                    security.carrera = dataReader.GetString(11);

                    alumno.Add(security);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlCommand.Connection.Close();
            }
            return alumno;
        }
        public alumno ObtenerAlumno(Int32 pid)
        {

            alumno security = new alumno();
            SqlCommand sqlCommand = new SqlCommand(string.Format("SELECT registro,nombre,apaterno,amaterno,domicilio,correo,periodo,telefono,contra,contactoemergencia,numemergencia,carrera FROM alumno where registro={0}", pid), getConnection());
            sqlCommand.Connection.Open();

            try
            {
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {

                    security.registro = dataReader.GetInt32(0);
                    security.nombre = dataReader.GetString(1);
                    security.aPaterno = dataReader.GetString(2);
                    security.aMaterno = dataReader.GetString(3);
                    security.domicilio = dataReader.GetString(4);
                    security.correo = dataReader.GetString(5);
                    security.periodo = dataReader.GetInt32(6);
                    security.telefono = dataReader.GetInt32(7);
                    security.contrasena = dataReader.GetString(8);
                    security.contactoemergencia = dataReader.GetString(9);
                    security.numemergencia = dataReader.GetInt32(10);
                    security.carrera = dataReader.GetString(11);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlCommand.Connection.Close();
            }
            return security;
        }

        public int updateAlumno(alumno alumno)
        {
            int retorno = 0;

            SqlCommand Update = new SqlCommand(string.Format("UPDATE alumno set  domicilio= '{0}', correo = '{1}' , periodo= '{2}' , telefono= '{3}' , contra= '{4}', contactoemergencia = '{5}', numemergencia = '{6}' , carrera= '{7}' where registro={8}", alumno.domicilio, alumno.correo, alumno.periodo, alumno.telefono, alumno.contrasena, alumno.contactoemergencia, alumno.numemergencia, alumno.carrera, alumno.registro), getConnection());
            Update.Connection.Open();
            retorno = Update.ExecuteNonQuery();
            Update.Connection.Close();

            return retorno;
        }

    //Carrera
        public List<carrera> buscarCarrera()
        {
            List<carrera> carrera = new List<carrera>();

            SqlCommand sqlCommand = new SqlCommand("SELECT director,nombre,totalperiodo,facultad,periodo,estado FROM carrera", getConnection());
            sqlCommand.Connection.Open();

            try
            {
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    carrera security = new carrera();
                    security.director = dataReader.GetString(0);
                    security.nombre = dataReader.GetString(1);
                    security.totalPeriodo = dataReader.GetInt32(2);
                    security.facultad = dataReader.GetString(3);
                    security.tipoPeriodos= dataReader.GetString(4);
                    security.estado = dataReader.GetString(5);
                    carrera.Add(security);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlCommand.Connection.Close();
            }
            return carrera;
        }


   }
}

