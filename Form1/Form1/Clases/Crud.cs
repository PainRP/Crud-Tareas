using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1.Clases
{
    public class Crud
    {
        string connectionString = "Server=PAIN\\SQLEXPRESS06;Database=UMG;Integrated Security=True; TrustServerCertificate=True; ";

        public string Mostrarinformacion(string carnet)
        {
            string nombre = "No Existe";
            string seccion = "No Existe";
            string email = "No Existe";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT * FROM Tb_alumnos WHERE carnet = '{carnet}'";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        nombre = reader["estudiante"].ToString();
                        email = reader["email"].ToString();
                        seccion = reader["seccion"].ToString();
                        //Console.WriteLine($"Carnet: {reader["Carnet"]}, Nombre: {reader["estudiante"]}, Seccion: {reader["seccion"]}, Correo: {reader["email"]}");
                    }

                }
                catch (Exception ex)
                {
                    nombre = "Error";
                    //Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
                connection.Close();
            }
            return $"{nombre}, {seccion}, {email}";

        }

        public string AgregarAlumno(string carnet, string nombre, string email, string seccion)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                string query = "insert into Tb_alumnos (carnet, estudiante, email, seccion) values(@carnet, @nombre, @email, @seccion)";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@seccion", seccion);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return "Registros insertados exitosamente";
                }
                catch (Exception ex)
                {
                    return "Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message;
                }
                connection.Close();
            }
        }
       
        public string ActualizarAlumno(string carnet, string nombre, string seccion, string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                string query = "update Tb_alumnos set estudiante = @nombre, email = @email, seccion = @seccion  WHERE carnet = @carnet";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@seccion", seccion);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return "Registros insertados exitosamente";
                }
                catch (Exception ex)
                {
                    return "Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message;
                }
                connection.Close();
            }
        }

        public string EliminarInformacion(string carnet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string deleteTareasQuery = "DELETE FROM tareas WHERE carnet = @carnet";
                string deleteNotasFinalesQuery = "DELETE FROM tb_notas_finales WHERE carnet = @carnet";
                string deleteAsistenciaQuery = "DELETE FROM tb_asistencia WHERE carnet = @carnet";
                string deleteAlumnoQuery = "DELETE FROM Tb_alumnos WHERE carnet = @carnet";

                try
                {
                    connection.Open();

                    using (SqlCommand Tareas = new SqlCommand(deleteTareasQuery, connection))
                    {
                        Tareas.Parameters.AddWithValue("@carnet", carnet);
                        Tareas.ExecuteNonQuery();
                    }

                    
                    using (SqlCommand Notas = new SqlCommand(deleteNotasFinalesQuery, connection))
                    {
                        Notas.Parameters.AddWithValue("@carnet", carnet);
                        Notas.ExecuteNonQuery();
                    }

                    using (SqlCommand Asistencia = new SqlCommand(deleteAsistenciaQuery, connection))
                    {
                        Asistencia.Parameters.AddWithValue("@carnet", carnet);
                        Asistencia.ExecuteNonQuery();
                    }

                    using (SqlCommand Alumno = new SqlCommand(deleteAlumnoQuery, connection))
                    {
                        Alumno.Parameters.AddWithValue("@carnet", carnet);
                        int filasAfectadas = Alumno.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            return "Registro eliminado correctamente.";
                        }
                        else
                        {
                            return "No se encontró un alumno con ese carnet.";               
                        }
                    }
                }
                catch (Exception ex)
                {
                    return "Error al eliminar el registro: " + ex.Message;
                }
            }
        }
        public DataTable MostrarinformacionTarea(string carnet)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = $" SELECT t.id_tarea, t.Carnet, a.estudiante, t.nota1, t.nota2, t.nota3, t.nota4 FROM Tareas t INNER JOIN Tb_alumnos a ON t.Carnet = a.Carnet WHERE t.Carnet = @Carnet";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@Carnet", carnet);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public string AgregarTarea(string carnet, string nota1, string nota2, string nota3,string nota4)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = $"INSERT INTO Tareas (Carnet, nota1, nota2, nota3, nota4) VALUES (@Carnet, @n1, @n2, @n3, @n4)";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Carnet", carnet);
                    command.Parameters.AddWithValue("@n1", nota1);
                    command.Parameters.AddWithValue("@n2", nota2);
                    command.Parameters.AddWithValue("@n3", nota3);
                    command.Parameters.AddWithValue("@n4", nota4);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return "Registros insertados exitosamente";
                }
                catch (Exception ex)
                {
                    return "Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message;
                }
            }
        }

        public string EliminarInformacionTarea(string carnet, string idTarea)
        {
            if (string.IsNullOrWhiteSpace(carnet))
                return "El carnet no puede estar vacío.";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM tareas WHERE carnet = @carnet AND id_tarea = @id";

                try
                {
                    connection.Open();

                    using (SqlCommand tarea = new SqlCommand(query, connection))
                    {
                        tarea.Parameters.AddWithValue("@carnet", carnet);
                        tarea.Parameters.AddWithValue("@id", idTarea);

                        int filasAfectadas = tarea.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            return "Tarea eliminada correctamente.";
                        }
                        else
                        {
                            return "No se encontró una tarea con ese carnet e ID.";
                        }

                    }
                }
                catch (Exception ex)
                {
                    return "Error al eliminar la tarea: " + ex.Message;
                }
            }
        }

    }
}
   


